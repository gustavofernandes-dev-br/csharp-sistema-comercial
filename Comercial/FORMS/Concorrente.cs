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
    public partial class Concorrente : Form
    {
        public Concorrente()
        {
            InitializeComponent();
        }

        enum Acoes
        {
            incluir, alterar
        }
        private Acoes acao;
        public int codigo;

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
                cmd.CommandText = "UPDATE CLIENTES_CONCORRENTE SET [CON_NOME] = '" + txtNome.Text + "',[CON_ATUALIZACAO] = GETDATE(),[CON_USUARIO] = 1 ,[CON_INATIVO] = " + ativo + " where CON_codigo = '" + txtID.Text + "'";
                cmd.ExecuteNonQuery();
                ConexaoBanco.conn.Close();

                Load_DGV();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        public void incluiContato()
        {

            if (txtNome.Text == "")
            {
                MessageBox.Show("O Nome não pode ficar vazio", "Preencha os campos");
                return;
            }


            bool nomerepetido;
            bool resultado = verificaNomeRepetido();
            nomerepetido = resultado;

            if (nomerepetido)
            {
                MessageBox.Show("Já existe um Registro com esse nome", "Nome repetido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.Focus();
                return;
            }

            if (chkInativo.Checked == true)
            {
                MessageBox.Show("Não é possivel incluir um novo cadastro como inativo", "Erro");
                return;
            }






            ConexaoBanco conexao = new ConexaoBanco();
            ConexaoBanco.conn.Open();

            string id = txtID.Text;
            string nome = txtNome.Text;
            string dataCadasto = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            string inativo = "0";
            string usuario = "1";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConexaoBanco.conn;
            cmd.CommandText = "insert into CLIENTES_CONCORRENTE ([CON_CODIGO],[CON_NOME],[CON_CADASTRO],[CON_ATUALIZACAO] ,[CON_USUARIO] ,[CON_INATIVO]) values (@param1,@param2,@param3,@param4,@param5,@param6)";

            cmd.Parameters.AddWithValue("@param1", id);
            cmd.Parameters.AddWithValue("@param2", nome);
            cmd.Parameters.AddWithValue("@param3", dataCadasto);
            cmd.Parameters.AddWithValue("@param4", dataCadasto);
            cmd.Parameters.AddWithValue("@param5", usuario);
            cmd.Parameters.AddWithValue("@param6", inativo);


            cmd.ExecuteNonQuery();

            ConexaoBanco.conn.Close();
            //muda ação para incluir que é o valor default
            acao = Acoes.incluir;

            //desabilita o botao cancelar
            gbxDadosCadastrais.Enabled = false;

            Load_DGV();

        }

        private void excluiRegistro()
        {
            if (acao == Acoes.incluir)
            {
                MessageBox.Show("Durante a inclusao de um Registro, não é possível usar o botão \"Inativar\" ", "Não é possivel Inativar");
                return;
            }


            int index;
            if (dgvRegistros.Rows[0].Cells[0].Value != null)
            {

                index = dgvRegistros.CurrentRow.Index;

                if ((MessageBox.Show("Tem certeza que deseja inativar o registro " + txtNome.Text.Trim() + " ?", "Tem Certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.No)
                {
                    return;
                }

            }
            else
            {

            }



            ConexaoBanco conexao2 = new ConexaoBanco();
            conexao2.ConexaoString();
            try
            {
                index = dgvRegistros.CurrentRow.Index;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ConexaoBanco.conn;
                cmd.CommandText = "UPDATE CLIENTES_CONCORRENTE SET [CON_INATIVO] = '1' where CON_CODIGO =  " + txtID.Text + "";

                cmd.ExecuteNonQuery();
                ConexaoBanco.conn.Close();

                Load_DGV();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        public void Load_DGV()
        {
            //volta para acao incluir
            acao = Acoes.incluir;

            //desabilita o botao cancelar
            bntCancelar.Enabled = false;
            bntSalvar.Enabled = false;
            gbxDadosCadastrais.Enabled = false;
            txtNome.Enabled = false;

            string usuarios = "SELECT [CON_CODIGO],[CON_NOME],[CON_CADASTRO],[CON_ATUALIZACAO],[CON_USUARIO],replace(replace([CON_INATIVO] ,'1','Inativo'),'0','Ativo') as CON_INATIVO  FROM [dbo].[CLIENTES_CONCORRENTE]  where CON_INATIVO = '0'";

            //usando a classe de conexao 
            ConexaoBanco conexao = new ConexaoBanco();
            conexao.ConexaoString();

            int i = 0;
            SqlCommand cmd = new SqlCommand(usuarios, ConexaoBanco.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt != null && dt.Rows.Count > 0)
            {
                if (dgvRegistros.Rows.Count > 0)
                { dgvRegistros.Rows.Clear(); }
                dgvRegistros.Rows.Add(dt.Rows.Count);
                foreach (DataRow rw in dt.Rows)
                {
                    dgvRegistros.Rows[i].Cells[0].Value = rw["CON_CODIGO"].ToString();
                    dgvRegistros.Rows[i].Cells[1].Value = rw["CON_NOME"].ToString();
                    dgvRegistros.Rows[i].Cells[2].Value = rw["CON_CADASTRO"].ToString();
                    dgvRegistros.Rows[i].Cells[3].Value = rw["CON_ATUALIZACAO"].ToString();
                    dgvRegistros.Rows[i].Cells[4].Value = rw["CON_USUARIO"].ToString();
                    dgvRegistros.Rows[i].Cells[5].Value = rw["CON_INATIVO"].ToString();


                    i = i + 1;
                }
            }

            ConexaoBanco.conn.Close();

            limpaCampos();

        }


        public bool verificaNomeRepetido()
        {
            bool result;
            try
            {
                result = true;
                string usuario = "select * from CLIENTES_CONCORRENTE where rtrim(ltrim(CON_nome)) = '" + txtNome.Text + "'";

                ConexaoBanco novaConexao = new ConexaoBanco();
                novaConexao.ConexaoString();
                SqlCommand conn = new SqlCommand();
                conn.Connection = ConexaoBanco.conn;
                conn.CommandText = usuario;
                DataTable resultado = new DataTable();
                resultado.Load(conn.ExecuteReader());
                SqlDataReader resuldado = conn.ExecuteReader();
                if (resultado.Rows.Count == 0)
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





        public int idUsuario()
        {
            ConexaoBanco conexao2 = new ConexaoBanco();
            conexao2.ConexaoString();
            try
            {

                SqlCommand sql = new SqlCommand("Select resultado = CASE WHEN MAX(CON_CODIGO) is null then '1' else MAX(CON_CODIGO) + 1 end From CLIENTES_CONCORRENTE", ConexaoBanco.conn);
                               
                codigo = Convert.ToInt32(sql.ExecuteScalar());

                ConexaoBanco.conn.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return codigo;

        }

        public void limpaCampos()
        {
            txtID.Text = string.Empty;
            txtNome.Text = string.Empty;
            chkInativo.Checked = false;
        }


        private void bntSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (acao == Acoes.incluir)
                { incluiContato(); }
                else
                { alteraContato(); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void bntInativar_Click_1(object sender, EventArgs e)
        {
            excluiRegistro();
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

        private void bntPesquisar_Click(object sender, EventArgs e)
        {
            if (dgvRegistros.Rows.Count > 0)
            { dgvRegistros.Rows.Clear(); }

            //volta para acao incluir
            acao = Acoes.incluir;

            //desabilita o botao cancelar
            txtNome.Enabled = false;
            bntCancelar.Enabled = false;
            bntSalvar.Enabled = false;
            bntInativar.Enabled = false;
            gbxDadosCadastrais.Enabled = false;


            //define ativo e inativo
            string ativo;

            if (chkPesqInativo.Checked == true)
            { ativo = "'1'"; }
            else
            { ativo = "'0'"; }


            string pesquisarRegistro;
            if (txtNomePesquisar.Text.Length > 0 && chkQualquerParte.Checked == true)
            { pesquisarRegistro = " and CON_nome like '%" + txtNomePesquisar.Text + "%'"; }
            else if (txtNomePesquisar.Text.Length > 0)
            { pesquisarRegistro = " and CON_nome like '" + txtNomePesquisar.Text + "%'"; }
            else
            { pesquisarRegistro = " "; }

            string usuarios = "SELECT [CON_CODIGO],[CON_NOME],[CON_CADASTRO],[CON_ATUALIZACAO],[CON_USUARIO], replace(replace([CON_INATIVO],'1','Inativo'),'0','Ativo') AS CON_INATIVO FROM [dbo].[CLIENTES_CONCORRENTE]  where CON_inativo = " + ativo + pesquisarRegistro + "  ";

            //MessageBox.Show(usuarios);

            //usando a classe de conexao 
            ConexaoBanco conexao = new ConexaoBanco();
            conexao.ConexaoString();

            int i = 0;
            SqlCommand cmd = new SqlCommand(usuarios, ConexaoBanco.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt != null && dt.Rows.Count > 0)
            {
                if (dgvRegistros.Rows.Count > 0)
                { dgvRegistros.Rows.Clear(); }
                dgvRegistros.Rows.Add(dt.Rows.Count);
                foreach (DataRow rw in dt.Rows)
                {
                    dgvRegistros.Rows[i].Cells[0].Value = rw["CON_CODIGO"].ToString();
                    dgvRegistros.Rows[i].Cells[1].Value = rw["CON_NOME"].ToString();
                    dgvRegistros.Rows[i].Cells[2].Value = rw["CON_CADASTRO"].ToString();
                    dgvRegistros.Rows[i].Cells[3].Value = rw["CON_ATUALIZACAO"].ToString();
                    dgvRegistros.Rows[i].Cells[4].Value = rw["CON_USUARIO"].ToString();
                    dgvRegistros.Rows[i].Cells[5].Value = rw["CON_INATIVO"].ToString();

                    i = i + 1;
                }
            }

            ConexaoBanco.conn.Close();

            limpaCampos();
        }

        private void dgvRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Enabled = true;
            chkInativo.Enabled = true;
            gbxDadosCadastrais.Enabled = true;
            bntSalvar.Enabled = true;
            bntCancelar.Enabled = true;
            bntInativar.Enabled = true;
            chkPesqInativo.Checked = false;
            txtNomePesquisar.Text = string.Empty;


            //pegamos a linha selecionada no grid por meio de paCON_etro e 
            //Se o usuario clicou na linha entao o rowIndex será > ou igual a 0
            if (e.RowIndex >= 0)
            {
                txtID.Text = dgvRegistros.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNome.Text = dgvRegistros.Rows[e.RowIndex].Cells[1].Value.ToString();


                if (dgvRegistros.Rows[e.RowIndex].Cells[5].Value.ToString() == "Inativo")
                {
                    chkInativo.Checked = true;
                }
                else
                {
                    chkInativo.Checked = false;
                }

            }

            //define a acao
            acao = Acoes.alterar;

            txtNome.Focus();
        }

        private void bntLimparPesquisa_Click(object sender, EventArgs e)
        {
            txtNomePesquisar.Text = string.Empty;
            chkPesqInativo.Checked = false;
            chkQualquerParte.Checked = false;
        }

        private void bntCancelar_Click_1(object sender, EventArgs e)
        {
            gbxDadosCadastrais.Enabled = false;
            txtNome.Enabled = false;
            bntCancelar.Enabled = false;
            bntInativar.Enabled = false;
            bntSalvar.Enabled = false;
            txtID.Text = string.Empty;
            txtNome.Text = string.Empty;
        }

        private void Concorrente_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            txtNome.Enabled = false;
            gbxDadosCadastrais.Enabled = false;
            bntCancelar.Enabled = false;
            bntInativar.Enabled = false;
            bntSalvar.Enabled = false;
            limpaCampos();
            txtNome.CharacterCasing = CharacterCasing.Upper;

        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntIncluir_Click_1(object sender, EventArgs e)
        {
            gbxDadosCadastrais.Enabled = true;
            bntCancelar.Enabled = true;
            bntInativar.Enabled = true;
            bntSalvar.Enabled = true;
            txtNome.Enabled = true;
            acao = Acoes.incluir;
            limpaCampos();
            txtNome.Focus();
            idUsuario();
            txtID.Text = codigo.ToString();
        }
    }
}
