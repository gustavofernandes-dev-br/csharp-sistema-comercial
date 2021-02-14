using System;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CadastroClientes : Form
    {
        enum status
        { 
            incluir,
            alterar,
            consultar        
        }

        enum EmProspeccao
        { 
            sim,
            nao
        }

        

        string msg;
        int inclui_Ou_Altera = 0;
        
        int statusProspect = 0;

        Combo combo = new Combo();
        //comparar alteraçoes
        Clientes AuditAntes = new Clientes();
        Clientes AuditDepois = new Clientes();

        //  ArrayList antes = new ArrayList();
        // ArrayList depois = new ArrayList();
        Concorrentes concorrentes = new Concorrentes();
        Endereco endereco = new Endereco();
        ObsCli observacaocliente = new ObsCli();
        Clientes cli = new Clientes();

       
        //construtor do Form
        public CadastroClientes()
        {
            //construtor do Form
            InitializeComponent();
           // dtpCadastro.Value = DateTime.Now;
           // dtpAtualizacao.Value = DateTime.Now;
           // resetCores();
            ResetMaiusculaseMinusculas();
            ResetComboboxs();
             
            if (UsuarioLogado.usuario.perfil.ToString().Trim() == "3")
            {
                bntAdicionaConcorrente.Enabled = false;
                bntAdicionaIndicacao.Enabled = false;
                bntAdicionaRamoAtuacao.Enabled = false;
            }
           // txtNome.Focus();
        }

         

        public void GetDadosConsultar()
        {
            TranferenciaCliente();     
            observacaocliente.SelectObs(comercial, VariaveisStaticas.codigoclienteStatico);
            inclui_Ou_Altera = 2;
            //bntSalvar.Text = "Consultar";
            this.Text = "Cadastro de clientes - Consulta";
            bntSalvar.Visible = false;
            btnIncluirObs.Visible = false;
        }

        //tranfere o cliente de um combobox pra outro
        public void TranferenciaCliente()
        {
            string idCliente = VariaveisStaticas.codigoclienteStatico.Trim();
            txtId.Text = idCliente;
            // MessageBox.Show(dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString());
            //crias a query sql
            string query = "select CLI_CODIGO, CLI_NOME_FANTASIA, CLI_DDD, CLI_TELEFONE1, CLI_TELEFONE2, CLI_RESPONSAVEL, CLI_TELRESPONSAVEL, CLI_DECISOR, CLI_TELDECISOR, CLI_QTDPONTOS,CLI_EMAILS, CLI_CONCORRENTE, CLI_INDICACAO,  CLI_RAMOATUACAO, CLI_CADASTRO, CLI_ATUALIZACAO,  a.us_nome as usuarioatualiza, CLI_INATIVO ";
            query += " ,END_CEP,END_ENDERECO, END_NUMERO, END_COMPLEMENTO, END_BAIRRO, END_CIDADE, END_UF,  b.us_nome as usuarioacadastro , cli_consultor,CLI_DDD_DESCISOR, CLI_DDD_RESPONSAVEL, FAS_DESCRICAO ";
            query += " from clientes  ";
            query += " left join ENDERECO on CLIENTES.CLI_CODIGO = ENDERECO.END_CODIGO ";
            query += "  inner join usuarios a on  a.US_ID = CLI_USUARIO INNER JOIN FASES ON FAS_CODIGO = CLI_FASE    inner join usuarios b on b.US_ID = CLI_USUARIOCADASTRO  ";
            query += " where cli_codigo = '" + idCliente + "'";

            ConexaoBanco novaConexao = new ConexaoBanco();
            novaConexao.ConexaoString();
            SqlCommand cmd = new SqlCommand(query, ConexaoBanco.conn);
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();

            //usando sqlDataReader para ler os dados do banco de dados

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    txtNome.Text = reader.GetString(1);
                    txtDDD.Text = reader.GetString(2);
                    txtTel1.Text = reader.GetString(3);
                    txtTel2.Text = reader.GetString(4);
                    txtResponsavel.Text = reader.GetString(5);
                    txtTelResponsavel.Text = reader.GetString(6);
                    txtDecisor.Text = reader.GetString(7);
                    txtTelDescisor.Text = reader.GetString(8);
                    numPontos.Value = reader.GetInt16(9);
                    txtEmail.Text = reader.GetString(10);
                    cmbConcorrente.SelectedValue = reader.GetInt16(11);
                    cmbIndicacao.SelectedValue = reader.GetInt16(12);
                    cmbRamoAtuacao.SelectedValue = reader.GetInt16(13);
                    dtpCadastro.Value = reader.GetDateTime(14);
                    dtpAtualizacao.Value = reader.GetDateTime(15);
                    lblUsuario.Text = reader.GetString(16); //usuario que alterou

                    if (reader.GetString(17).Trim() == "0")
                        chkInativo.Checked = false;
                    else
                        chkInativo.Checked = true;

                    txtCep.Text = reader.GetString(18);
                    txtEndereco.Text = reader.GetString(19);
                    txtNumero.Text = reader.GetString(20);
                    txtComplemento.Text = reader.GetString(21);
                    txtBairro.Text = reader.GetString(22);
                    cmbCidade.Text = reader.GetString(23);
                    cmbUf.Text = reader.GetString(24);
                    lblUsuarioCadastro.Text = reader.GetString(25);
                    cmbConsultor.SelectedValue = reader.GetInt16(26);
                    txtDDDDescisor.Text = reader.GetString(27);
                    txtDDDresponsavel.Text = reader.GetString(28);
                    lblFases.Text = reader.GetString(29);
                    }
                }
            }
        
        


        public void GetDadosAlterar()
        {
            TranferenciaCliente();
            inclui_Ou_Altera = 1;
            bntSalvar.Text = "Alterar";
            this.Text = "Cadastro de clientes - Alteração";
            observacaocliente.SelectObs(comercial, VariaveisStaticas.codigoclienteStatico);
            //auditoria de alterações 
            AuditAntes.ClienteAuditleituraCompara(VariaveisStaticas.codigoclienteStatico);
        }


        //ABRE EM STATUS DE INCLUSÃO AO CLICAR EM INCLUIR NO FORM CLIENTE
        public void IncluiDados( )
        {
         txtId.Text = Sistema.GeradoDoc();
         //txtId.Text = DateTime.Now.ToString("yyyyMMddHHmmssfff");
         dtpCadastro.Value = DateTime.Now;
         dtpAtualizacao.Value = DateTime.Now;
         dtpAtualizacao.Visible = false;
         lblUsuario.Visible = false;
         lblalteradopor.Visible = false;
         lblUsuarioCadastro.Text = UsuarioLogado.usuario.nome;
         inclui_Ou_Altera = 0;
         bntSalvar.Text = "Incluir";
         this.Text = "Cadastro de clientes - Inclusão";
         lblFases.Text = "Cadastro";
         btnGerarProspeccao.Visible = false; 
         }

        public void resetCores()
        {
            //Deixa as cores no estado padrão de inclusao
            txtNome.BackColor = Color.White;
            txtDDD.BackColor = Color.White;
            txtTel1.BackColor = Color.White;
            txtTel2.BackColor = Color.White;
            txtTelDescisor.BackColor = Color.White;
            txtTelResponsavel.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
            numPontos.BackColor = Color.White;
            cmbConcorrente.BackColor = Color.White;
            cmbIndicacao.BackColor = Color.White;
            cmbRamoAtuacao.BackColor = Color.White;
            cmbConsultor.BackColor = Color.White;
            msg = "";
        }
        public void ResetMaiusculaseMinusculas()
        {
            //campos maiusculos e minusculoas
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtEmail.CharacterCasing = CharacterCasing.Lower;
            txtObservacao.CharacterCasing = CharacterCasing.Upper;
            txtResponsavel.CharacterCasing = CharacterCasing.Upper;
            txtDecisor.CharacterCasing = CharacterCasing.Upper;
            tabControlClientes.Visible = true;
        }

        UsuariosSistema sistema = new UsuariosSistema();
        public void ResetComboboxs()
        {
            //alimenta combobox
            comercial.CLIENTES_CONCORRENTE.Clear();
            comercial.CLIENTES_INDICACAO.Clear();
            comercial.CLIENTES_RAMOATUACAO.Clear();
            comercial.ENDERECO_ESTADO.Clear();
            comercial.ENDERECO_MUNICIPIO.Clear();
           // comercial.Consultores.Clear();

            this.concorrentes.SelectRamoAtuacao(this.comercial);
            this.concorrentes.SelectIndicacao(this.comercial);
            this.concorrentes.SelectConcorrentes(this.comercial);
            this.endereco.GetUf(this.comercial);
            this.endereco.GetMunicipionovo(this.comercial);

            //deixa os comboboxs vazios para seleciona-los
            cmbConcorrente.SelectedItem = null;
            cmbIndicacao.SelectedItem = null;
            cmbRamoAtuacao.SelectedItem = null;
            cmbUf.SelectedItem = null;
            cmbCidade.SelectedItem = null;
//novo
            combo.ComboConsultores(cmbConsultor);

            string perfil = UsuarioLogado.usuario.perfil.ToString();
            int iduser = UsuarioLogado.usuario.id;

            //if (perfil.Trim() == "1" || perfil.Trim() == "2")
            //{
            //    this.sistema.SelectConsultores(this.comercial);
            //    cmbConsultor.SelectedItem = null;
            //}
            //else
            //{
            //    this.sistema.SelectConsultoresEspecifico(this.comercial, iduser);
            //    cmbConsultor.Enabled = false;
            //    //cmbConsultor.SelectedItem = null;
            //}

        }

        public void resetConcorrentes()
        {
            comercial.CLIENTES_CONCORRENTE.Clear();
            this.concorrentes.SelectConcorrentes(this.comercial);
            cmbConcorrente.SelectedItem = null;
            if (! cmbConcorrente.DroppedDown)
                cmbConcorrente.DroppedDown = true;
        }


        public void resetIndicacao()
        {
            comercial.CLIENTES_INDICACAO.Clear();
            this.concorrentes.SelectIndicacao(this.comercial);
            cmbIndicacao.SelectedItem = null;
            if (!cmbIndicacao.DroppedDown)
                cmbIndicacao.DroppedDown = true;
        }

        public void resetRamoAtuacao()
        {
            comercial.CLIENTES_RAMOATUACAO.Clear();
            this.concorrentes.SelectRamoAtuacao(this.comercial);
            cmbRamoAtuacao.SelectedItem = null;
            if (!cmbRamoAtuacao.DroppedDown)
                cmbRamoAtuacao.DroppedDown = true;
        }

        private void txtObservacao_TextChanged(object sender, EventArgs e)
        {
            
        }

                
        private void bntAdicionaConcorrente_Click(object sender, EventArgs e)
        {
            Concorrente concorrente = new Concorrente();
            concorrente.ShowDialog();
            resetConcorrentes();
        }

        private void bntAdicionaIndicacao_Click(object sender, EventArgs e)
        {
            Indicacao indica = new Indicacao();
            indica.ShowDialog();
            resetIndicacao();
        }

        private void bntAdicionaRamoAtuacao_Click(object sender, EventArgs e)
        {
            formRamoAtuacao ramo = new formRamoAtuacao();
            ramo.ShowDialog();
            resetRamoAtuacao();
        }

        public void clienteCodigoNovo()
        {
            
            CadastroClientes cadastro = new CadastroClientes();
            txtId.Text = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            txtNome.Focus();
        }

        public void limpaCampos()
        {
            txtNome.Text = string.Empty;
            txtDDD.Text = string.Empty;
            txtTel1.Text = string.Empty;
            txtTel2.Text = string.Empty;
            txtResponsavel.Text = string.Empty;
            txtTelResponsavel.Text = string.Empty;
            txtDecisor.Text = string.Empty;
            txtTelDescisor.Text = string.Empty;
            numPontos.Value = 0;
            txtEmail.Text = string.Empty;
            cmbConcorrente.ResetText();
            cmbIndicacao.ResetText();
            cmbRamoAtuacao.ResetText();
            cmbUf.SelectedItem = null;            
            txtCep.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtObservacao.Text = string.Empty;
            cmbCidade.SelectedItem = null;
            cmbUf.ResetText();
            cmbCidade.ResetText();
            cmbConsultor.ResetText();
            clienteCodigoNovo();
            
            //foreach (object control in tabControlClientes.Controls)
            //{

            //    if (control is TextBox)
            //    {
            //        TextBox txt = (TextBox)control;
            //        txt.Text = string.Empty;
            //    }

            //    if (control is ComboBox)
            //    {
            //        ComboBox txt = (ComboBox)control;
            //        txt.Text = string.Empty;
            //    }
            //}

        }

        //ErrorProvider erro = new ErrorProvider();
        
        private bool verificaCampos()
        {
            bool ok = true;

            resetCores();
            
            if (txtNome.Text == "" )
            {
            ok = false;
            txtNome.BackColor = Color.Yellow;
            msg += "\nNome";
            }

            if (txtDDD.Text == "")
            {
                ok = false;
                txtDDD.BackColor = Color.Yellow;
                msg += "\nDDD";
            }

            if (txtTel1.Text == "" )
            {
                ok = false;
                txtTel1.BackColor = Color.Yellow;
                msg += "\nTelefone 1 Obrigatório";
            }
            else if(txtTel1.Text.Length < 8)
            {
                ok = false;
                msg += "\nTelefone 1 faltando dígito";
                txtTel1.BackColor = Color.Yellow;
            }

           
            else if (txtTel2.Text.Length < 8 && txtTel2.Text.Length > 0 )
            {
                ok = false;
                msg += "\nTelefone 2 faltando dígito ";
                txtTel2.BackColor = Color.Yellow;
            }


            else if (txtTelResponsavel.Text.Length < 8 && txtTelResponsavel.Text.Length > 0)
            {
                ok = false;
                msg += "\nTelefone do Responsavel faltando dígito";
                txtTelResponsavel.BackColor = Color.Yellow;
            }


            else if (txtTelDescisor.Text.Length < 8 && txtTelDescisor.Text.Length > 8)
            {
                ok = false;
                msg += "\nTelefone do Decisor faltando dígito";
                txtTelDescisor.BackColor = Color.Yellow;
            }

            if (numPontos.Value == 0)
            {
                ok = false;
                msg += "\nQuantidade de pontos";
                numPontos.BackColor = Color.Yellow;
            }

            if (txtEmail.Text == "")
            {
                ok = false;
                msg += "\nEmail ";
                txtEmail.BackColor = Color.Yellow;
            }
            else if (IsEmail(txtEmail.Text) == false)
            {
                ok = false;
                msg += "\nVerifique o formado do Email ";
                txtEmail.BackColor = Color.Yellow;
            }


            if (cmbConcorrente.SelectedItem == null || cmbConcorrente.SelectedIndex == -1)
            {
                cmbConcorrente.BackColor = Color.Yellow;
                msg += "\nConcorrente";
                ok = false;
            }

            if (cmbIndicacao.SelectedItem == null || cmbIndicacao.SelectedIndex == -1)
            {
                cmbIndicacao.BackColor = Color.Yellow;
                msg += "\nIndicação";
                ok = false;
            }

            if (cmbRamoAtuacao.SelectedItem == null || cmbRamoAtuacao.SelectedIndex == -1)
            {
                cmbRamoAtuacao.BackColor = Color.Yellow;
                msg += "\nRamo de Atuação";
                ok = false;
            }


            if (cmbConsultor.SelectedItem == null || cmbConsultor.SelectedIndex == -1)
            {
                cmbConsultor.BackColor = Color.Yellow;
                msg += "\nConsultor";
                ok = false;
            }

            return ok;
        }

        //
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
  
        public String Auditoria()
        {
            string mensagem = "";
                                  
            AuditDepois.ClienteAuditleituraCompara(txtId.Text);
    
            if (AuditAntes.Nome != AuditDepois.Nome)
            {
                mensagem += "   Nome Antes: " + AuditAntes.Nome.Trim() + " - Depois: " + AuditDepois.Nome.Trim() + Environment.NewLine;
            }

            if (AuditAntes.DDD != AuditDepois.DDD)
            {
                mensagem += "   DDD Antes: " + AuditAntes.DDD.Trim() + " - Depois: " + AuditDepois.DDD.Trim() + Environment.NewLine;
            }

            if (AuditAntes.Telefone1 != AuditDepois.Telefone1)
            {
                mensagem += "   Telefone 1 Antes: " + AuditAntes.Telefone1.Trim() + " - Depois: " + AuditDepois.Telefone1.Trim() + Environment.NewLine;
            }

            if (AuditAntes.Telefone2 != AuditDepois.Telefone2)
            {
                mensagem += "   Telefone2 Antes: " + AuditAntes.Telefone2.Trim() + " - Depois: " + AuditDepois.Telefone2.Trim() + Environment.NewLine;
            }

            if (AuditAntes.Responsavel != AuditDepois.Responsavel)
            {
                mensagem += "   Responsavel Antes: " + AuditAntes.Responsavel.Trim() + " - Depois: " + AuditDepois.Responsavel.Trim() + Environment.NewLine;
            }

            if (AuditAntes.TelefoneResponsavel!= AuditDepois.TelefoneResponsavel)
            {
                mensagem += "   Tel Responsavel Antes: " + AuditAntes.TelefoneResponsavel.Trim() +
                    " - Depois: " + AuditDepois.TelefoneResponsavel.Trim() + Environment.NewLine;
            }

            if (AuditAntes.Decisor != AuditDepois.Decisor )
            {
                mensagem += "   Decisor Antes: " + AuditAntes.Decisor.Trim() +
                    " - Depois: " + AuditDepois.Decisor.Trim() + Environment.NewLine;
            }

            if (AuditAntes.TelefoneDecisor != AuditDepois.TelefoneDecisor)
            {
                mensagem += "   Telefone Decisor Antes: " + AuditAntes.TelefoneDecisor.Trim() +
                    " - Depois: " + AuditDepois.TelefoneDecisor.Trim() + Environment.NewLine;
            }

            if (AuditAntes.Pontos != AuditDepois.Pontos)
            {
                mensagem += "   Pontos Antes: " + AuditAntes.Pontos +
                    " - Depois: " + AuditDepois.Pontos + Environment.NewLine;
            }


            if (AuditAntes.E_mail!= AuditDepois.E_mail)
            {
                mensagem += "   Email Antes: " + AuditAntes.E_mail.Trim() +
                    " - Depois: " + AuditDepois.E_mail.Trim() + Environment.NewLine;
            }

            if (AuditAntes.audit_concorrente != AuditDepois.audit_concorrente)
            {
                mensagem += "   Concorrente Antes: " + AuditAntes.audit_concorrente.Trim() +
                    " - Depois: " + AuditDepois.audit_concorrente.Trim() + Environment.NewLine;
            }

            if (AuditAntes.audit_indicacao != AuditDepois.audit_indicacao)
            {
                mensagem += "   Indicação Antes: " + AuditAntes.audit_indicacao.Trim() +
                    " - Depois: " + AuditDepois.audit_indicacao.Trim() + Environment.NewLine;
            }

            if (AuditAntes.audit_ramoatua != AuditDepois.audit_ramoatua)
            {
                mensagem += "   Ramo Atuação Antes: " + AuditAntes.audit_ramoatua.Trim() +
                    " - Depois: " + AuditDepois.audit_ramoatua.Trim() + Environment.NewLine;
            }

            if (AuditAntes.audit_cep != AuditDepois.audit_cep)
            {
                mensagem += "   Cep Antes: " + AuditAntes.audit_cep.Trim() +
                    " - Depois: " + AuditDepois.audit_cep.Trim() + Environment.NewLine;
            }


            if (AuditAntes.audit_rua != AuditDepois.audit_rua)
            {
                mensagem += "   Rua Antes: " + AuditAntes.audit_rua.Trim() +
                    " - Depois: " + AuditDepois.audit_rua.Trim() + Environment.NewLine;
            }

            if (AuditAntes.audit_numero != AuditDepois.audit_numero)
            {
                mensagem += "   Número: " + AuditAntes.audit_numero.Trim() +
                    " - Depois: " + AuditDepois.audit_numero.Trim() + Environment.NewLine;
            }

            if (AuditAntes.audit_complemento != AuditDepois.audit_complemento)
            {
                mensagem += "   Complemento Antes: " + AuditAntes.audit_complemento.Trim() +
                    " - Depois: " + AuditDepois.audit_complemento.Trim() + Environment.NewLine;
            }


            if (AuditAntes.audit_bairro != AuditDepois.audit_bairro)
            {
                mensagem += "   Bairro Antes: " + AuditAntes.audit_bairro.Trim() +
                    " - Depois: " + AuditDepois.audit_bairro.Trim() + Environment.NewLine;
            }

            if (AuditAntes.audit_cidade != AuditDepois.audit_cidade)
            {
                mensagem += "   Cidade Antes: " + AuditAntes.audit_cidade.Trim() +
                    " - Depois: " + AuditDepois.audit_cidade.Trim() + Environment.NewLine;
            }

            if (AuditAntes.audit_uf != AuditDepois.audit_uf)
            {
                mensagem += "   UF Antes: " + AuditAntes.audit_uf.Trim() +
                    " - Depois: " + AuditDepois.audit_uf.Trim() + Environment.NewLine;
            }

            if (AuditAntes.audit_cosultor != AuditDepois.audit_cosultor)
            {
                mensagem += "   Consultor Antes: " + AuditAntes.audit_cosultor.Trim() +
                    " - Depois: " + AuditDepois.audit_cosultor.Trim() + Environment.NewLine;
            }

            if (AuditAntes.DDDDecisor != AuditDepois.DDDDecisor)
            {
                mensagem += "   DDD Decisor Antes: " + AuditAntes.DDDDecisor.Trim() +
                    " - Depois: " + AuditDepois.DDDDecisor.Trim() + Environment.NewLine;
            }

            if (AuditAntes.DDDResp != AuditDepois.DDDResp)
            {
                mensagem += "   DDD Decisor Antes: " + AuditAntes.DDDResp.Trim() +
                    " - Depois: " + AuditDepois.DDDResp.Trim() + Environment.NewLine;
            }

            if (AuditAntes.audit_fase != AuditDepois.audit_fase)
            {
                mensagem += "   DDD Decisor Antes: " + AuditAntes.audit_fase.Trim() +
                    " - Depois: " + AuditDepois.audit_fase.Trim() + Environment.NewLine;
            }
              

            string nomeDeQuemAlterouEOQueAlterou = "";

            if (mensagem != "")
            {
               nomeDeQuemAlterouEOQueAlterou = "Alterador por: " + UsuarioLogado.usuario.nome + Environment.NewLine + mensagem;
            }

            return nomeDeQuemAlterouEOQueAlterou;

        }


        private void bntSalvar_Click(object sender, EventArgs e)
        {

            string inativochk;
            if (chkInativo.Checked == true)
                inativochk = "1";
            else
                inativochk = "0";
            
            if (verificaCampos() == false)
            {
              MessageBox.Show("Necessário Preenchimento dos Campos \n" + msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              return;            
            }

                try
                {    
                    //ALTERAR
                    if (inclui_Ou_Altera == 1)
                    {
                        if (chkInativo.Checked == true)
                        {
                            MessageBox.Show("Desmarque a opção Inativo para poder Alterar", "Reative o cliente para alterar");
                        return;
                        }

                        this.endereco = new Endereco
                        {
                            Codigo = txtId.Text.Trim(),
                            Sequencia = 1,
                            Tipo = 1,
                            Cep = txtCep.Text.Trim(),
                            Ender = txtEndereco.Text.Trim(),
                            Numero = txtNumero.Text.Trim(),
                            Complemento = txtComplemento.Text.Trim(),
                            Bairro = txtBairro.Text.Trim(),
                            Cidade = cmbCidade.Text,
                            Uf = cmbUf.Text,
                            Pais = "Brasil",
                            Inativo = "0",
                            Cadastro = dtpCadastro.Value,
                            Atualizacao = DateTime.Now,
                            Usuario = UsuarioLogado.usuario.id
                        };

                        this.cli = new Clientes
                        {
                            Codigo = txtId.Text,
                            Nome = txtNome.Text,
                            Telefone1 = txtTel1.Text,
                            Telefone2 = txtTel2.Text,
                            Responsavel = txtResponsavel.Text,
                            TelefoneResponsavel = txtTelResponsavel.Text,
                            Decisor = txtDecisor.Text,
                            TelefoneDecisor = txtTelDescisor.Text,
                            Pontos = int.Parse(numPontos.Value.ToString()),
                            Concorrentes = int.Parse(cmbConcorrente.SelectedValue.ToString()),
                            E_mail = txtEmail.Text,
                            Indicacao = int.Parse(cmbIndicacao.SelectedValue.ToString()),
                            RamoAtuacao = int.Parse(cmbRamoAtuacao.SelectedValue.ToString()),
                            Cadastro = dtpCadastro.Value,
                            Atualizacao = DateTime.Now,
                            UsuarioAlterar = UsuarioLogado.usuario.id,
                            //UsuarioCadastro = UsuarioLogado.usuario.id,
                            Inativo = inativochk,
                            DDD = txtDDD.Text.PadLeft(3, '0'),
                            consultor = int.Parse(cmbConsultor.SelectedValue.ToString()),
                            DDDDecisor = txtDDDDescisor.Text.PadLeft(3, '0'),
                            DDDResp = txtDDDresponsavel.Text.PadLeft(3, '0')
                            
                        };
                      
                        //Alterar
                        if (this.cli.updateClientes(cli))
                            if (this.endereco.UpdateEndereco(endereco))
                            {
                                string mensagem = Auditoria();

                                if(mensagem != "")
                                    this.cli.insertClientesAuditoria(txtId.Text,UsuarioLogado.usuario.id,mensagem); 
                            }
                        
                        if (statusProspect == 1)
                        {
                            VariaveisStaticas.codigoclienteStatico = cli.Codigo.Trim();                           
                            this.Close();                            
                        }
                        else
                        {
                          MessageBox.Show("Cliente alterado com sucesso " + Environment.NewLine + Environment.NewLine + cli.Nome);
                          this.Close();
                        }
                    }
                    else
                    {
                        //INCLUIR
                        //inclui_Ou_Altera = 0;

                        this.endereco = new Endereco
                        {
                            Codigo = txtId.Text.Trim(),
                            Sequencia = 1,
                            Tipo = 1,
                            Cep = txtCep.Text.Trim(),
                            Ender = txtEndereco.Text.Trim(),
                            Numero = txtNumero.Text.Trim(),
                            Complemento = txtComplemento.Text.Trim(),
                            Bairro = txtBairro.Text.Trim(),
                            Cidade = cmbCidade.Text,
                            Uf = cmbUf.Text,
                            Pais = "Brasil",
                            Inativo = "0",
                            Cadastro = DateTime.Now,
                            Atualizacao = DateTime.Now,
                            Usuario = UsuarioLogado.usuario.id

                        };


                        this.cli = new Clientes
                        {
                            Codigo = txtId.Text,
                            Nome = txtNome.Text,
                            Telefone1 = txtTel1.Text,
                            Telefone2 = txtTel2.Text,
                            Responsavel = txtResponsavel.Text,
                            TelefoneResponsavel = txtTelResponsavel.Text,
                            Decisor = txtDecisor.Text,
                            TelefoneDecisor = txtTelDescisor.Text.Trim(),                            
                            Pontos = int.Parse(numPontos.Value.ToString()),
                            Concorrentes = int.Parse(cmbConcorrente.SelectedValue.ToString()),
                            E_mail = txtEmail.Text,
                            Indicacao = int.Parse(cmbIndicacao.SelectedValue.ToString()),
                            RamoAtuacao = int.Parse(cmbRamoAtuacao.SelectedValue.ToString()),
                            Cadastro = DateTime.Now,
                            Atualizacao = DateTime.Now,
                            UsuarioAlterar = UsuarioLogado.usuario.id,
                            UsuarioCadastro = UsuarioLogado.usuario.id,
                            Inativo = "0",
                            DDD = txtDDD.Text.PadLeft(3, '0'),
                            consultor = int.Parse(cmbConsultor.SelectedValue.ToString()),
                            DDDResp = txtDDDresponsavel.Text.PadLeft(3, '0'),
                            DDDDecisor = txtDDDDescisor.Text.PadLeft(3, '0'),
                            Fase = 0
                        };
                        //executa o metodo que grava os dados na tabela bugs do banco de dados
                        if (this.cli.insertClientes(cli))
                            this.endereco.insertEndereco(endereco);

                        if (VariaveisStaticas.entrouNoClientePelaProspeccao == true)
                        {
                            VariaveisStaticas.codigoclienteStatico = cli.Codigo.Trim();
                            this.Close();
                        }
                        else
                        {
                            VariaveisStaticas.codigoclienteStatico = cli.Codigo;
                            Prospeccao();
                                                        
                            MessageBox.Show("Cliente inserido com sucesso " + Environment.NewLine + Environment.NewLine + cli.Nome);
                            this.Close();
                        }
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro");
                    using (StreamWriter sw = File.CreateText(".\\erro.log"))
                    {
                        sw.WriteLine(ex.ToString());
                        sw.Close();
                    }
                }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTel2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace 
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                txtResponsavel.Focus();
            }
        }

        private void txtDDD_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace 
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                txtTel1.Focus();
            }
        }

        private void txtTel1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtTel1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace 
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                txtTel2.Focus();
            }
        }

        private void txtTelResponsavel_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace 
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                txtDecisor.Focus();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace 
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                numPontos.Focus();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                txtDDD.Focus();
            }
        }

        private void txtResponsavel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                txtDDDresponsavel.Focus();
            }

            
        }

        private void txtDecisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                txtDDDDescisor.Focus();
            }

           
        }

        private void numPontos_KeyPress(object sender, KeyPressEventArgs e)
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
                cmbConcorrente.Focus();
                if (!this.cmbConcorrente.DroppedDown)
                {
                    this.cmbConcorrente.DroppedDown = true;
                    
                }
            }
        }

        //dica combobox
