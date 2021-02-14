using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace WindowsFormsApplication1
{
    public partial class formOperadores : Form
    {
       SqlExec sql = new SqlExec();
       Grid grid = new Grid();
       Combo combo = new Combo(); 
        public formOperadores()
        {
            InitializeComponent();
        }
        
        //VARIAVEIS PUBLICAS
        //#########################################################################################
        //#########################################################################################
        //lista enumerada de acoes
        
        
        //String que armazenará as mensagens de erro
        private string msg;
        //Armazenará o valor inteiro da coluna ID
        private int primaryKey;
        //enum que armazenará a ação escolhida
        private Acoes acao;
        public int id_usuario;


        //METODOS
        //#########################################################################################
        //#########################################################################################


        //METODO 1
        enum Acoes
        {
            incluir, alterar
        }



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

        //METODO 2
        private void formOperadores_Load(object sender, EventArgs e)
        {           
            this.Text = "PDV NET Inteligencia em sistemas - USUÁRIOS";
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
            txtEmail.CharacterCasing = CharacterCasing.Lower;
            txtSenha.CharacterCasing = CharacterCasing.Normal;
            txtNomePesquisar.CharacterCasing = CharacterCasing.Upper;
            txtUsuarioPesquisar.CharacterCasing = CharacterCasing.Upper;
        }

        private void bntIncluir_Click(object sender, EventArgs e)
        {
          
            txtNome.Enabled = true;
            txtUsuario.Enabled = true;
            acao = Acoes.incluir;
            this.limpaCampos();
            gbxPerfil.Visible = true;
            gbxPerfil.Enabled = true;
            rbtAdministrador.Checked = true;
            bntSalvar.Enabled = true;
            bntCancelar.Enabled = true;
            txtNome.Focus();
            idUsuario();
            txtID.Text = codigo.ToString();

        }




        //METODO 3 proxima ID
        public int codigo;
        public int idUsuario()
        {
            ConexaoBanco conexao2 = new ConexaoBanco();
            conexao2.ConexaoString();
            try
            {
                SqlCommand sql = new SqlCommand("Select MAX(us_id) + 1 From usuarios", ConexaoBanco.conn);
                codigo = Convert.ToInt32(sql.ExecuteScalar());
                ConexaoBanco.conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return codigo;
        }
        //METODO 4
        public void Load_DGV()
        {
            //volta para acao incluir
            acao = Acoes.incluir;
            //desabilita o botao cancelar
            bntCancelar.Enabled = false;
            bntSalvar.Enabled = false;
            gbxPerfil.Enabled = false;

            string usuarios = "SELECT US_ID , US_NOME,  US_EMAIL, US_LOGIN, REPLACE(REPLACE(REPLACE( US_PERFIL, '1','Master'), '2','Administrativo'), '3','Consultor') as US_PERFIL, US_CADASTRO, us_senha, us_inativo from USUARIOS  where us_inativo = '0'";

            Grid grid = new Grid();
            grid.GridPopularDataSource(dgvUsuarios , usuarios);

            limpaCampos();
            ////usando a classe de conexao 
            //ConexaoBanco conexao = new ConexaoBanco();
            //conexao.ConexaoString();

            //int i = 0;
            //SqlCommand cmd = new SqlCommand(usuarios, ConexaoBanco.conn);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //if (dt != null && dt.Rows.Count > 0)
            //{
            //    if (dgvUsuarios.Rows.Count > 0)
            //    { dgvUsuarios.Rows.Clear(); }
            //    dgvUsuarios.Rows.Add(dt.Rows.Count);
            //    foreach (DataRow rw in dt.Rows)
            //    {
            //        dgvUsuarios.Rows[i].Cells[0].Value = rw["US_ID"].ToString();
            //        dgvUsuarios.Rows[i].Cells[1].Value = rw["US_NOME"].ToString();
            //        dgvUsuarios.Rows[i].Cells[2].Value = rw["US_EMAIL"].ToString();
            //        dgvUsuarios.Rows[i].Cells[3].Value = rw["US_LOGIN"].ToString();
            //        dgvUsuarios.Rows[i].Cells[4].Value = rw["US_PERFIL"].ToString();
            //        dgvUsuarios.Rows[i].Cells[5].Value = rw["US_CADASTRO"].ToString();
            //        dgvUsuarios.Rows[i].Cells[6].Value = rw["US_SENHA"].ToString();
            //        dgvUsuarios.Rows[i].Cells[7].Value = rw["US_inativo"].ToString();

            //        i = i + 1;
            //    }
            //}

            //ConexaoBanco.conn.Close();
        }

        //METODO 5
        public string verificaTipoFuncionario()
        {
            string perfilFuncionario;
            if (rbtAdministrador.Checked == true)
            {
                perfilFuncionario = "1";
            }
            else if (rbtAuxiliarAdm.Checked == true)
            {
                perfilFuncionario = "2";
            }
            else
            {
                perfilFuncionario = "3";
            }
            return perfilFuncionario;
        }


        //METODO 6
        public void incluiContato()
        {
            if (verificaCamposPreenchidos() != "")
            {
                MessageBox.Show("Necessário preenchimento do(s) campo(s): \n\n" + this.msg, "Preencha os campos");
                return;
            }

            string query = "select us_login from usuarios where rtrim(ltrim(us_login)) = '" + txtUsuario.Text.Trim() + "'";


            //bool nomerepetido;
            //bool resultado = verificaNomeRepetido();
            //nomerepetido = resultado;

            if (sql.verificaRepetido(query))
            {
                MessageBox.Show("Já existe um usuário com esse nome", "Nome repetido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Focus();
                return;
            }


            if (IsEmail(txtEmail.Text) == false)
            {
                MessageBox.Show("Verifique o formato do E-mail","E-mail Invalido");
            }
            else
            {
                if (chkInativo.Checked == true)
                {
                    MessageBox.Show("Não é possivel incluir um novo cadastro como inativo", "Erro");
                    return;
                }
                ConexaoBanco conexao = new ConexaoBanco();
                ConexaoBanco.conn.Open();

                string id = txtID.Text;
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                string usuario = txtUsuario.Text;
                string senha = txtSenha.Text;
                string dataCadasto = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                string perfil = verificaTipoFuncionario();
                string inativo = "0";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ConexaoBanco.conn;
                cmd.CommandText = "INSERT INTO usuarios(us_id, us_nome, us_email, us_login , us_senha, us_perfil, us_cadastro,us_inativo)   VALUES (@param1,@param2,@param3,@param4,@param5,@param6,@param7, @param8)";

                cmd.Parameters.AddWithValue("@param1", id);
                cmd.Parameters.AddWithValue("@param2", nome);
                cmd.Parameters.AddWithValue("@param3", email);
                cmd.Parameters.AddWithValue("@param4", usuario);
                cmd.Parameters.AddWithValue("@param5", senha);
                cmd.Parameters.AddWithValue("@param6", perfil);
                cmd.Parameters.AddWithValue("@param7", dataCadasto);
                cmd.Parameters.AddWithValue("@param8", inativo);

                cmd.ExecuteNonQuery();

                ConexaoBanco.conn.Close();
                //muda ação para incluir que é o valor default
                acao = Acoes.incluir;

                //desabilita o botao cancelar
                gbxPerfil.Enabled = false;



                Load_DGV();
            }
        }



        //METODO 7
        public void alteraContato()
        {
            string ativo;
            if (chkInativo.Checked == true)
            {
                ativo = "1";
            }
            else
            {
                ativo = "0";
            }

            ConexaoBanco conexao2 = new ConexaoBanco();
            conexao2.ConexaoString();
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ConexaoBanco.conn;
                cmd.CommandText = "update usuarios set us_inativo = '" + ativo + "' , us_login = '"+txtUsuario.Text+"', us_nome = '"+ txtNome.Text+"' , us_email = '" + txtEmail.Text + "' , us_senha = '" + txtSenha.Text + "' , us_perfil = '" + verificaTipoFuncionario() + "' where us_id = " + txtID.Text + "";

                cmd.ExecuteNonQuery();
                ConexaoBanco.conn.Close();

                Load_DGV();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        //METODO 8
        private void limpaCamposPreechidos()
        {
            foreach (object ctrl in gbxPerfil.Text)
            {
                if (ctrl is TextBox)
                {
                    TextBox txt = (TextBox)ctrl;
                    txt.Text = string.Empty;
                }
                else if (ctrl is ComboBox)
                {
                    ComboBox cmb = (ComboBox)ctrl;
                    cmb.Text = string.Empty;
                }
                else if (ctrl is MaskedTextBox)
                {
                    MaskedTextBox msk = (MaskedTextBox)ctrl;
                    msk.Text = string.Empty;
                }
            }
        }

        //METODO 9
        private string verificaCamposPreenchidos()
        {
            this.msg = string.Empty;


            foreach (object item in gbxPerfil.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    if (txt.Text == string.Empty)
                    {
                        msg += txt.AccessibleDescription + "\n";
                    }
                }
            }


            foreach (object item in gbxPerfil.Controls)
            {
                if (item is ComboBox)
                {
                    ComboBox cmb = (ComboBox)item;
                    if (cmb.SelectedIndex < 0)
                    {
                        msg += cmb.AccessibleDescription + "\n";
                    }
                }
            }

            return msg;

        }

        //METODO 10
        public void limpaCampos()
        {
            foreach (object control in gbxPerfil.Controls)
            {

                if (control is TextBox)
                {
                    TextBox txt = (TextBox)control;
                    txt.Text = string.Empty;
                }

                if (control is ComboBox)
                {
                    ComboBox txt = (ComboBox)control;
                    txt.Text = string.Empty;
                }
            }

        }

        //METODO 11
        private void excluiUsuario()
        {
            if (acao == Acoes.incluir)
            {
                MessageBox.Show("Durante a inclusao de um Registro, não é possível usar o botão \"Inativar\" ", "Não é possivel Inativar");
                return;
            }
            

            int index;
            if (dgvUsuarios.Rows[0].Cells[0].Value != null)
            {

                index = dgvUsuarios.CurrentRow.Index;

                if ((MessageBox.Show("Tem certeza que deseja inativar o funcionário " + txtNome.Text.Trim() + " ?", "Tem Certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.No)
                {
                    return;
                }

            }
            else
            { 
            
            }



            //ConexaoBanco conexao2 = new ConexaoBanco();
            //conexao2.ConexaoString();
            try
            {
                string query = "update usuarios set us_inativo = '1' where us_id = " + txtID.Text + " ";

                sql.SqlExecuta(query);
                
                //index = dgvUsuarios.CurrentRow.Index;
                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = ConexaoBanco.conn;
                //cmd.CommandText = "update usuarios set us_inativo = '1' where us_id = " + txtID.Text + "";

                //cmd.ExecuteNonQuery();
                //ConexaoBanco.conn.Close();

                Load_DGV();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //metodo 12
        public static bool IsEmail(string strEmail)
        {
            string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(strEmail, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                txtEmail.Focus();
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
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                bntSalvar.Focus();
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.Text.ToLower();
        }
        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //se acao for incluir
                if (acao == Acoes.incluir)
                {
                    //salva os dados
                    incluiContato();
                }
                else
                {
                    alteraContato();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }
   
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            bntIncluir.Enabled = true;
            //limpa campos
            this.limpaCampos();

            //volta para acao incluir
            acao = Acoes.incluir;

            //desabilita o botao cancelar
            bntCancelar.Enabled = false;
            bntSalvar.Enabled = false;
            gbxPerfil.Enabled = false;
        }

        private void dgvUsuarios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                grid.GridRemoveNulos(dgvUsuarios, e.RowIndex);
                gbxPerfil.Enabled = false;
                bntSalvar.Enabled = false;
                bntCancelar.Enabled = false;
                if (e.RowIndex >= 0)
                {
                    grid.GridRemoveNulos(dgvUsuarios, e.RowIndex);
                    txtID.Text = dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtNome.Text = dgvUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtEmail.Text = dgvUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtUsuario.Text = dgvUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtSenha.Text = dgvUsuarios.Rows[e.RowIndex].Cells[6].Value.ToString();
                    if (dgvUsuarios.Rows[e.RowIndex].Cells[7].Value.ToString() == "1")
                    {
                        chkInativo.Checked = true;
                    }
                    else
                    {
                        chkInativo.Checked = false;
                    }

                    if (dgvUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString().Trim() == "Master")
                    {
                        rbtAdministrador.Checked = true;
                    }
                    else if (dgvUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString().Trim() == "Administrativo")
                    {
                        rbtAuxiliarAdm.Checked = true;
                    }
                    else
                    {
                        rbtConsultor.Checked = true;
                    }
                    //habilita o botao cancelar
                    bntCancelar.Enabled = true;
                    //define a acao
                    acao = Acoes.alterar;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gbxPerfil.Enabled = true;
            bntSalvar.Enabled = true;
            bntCancelar.Enabled = true;
            if (e.RowIndex <= 0)
            {
                return;
            }
            int sRow = e.RowIndex;

                grid.GridRemoveNulos(dgvUsuarios, sRow);   
                txtID.Text = dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                primaryKey = int.Parse(dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                txtNome.Text = dgvUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                txtEmail.Text = dgvUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                txtUsuario.Text = dgvUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
                txtSenha.Text = dgvUsuarios.Rows[e.RowIndex].Cells[6].Value.ToString().Trim(); 

                if (dgvUsuarios.Rows[e.RowIndex].Cells[7].Value.ToString().Trim() == "1")
                {
                    chkInativo.Checked = true;
                }
                else
                {
                    chkInativo.Checked = false;
                }
               
                if (dgvUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString().Trim() == "Master")
                {
                    rbtAdministrador.Checked = true;
                }
                else if (dgvUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString().Trim() == "Administrativo")
                {
                    rbtAuxiliarAdm.Checked = true;
                }
                else 
                {
                    rbtConsultor.Checked = true;
                }
                //habilita o botao cancelar
                bntCancelar.Enabled = true;
                //define a acao
                acao = Acoes.alterar;
                txtNome.Focus();
        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            excluiUsuario();
        }

        private void bntLimparPesquisa_Click(object sender, EventArgs e)
        {
            txtNomePesquisar.Text = string.Empty;
            txtUsuarioPesquisar.Text = string.Empty;
            chkPesqInativos.Checked = false;
            chkQualquerParte.Checked = false;
        }

        private void txtNomePesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtNomePesquisar.Text.Length > 0)
            {
                chkQualquerParte.Visible = true;

            }
            else
            {
                chkQualquerParte.Visible = false;
                chkQualquerParte.Checked = false;
            }
        }

        //private void bntPesquisar_Click(object sender, EventArgs e)
        //{
           
                          
        //    //volta para acao incluir
        //    acao = Acoes.incluir;

        //    //desabilita o botao cancelar
        //    bntCancelar.Enabled = false;
        //    bntSalvar.Enabled = false;
        //    gbxPerfil.Enabled = false;


            

        //    //define ativo e inativo
        //    string ativo;
        //    if (chkPesqInativos.Checked == true) 
        //    { ativo = "'1'"; } 
        //    else 
        //    { ativo = "'0'"; }

        //    string txtusuariopesquisar;
        //    if (txtUsuarioPesquisar.Text.Length > 0)
        //    { txtusuariopesquisar = " and us_nome like '" + txtUsuarioPesquisar.Text + "%'"; }
        //    else
        //    { txtusuariopesquisar = " "; }


        //    string nomefuncionario;
        //    if (txtNomePesquisar.Text.Length > 0 && chkQualquerParte.Checked == true)
        //    { nomefuncionario = " and us_nome like '%" + txtNomePesquisar.Text + "%'"; }
        //    else if (txtNomePesquisar.Text.Length > 0)
        //    { nomefuncionario = " and us_nome like '" + txtNomePesquisar.Text + "%'";  }
        //    else
        //    { nomefuncionario = " ";  }
            


        //    string usuarios = "SELECT US_ID , US_NOME,  US_EMAIL, US_LOGIN, REPLACE(REPLACE(REPLACE( US_PERFIL, '1','Master'), '2','Administrativo'), '3','Consultor') as US_PERFIL, US_CADASTRO, us_senha, us_inativo from USUARIOS  where us_inativo = " + ativo + txtusuariopesquisar + nomefuncionario+"  ";


        //    dgvUsuarios.DataSource = null;
        //    //MessageBox.Show(usuarios);


        //    //usando a classe de conexao 
        //    ConexaoBanco conexao = new ConexaoBanco();
        //    conexao.ConexaoString();

        //    int i = 0;
        //    SqlCommand cmd = new SqlCommand(usuarios, ConexaoBanco.conn);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    if (dt != null && dt.Rows.Count > 0)
        //    {
        //        if (dgvUsuarios.Rows.Count > 0)
        //        { dgvUsuarios.Rows.Clear(); }
        //        dgvUsuarios.Rows.Add(dt.Rows.Count);
        //        foreach (DataRow rw in dt.Rows)
        //        {
        //            dgvUsuarios.Rows[i].Cells[0].Value = rw["US_ID"].ToString();
        //            dgvUsuarios.Rows[i].Cells[1].Value = rw["US_NOME"].ToString();
        //            dgvUsuarios.Rows[i].Cells[2].Value = rw["US_EMAIL"].ToString();
        //            dgvUsuarios.Rows[i].Cells[3].Value = rw["US_LOGIN"].ToString();
        //            dgvUsuarios.Rows[i].Cells[4].Value = rw["US_PERFIL"].ToString();
        //            dgvUsuarios.Rows[i].Cells[5].Value = rw["US_CADASTRO"].ToString();
        //            dgvUsuarios.Rows[i].Cells[6].Value = rw["US_SENHA"].ToString();
        //            dgvUsuarios.Rows[i].Cells[7].Value = rw["US_inativo"].ToString();

        //            i = i + 1;
        //        }
        //    }

        //    ConexaoBanco.conn.Close();

        //    limpaCampos();
        //}
        private void btnPesquisar2_Click(object sender, EventArgs e)
        {
            acao = Acoes.incluir;

            //desabilita o botao cancelar
            bntCancelar.Enabled = false;
            bntSalvar.Enabled = false;
            gbxPerfil.Enabled = false;
            
            //define ativo e inativo
            string ativo;
            if (chkPesqInativos.Checked == true)
            { ativo = "'1'"; }
            else
            { ativo = "'0'"; }

            string txtusuariopesquisar;
            if (txtUsuarioPesquisar.Text.Length > 0)
            { txtusuariopesquisar = " and us_nome like '" + txtUsuarioPesquisar.Text + "%'"; }
            else
            { txtusuariopesquisar = " "; }

            string nomefuncionario;
            if (txtNomePesquisar.Text.Length > 0 && chkQualquerParte.Checked == true)
            { nomefuncionario = " and us_nome like '%" + txtNomePesquisar.Text + "%'"; }
            else if (txtNomePesquisar.Text.Length > 0)
            { nomefuncionario = " and us_nome like '" + txtNomePesquisar.Text + "%'"; }
            else
            { nomefuncionario = " "; }
            string usuarios = "SELECT US_ID , US_NOME,  US_EMAIL, US_LOGIN, REPLACE(REPLACE(REPLACE( US_PERFIL, '1','Master'), '2','Administrativo'), '3','Consultor') as US_PERFIL, US_CADASTRO, us_senha, us_inativo from USUARIOS  where us_inativo = " + ativo + txtusuariopesquisar + nomefuncionario + "  ";

            this.Cursor = Cursors.WaitCursor;
            grid.GridPopularDataSource(dgvUsuarios, usuarios);
            this.Cursor = Cursors.Default;
        }
    }
}

