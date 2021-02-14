using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CadastroClientes1 : Form
    {
        public CadastroClientes1()
        {
            InitializeComponent();
        }
        Clientes clientes = new Clientes();

        
      
 
     
        private void bntIncluir_Click(object sender, EventArgs e)
        {
            CadastroClientes cadastro = new CadastroClientes();
            cadastro.Show();
            this.Close();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            CadastroClientes cadastro = new CadastroClientes();

            cadastro.IncluiDados();
            cadastro.ShowDialog();   

            if (VariaveisStaticas.entrouNoClientePelaProspeccao == true)
            {
                this.Close();
            }
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inativoschk;
            if (chkInativos.Checked == true)
                inativoschk = "1";
            else
                inativoschk = "0";

                     

            if (dgvClientes.RowCount > 0)
                comercial.CLIENTES_GRIDVIEW.Clear();

            if (UsuarioLogado.usuario.perfil.ToString().Trim() == "3")
            {
               this.clientes.GetClientesPorConsultor(this.comercial, txtPesquisarNome.Text, inativoschk,
               UsuarioLogado.usuario.id);
            }
            else
            {
                this.clientes.GetClientes(this.comercial, txtPesquisarNome.Text, inativoschk);
            }
               
        }

        private void bntLimparPesquisa_Click(object sender, EventArgs e)
        {
            txtPesquisarNome.Text = string.Empty;
            chkInativos.Checked = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        //dados tabela usuarios
        public string Nnome, ddd, tel1, tel2, resp, telresp, decisor, teldecisor, email, inativo,usuarioAlteracao,usuarioCadastro = null;
        public int pontos, concorrente, indicacao, ramoatuacao, usuarioId, consultor = -1;
        public DateTime cadastro, atualizacao;

        //dados tabela endereco
        public string cep, rua, numero, complemento,bairro = null;
        public string  uf, cidade = null;

        //dados tabela obs
        public string obs = null;

        private void ConsultarClientes()
        {
             if (dgvClientes.RowCount == 0)
            {
                MessageBox.Show("Selecione algum cliente");
                return;
            }

             if (dgvClientes.RowCount > 0)
             {

                 try
                 {
                     VariaveisStaticas.codigoclienteStatico = dgvClientes.CurrentRow.Cells[0].Value.ToString().Trim();
                     CadastroClientes formalterar = new CadastroClientes();
                     formalterar.GetDadosConsultar();

                     formalterar.ShowDialog();

                     if (VariaveisStaticas.entrouNoClientePelaProspeccao == true)
                     {
                         this.Close();
                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Aconteceu algum erro \n" + ex.Message, "Erro teste");

                     // throw new Exception (ex.Message);
                 }
             }

        }
        

        private void AlterarClientes()
        {
            if (dgvClientes.RowCount == 0)
            {
                MessageBox.Show("Selecione algum cliente");
                return;
            }

            if (dgvClientes.RowCount > 0)
            {
                try
                {
                    VariaveisStaticas.codigoclienteStatico = dgvClientes.CurrentRow.Cells[0].Value.ToString().Trim();    
                    CadastroClientes formalterar = new CadastroClientes();
                    formalterar.GetDadosAlterar();  
                    
                    formalterar.ShowDialog();
                                        
                    if (VariaveisStaticas.entrouNoClientePelaProspeccao == true)
                    {                                     
                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Aconteceu algum erro \n" + ex.Message, "Erro teste");

                    // throw new Exception (ex.Message);
                }

            }
        
        }

        


        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AlterarClientes();
        }

        private void CadastroClientes1_Load(object sender, EventArgs e)
        {
      
            ////Formatando data gri view
            //dgvClientes.Columns[0].HeaderText = "Código";
            //dgvClientes.Columns[0].Width = 50;
            //dgvClientes.Columns[1].HeaderText = "Nome";
            //dgvClientes.Columns[1].Width = 150;
            //dgvClientes.Columns[2].HeaderText = "Telefone1";
            //dgvClientes.Columns[2].Width = 80;
            //dgvClientes.Columns[3].HeaderText = "Telefone2";
            //dgvClientes.Columns[3].Width = 80;
            //dgvClientes.Columns[4].Visible = false; //responsavel
            //dgvClientes.Columns[5].Visible = false; //tel responsavel
            //dgvClientes.Columns[6].Visible = false; //decisor
            //dgvClientes.Columns[7].Visible = false; //tel decisor
            //dgvClientes.Columns[8].HeaderText = "Pontos";
            //dgvClientes.Columns[8].Width = 50;
            //dgvClientes.Columns[9].HeaderText = "Concorrente";
            //dgvClientes.Columns[9].Width = 70;
            //dgvClientes.Columns[10].Visible = false; //email
            //dgvClientes.Columns[11].HeaderText = "Indicação";
            //dgvClientes.Columns[11].Width = 70;
            //dgvClientes.Columns[12].HeaderText = "Ramo de Atuação";
            //dgvClientes.Columns[12].Width = 70;
            //dgvClientes.Columns[13].Visible = false;
            //dgvClientes.Columns[14].HeaderText = "Data de Cadastro";
            //dgvClientes.Columns[14].Width = 70;
            //dgvClientes.Columns[15].Visible = false;
            //dgvClientes.Columns[16].Visible = false;
            //dgvClientes.Columns[17].Visible = false;
            //dgvClientes.Columns[18].Visible = false;

            this.Text = "PDV NET Inteligencia em sistemas - Clientes";
          
        }

        private void bntAlterar_Click(object sender, EventArgs e)
        {
           AlterarClientes();
        }

        private void cntConsultar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.RowCount == 0)
            {
                MessageBox.Show("Selecione algum cliente");
                return;
            }

            ConsultarClientes();
        }

        private void bntInativar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em fase de desenvolvimento");
        }
    }
}
