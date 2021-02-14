using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using PasswordTextBoxControl;


namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {

    

        CLASSES.Versao versao = new CLASSES.Versao();
        public Login()
        {
            InitializeComponent();
            this.Text = this.Text + versao.Data();

         


        }

        //#################################

        public bool verificaNomeRepetido()
        {
            bool result;
            try
            {
                result = true;
                string usuario = "select * from usuarios where rtrim(ltrim(us_login)) = '" + txtUsuario.Text + "'";

                ConexaoBanco novaConexao = new ConexaoBanco();
                novaConexao.ConexaoString();
                SqlCommand conn = new SqlCommand();
                conn.Connection = ConexaoBanco.conn;
                conn.CommandText = usuario;
                DataTable resultado = new DataTable();
                resultado.Load(conn.ExecuteReader());
                SqlDataReader resuldado = conn.ExecuteReader();
                if (resultado.Rows.Count != 1)
                {
                    result = false;
                }

            }
            catch (SqlException mensagem)
            {
                throw new Exception(mensagem.Message);
            }
            finally
            {

            }

            ConexaoBanco.conn.Close();
            return result;

        }



        private void LOGIN_Load(object sender, EventArgs e)
        {
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
            txtSenha.CharacterCasing = CharacterCasing.Normal;

            txtUsuario.Focus();
        }

        public void verificaNomeUsuario()
        {
            bool nomerepetido;
            bool resultado = verificaNomeRepetido();
            nomerepetido = resultado;
            if (nomerepetido)
            {
                txtSenha.Focus();
            }
            else
            {
                MessageBox.Show("Usuário inexistente", "Usuário Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Text = string.Empty;
                txtUsuario.Focus();
            }
        }
        //#################################
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                verificaNomeUsuario();
            }
        }

        //#################################

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            
        }
        //#################################

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                EntrarSistema();
            }
        }

        //#################################

        private bool Logado = false;


        //#################################
        public bool verificaLogin()
        {
            bool result;
                 try
                {
                    result = true;
                    string usuario = "select * from usuarios where rtrim(ltrim(us_login)) = '" + txtUsuario.Text + "' and rtrim(ltrim(us_senha)) = '" + txtSenha.Text + "' and us_inativo = '0'";

                    ConexaoBanco novaConexao = new ConexaoBanco();
                    novaConexao.ConexaoString();
                    SqlCommand conn = new SqlCommand();
                    conn.Connection = ConexaoBanco.conn;
                    conn.CommandText = usuario;
                    DataTable resultado = new DataTable();
                    resultado.Load(conn.ExecuteReader());
                    SqlDataReader resuldado = conn.ExecuteReader();
                    if (resultado.Rows.Count != 1)
                    {
                        result = false;
                    }
                    else 
                    {
                        while (resuldado.Read())
                        {
                            UsuariosSistema U = new UsuariosSistema();
                            UsuarioLogado.usuario = U.GetLogin(resuldado.GetString(1), resuldado.GetString(4));
                        }
                    }
                       
                }
                catch (SqlException mensagem)
                {
                    throw new Exception(mensagem.Message);
                }
                finally
                {

                }
            return result;
        }
        //#################################
        public void EntrarSistema()
        {         
            bool resultado = verificaLogin();
            Logado = resultado;
            if (Logado)
            {
                //MessageBox.Show("Seja bem vindo(a)!", "Bem vindo(a)");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!");
            }
        
        }
        

        private void bntLogin_Click(object sender, EventArgs e)
        {
            EntrarSistema();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            verificaNomeUsuario();
        }
    }
}
