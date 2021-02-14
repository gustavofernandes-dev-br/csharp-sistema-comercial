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

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        string filepath;
        string linha;
        string stringSQL;
        
        public Login()
        {
            InitializeComponent();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

            this.pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.Image = Image.FromFile("c:\\COMERCIAL\\imagem\\logo_uso_geral.jpg");
            
            
            if (System.IO.File.Exists("c:\\comercial\\imagem\\iconelogin.ico"))
            {
                Icon icon = Icon.ExtractAssociatedIcon("c:\\comercial\\imagem\\iconelogin.ico");
                this.Icon = icon;
            }

            this.Text = "PDV NET-Comercial";
            this.pbLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogin.Image = Image.FromFile("c:\\comercial\\imagem\\login.jpg");
            //pb .Image = Image.FromFile("C:\UmaImagem.bmp");

            txtUsuario.Focus();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.MaxLength > 1)
            {
                bntLogin.Enabled = true;
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {

                bntLogin.Focus();
            }
        }

        private bool Logado = false; 
        
        public bool verificaLogin()
        {
            bool result;
            //cria uma linha pra receber os dados do arquivo Base.int
            List<string> dados = new List<string>();
            filepath = "c:\\comercial\\base\\base.int";
            //declara uma variável para receber linha por linha do doc
            //verifica se existe um doc com o nome passado ates de fazer a leitura
            if (File.Exists(filepath))
            {
                //usa uma biblioteca chamada StreamReader para fazer a leitura do arquivo baseado no caminho informado
                using (StreamReader reader = new StreamReader(filepath))
                {
                    //cria um loop para adicionar linha por linha do doc até sua ultima linha
                    while ((linha = reader.ReadLine()) != null)
                    {
                        //adiciona linha a linha a nossa lista de dados
                        dados.Add(linha);
                    }
                }
                string host = dados[1].ToString();
                string baseDados = dados[2].ToString();
                string usuario = dados[3].ToString();
                string senha = dados[4].ToString();

                host = host.Replace("02=", "");
                baseDados = baseDados.Replace("03=", "");
                usuario = usuario.Replace("04=", "");
                senha = senha.Replace("05=", "");
                stringSQL = "Data Source=" + host + ";" + "Initial Catalog=" + baseDados + ";" + "User id=" + usuario + ";" + "Password=" + senha + ";";
                
                try
                {
                    result = true;
                    usuario = "select * from login where rtrim(ltrim(login_usuario)) = '" + txtUsuario.Text + "' and rtrim(ltrim(login_senha)) = '" + txtSenha.Text + "'";
                    //MessageBox.Show(usuario);
                    //Cria conexao e verifica login
                    SqlConnection SQLConnection = new SqlConnection();
                    SQLConnection.ConnectionString = stringSQL;
                    //leitura dos dados
                    SqlCommand cmd = new SqlCommand(usuario, SQLConnection);
                    SQLConnection.Open();
                    DataTable resultado = new DataTable();
                    resultado.Load(cmd.ExecuteReader());
                    SqlDataReader resuldado = cmd.ExecuteReader();
                            if (resultado.Rows.Count != 1)
                            {
                                result = false;
                            }
                            SQLConnection.Close();


                }
                    catch (SqlException mensagem)
                    {
                        throw new Exception(mensagem.Message);
                    }
                    finally
                    {

                    }



            }
            else
            {
                MessageBox.Show("Verifique o arquivo de conexão com o Banco de Dados");
                result = false;
            }

           return result;

        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
            bool resultado = verificaLogin();

            Logado = resultado;

            if (Logado)
            {
                MessageBox.Show("Seja bem vindo!", "Bemvindo");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto!");
            }
        }


    }
}