//dropdownstyle = dropdown

//AutoCompleteMode = SuggestAppend

//AutoCompleteSourceListItems

        private void cmbConcorrente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                cmbIndicacao.Focus();
                if (!this.cmbIndicacao.DroppedDown)
                {
                   this.cmbIndicacao.DroppedDown = true;
                }
                
               
            }
        }

        private void cmbIndicacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                cmbRamoAtuacao.Focus();
                if (!this.cmbRamoAtuacao.DroppedDown)
                {

                    this.cmbRamoAtuacao.DroppedDown = true;

                }

            }
        }

        private void cmbUf_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbUf_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace 
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                //Atribui True no Handled para cancelar o evento
                Endereco municipio = new Endereco();
                if (cmbUf.SelectedItem != null)
                {
                    municipio.GetMunicipio(comercial, cmbUf.SelectedValue.ToString());
                    cmbCidade.SelectedItem = null;

                    if (!this.cmbCidade.DroppedDown)
                    {

                        this.cmbCidade.DroppedDown = true;
                        cmbCidade.Focus();

                    }
                    
                }
            }
        }

        private void cmbCidade_MouseClick(object sender, MouseEventArgs e)
        {
            
            Endereco municipio = new Endereco();
            if (cmbUf.SelectedItem != null)
            {
                municipio.GetMunicipio(comercial, cmbUf.SelectedValue.ToString());
               

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            limpaCampos();
            resetCores();
            ResetComboboxs();
            ResetMaiusculaseMinusculas();
        }

        private void txtDecisor_TextChanged(object sender, EventArgs e)
        {

        }

        public class CEP
        {
            public int Cep { get; set; }
            public string Tipo { get; set; }
            public string Rua { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string UF { get; set; }
        } 
        
        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Se a tecla digitada não for número e nem backspace 
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

            OpenFileDialog cepmdb = new OpenFileDialog();

            string curFile = @".\CEP.mdb";
           // MessageBox.Show(File.Exists(curFile) ? "File exists." : "File does not exist.");

          

            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                try
                {

                    if (!File.Exists(curFile))
                    {
                        MessageBox.Show("Banco de Cep não encontrado");
                        txtEndereco.Focus();
                    }
                    else
                    {
                        CEP cep = new CEP();

                        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\\cep.mdb;Persist Security Info=True");
                        string sql = "SELECT * FROM CEP where cep_cep = \"" + txtCep.Text.Trim() + "\"";
                        // MessageBox.Show(sql);

                        OleDbCommand cmd = new OleDbCommand(sql, conn);

                        conn.Open();

                        OleDbDataReader leitor = cmd.ExecuteReader();


                        cmbUf.ResetText();

                        Endereco municipio = new Endereco();
                        municipio.GetMunicipionovo(comercial);
                        cmbCidade.ResetText();
                        while (leitor.Read())
                        {
                            txtEndereco.Text = leitor["CEP_TIPO"].ToString() + " " + leitor["CEP_ENDERECO"].ToString();
                            txtBairro.Text = leitor["CEP_BAIRRO"].ToString();
                            cmbUf.SelectedText = leitor["CEP_ESTADO"].ToString();

                            cmbCidade.SelectedText = leitor["CEP_CIDADE"].ToString();
                        }


                        //fecha conexão 
                        conn.Close();

                        if (txtEndereco.Text == "")
                            txtEndereco.Focus();
                        else
                            txtNumero.Focus();

                    }
                }
                     catch (Exception ex)
                      {
                         MessageBox.Show(ex.Message);
                      }
            
         
            
            }
        }
           
       
        private void cmbRamoAtuacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {

                if (!this.cmbConsultor.DroppedDown)
                {
                    cmbConsultor.DroppedDown = true;
                    cmbConsultor.Focus();
                }



                //txtCep.Focus();
            }
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(//cmbUf.SelectedValue.ToString() + "  " + cmbUf.ValueMember.ToString() 
           //+ "  " + cmbUf.SelectedText.ToString() + "  " + 
           //cmbUf.SelectedItem.ToString() 
         //  + "  " + 
           cmbUf.Text  
           );
        }

        private void txtEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
             txtNumero.Focus();
            }
               
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                txtComplemento.Focus();
            }
              
        }

        private void txtComplemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                txtBairro.Focus();
            }
              
        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                cmbUf.Focus();
                if (!this.cmbUf.DroppedDown)
                {

                    this.cmbUf.DroppedDown = true;

                }

            }
        }

        private void cmbCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                txtObservacao.Focus();

            }
        }

        private void bntVoltar_Click(object sender, EventArgs e)
        {
            if (inclui_Ou_Altera == 0
                )
            {
                this.observacaocliente = new ObsCli
                {
                    CodigoObs = txtId.Text

                };

                observacaocliente.deleteObs(observacaocliente);
            
            }

            
            
            this.Close();
        }

        Propeccao clsProspeccao = new Propeccao();

        private void Prospeccao()
        {
           
            this.clsProspeccao = new Propeccao
            {
                fCodigon = txtId.Text,
            };

            if (MessageBox.Show("Gostaria de realizar a prospecção deste cliente?", "Gerar Prospecção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


            }
            else
            {
                return;
            }

            if (clsProspeccao.verificaProspeccaoExistente(clsProspeccao) == true)
            {
                MessageBox.Show("Esse cliente já possui Prospecção", "Já possui registro");
            }
            else
            {
                formProspeccao novaprospeccao = new formProspeccao();
                VariaveisStaticas.codigoclienteStatico = txtId.Text;
                novaprospeccao.TranferenciaCliente();
                novaprospeccao.desabilitaBuscaCliente();
                novaprospeccao.prospect();
                this.Hide();
                novaprospeccao.ShowDialog();
                this.Close();
            }

        
        
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            Prospeccao();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnIncluirObs_Click(object sender, EventArgs e)
        {
            this.observacaocliente = new ObsCli
            {
                CodigoObs = txtId.Text,
                Obs = txtObservacao.Text,
                Usuario = UsuarioLogado.usuario.id,
                Dcadastro = DateTime.Now,
                Sequencia = dgvObservacoes.RowCount + 1
            };

            
            if (btnIncluirObs.Text == "Incluir Obs")
            {
                txtObservacao.Enabled = true;
                btnIncluirObs.Text = "Confirmar";
                txtObservacao.Focus();
            }
            else
            {
                if (txtObservacao.Text != "")
                {
                    this.observacaocliente.insertObs(observacaocliente);
                    txtObservacao.Text = string.Empty;
                    txtObservacao.Enabled = false;
                    btnIncluirObs.Text = "Incluir Obs";
                    observacaocliente.SelectObs(comercial, observacaocliente.CodigoObs);
                }
                else
                {
                    MessageBox.Show("Necessário preenchimento da observação");
                }

                        
            }




        }

     

        private void dgvObservacoes_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ObservacaoVisualizar obsview = new ObservacaoVisualizar();
            obsview.Visualizar(dgvObservacoes.CurrentRow.Cells[3].Value.ToString().Trim());
            obsview.ShowDialog();

        }

      

        private void btnPesquisaAuditoria_Click(object sender, EventArgs e)
        {

            this.cli = new Clientes();
            cli.ClienteAuditSelect(comercial, txtId.Text,dtpInicio.Text, dtpFim.Text);

            

                          
            



        }

        private void mskDataFimAudit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                btnPesquisaAuditoria.Focus();
            }
        }

        private void dgvAuditoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string texto = dgvAuditoria.CurrentRow.Cells[3].Value.ToString();
            ObservacaoVisualizar obsview = new ObservacaoVisualizar();
            obsview.Visualizar(texto);
            obsview.ShowDialog();
        }

        private void cmbConsultor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                txtCep.Focus();
            }
        }

        private void CadastroClientes_Load(object sender, EventArgs e)
        {
            if (VariaveisStaticas.entrouNoClientePelaProspeccao == true)
            {
                btnGerarProspeccao.Visible = false;
            }
        }

        private void txtDDDresponsavel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                txtTelResponsavel.Focus();
            }
        }

        private void txtDDDDescisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                txtTelDescisor.Focus();
            }
        }
    }
}
