using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class formOperadores : Form
    {
        public formOperadores()
        {
            InitializeComponent();
        }

        private void formOperadores_Load(object sender, EventArgs e)
        {
            this.Text = "PDV NET Inteligencia em sistemas - USUÁRIOS";
            if (System.IO.File.Exists("c:\\COMERCIAL\\imagem\\pdvsuite.ico"))
            {
                Icon icon = Icon.ExtractAssociatedIcon("c:\\COMERCIAL\\imagem\\pdvsuite.ico");
                this.Icon = icon;
            }
        }

        private void bntIncluir_Click(object sender, EventArgs e)
        {
            gbxPerfil.Visible = true;
            rbtAdministrador.Checked = true;
            rbtAdministrador.Focus();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                cmbConsultor.Focus();
            }
        }

        private void cmbConsultor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {

                txtUsuario.Focus();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.Text.ToLower();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntLocalizarTodos_Click(object sender, EventArgs e)
        {


            Load_DGV();




        }


        public void Load_DGV()
        {

            string usuario = "select  LOGIN_ID as ID,   LOGIN_CONSULTOR, LOGIN_NOME_FUNCIONARIO as NOME,LOGIN_USUARIO, LOGIN_PERFIL, LOGIN_EMAIL  from login";



            //usando a classe de conexao 
            ConexaoBanco connection = new ConexaoBanco();
            connection.ConexaoString();

            DateTime d1 = DateTime.Now;
            SqlCommand command = new SqlCommand(usuario);

            command.Connection = ConexaoBanco.conn;
                        
            DataTable dt = new DataTable();
            
            //SqlDataReader reader = command.ExecuteReader();
            dt.Load(command.ExecuteReader());

            ConexaoBanco.conn.Close();
            
            dgvUsuarios.DataSource = dt.Rows.Cast<DataRow>().Take(100).CopyToDataTable();
                  
           


        }


    }
}

