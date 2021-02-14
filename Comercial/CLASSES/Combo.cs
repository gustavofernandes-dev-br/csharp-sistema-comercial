using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Combo:ConexaoSQL
    {
        //Tem que revisar, mas serve para verificar se um combobox não foi devidamente preenchido
        public bool ComboTesta(ComboBox ParCombo)
        {
            if (ParCombo.SelectedItem == null )
            {
                ParCombo.BackColor = Color.Yellow;
                return false;
            }
            else
            { 
                return true;
            }
        }

        public void ComboLimpa(ComboBox ParCombo)
        {
            if (ParCombo.Enabled == true && ParCombo.Visible == true)
            {
                if (ParCombo.Items.Count > 1)
                {
                    ParCombo.SelectedItem = null;
                    ParCombo.Refresh();
                }
            }
        }

         //Preenche ComboBox com os parametros especificos
         private Boolean ComboPreencheSql(ComboBox ParCombo, String ParCodigo, String ParDescricao, String ParTabela, String ParCondicao)
        {
            try
            {
                string text = "";
                text = "SELECT " + ParCodigo + "," + ParDescricao + " FROM " + ParTabela  + " WHERE " + ParCondicao ;

                this.adp = new SqlDataAdapter(text,this.ConexaoAtiva);
                DataTable dtResultado = new DataTable();
                dtResultado.Clear();

                ParCombo.DataSource = null;
                adp.Fill(dtResultado);

                ParCombo.DataSource = dtResultado;
                ParCombo.ValueMember = ParCodigo;
                ParCombo.DisplayMember = ParDescricao;
                ParCombo.SelectedItem = null;
                ParCombo.Refresh();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return false;
                throw;
            }
        }

         private Boolean ComboValida(ComboBox ParCombo, Int32 ParCodigo, String ParDescricao = "")
         {
             
             try
             {  
                 ParCombo.SelectedItem = ParCodigo;
                 ParCombo.Refresh();
                 return true;
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error");
                 return false;
                 throw;
             }
         }

         //Função de carregar lista e consultores verificando o perfil do mesmo.
         public void ComboConsultores(ComboBox ParCombo)
         {
             if (UsuarioLogado.usuario.perfil.ToString().Trim() == "3")
             {
                 ComboPreencheSql(ParCombo, "US_ID", "US_NOME", "USUARIOS", "US_ID = " + UsuarioLogado.usuario.id.ToString().Trim() + " AND US_INATIVO = '0' order by us_nome");
                 ParCombo.Enabled = false;
                 ParCombo.SelectedValue = UsuarioLogado.usuario.id;
             }
             else
             {
                 ComboPreencheSql(ParCombo, "US_ID", "US_NOME", "USUARIOS", "US_INATIVO = '0' order by us_nome");
             }
         }

         
    }
}
