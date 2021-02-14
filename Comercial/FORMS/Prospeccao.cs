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
    public partial class formProspeccao : Form
    {
        Clientes AuditAntes = new Clientes();
        Clientes AuditDepois = new Clientes();
        string perfil = UsuarioLogado.usuario.perfil.ToString();
        int iduser = UsuarioLogado.usuario.id;
        UsuariosSistema usuariossistema = new UsuariosSistema();
        Combo combo = new Combo();
        public int FormChamante = 0;

        Concorrentes concorrentes = new Concorrentes();
        int emProspeccao = 0;
        public void prospect()
        {
            emProspeccao = 1;

        }


        public void desabilitaBuscaCliente()
        {
            btnProcurarCliente.Enabled = false;
        }


        Clientes cli = new Clientes();
        Propeccao prospeccaoclass = new Propeccao();

        public formProspeccao()
        {
            InitializeComponent();
            reset();
            //VariaveisStaticas.codigoclienteStatico = "00000000000000000";
        }
        
        private void reset()
        {

            combo.ComboLimpa(cmbConsultor);
            MeioProspeccao meios = new MeioProspeccao();
            meios.SelectMeiosProspeccao(comercial);
            cmbMeiosPropeccao.SelectedItem = null;

            this.concorrentes.SelectRamoAtuacao(comercial);
            this.concorrentes.SelectConcorrentes(comercial);
            cmbConcorrente.SelectedItem = null;
            cmbRamoAtuacao.SelectedItem = null;

            txtId.Text = "";
            txtNome.Text = "";
            txtDDD.Text = "";
            txtTelefone1.Text = "";
            txtTelefone2.Text = "";
            txtResponsavel.Text = "";
            txtTelResp.Text = "";
            txtDecisor.Text = "";
            txtTelDescisor.Text = "";
            txtObsPropeccao.Text = "";
            txtEndereco.Text = string.Empty;
            numPontos.Value = 0;
            VariaveisStaticas.codigoclienteStatico = string.Empty;

            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtObsPropeccao.CharacterCasing = CharacterCasing.Upper;
            txtResponsavel.CharacterCasing = CharacterCasing.Upper;
            txtDecisor.CharacterCasing = CharacterCasing.Upper;

        }

        public void LimpaCampos()
        {
            dtpDataProspeccao.Value = DateTime.Now;
            txtNome.Text = string.Empty;
            txtId.Text = string.Empty;
            numPontos.Value = 0;
            txtDDD.Text = string.Empty;
            txtTelefone1.Text = string.Empty;
            txtTelefone2.Text = string.Empty;
            txtResponsavel.Text = string.Empty;
            txtTelResp.Text = string.Empty;
            txtDecisor.Text = string.Empty;
            txtTelDescisor.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtObsPropeccao.Text = string.Empty;
        }

        private void formProspeccao_Load(object sender, EventArgs e)
        {
            combo.ComboConsultores(cmbConsultor);
            combo.ComboConsultores(cmbPesquisarConsultor);
            dtpPesquisarInicio.Format = DateTimePickerFormat.Custom;
            dtpPesquisarInicio.CustomFormat = "dd/MM/yyyy";
            dtpPesquisarInicio.Format = DateTimePickerFormat.Custom;
            dtpPesquisarFim.CustomFormat = "dd/MM/yyyy";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void TranferenciaCliente()
        {
            if (VariaveisStaticas.codigoclienteStatico == null || VariaveisStaticas.codigoclienteStatico == string.Empty)
            {
                return;
            }
                        
            
            string idCliente = VariaveisStaticas.codigoclienteStatico.Trim();
            // MessageBox.Show(dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString());
            //crias a query sql
            string query = "select CLI_CODIGO, CLI_NOME_FANTASIA, CLI_DDD, CLI_TELEFONE1, CLI_TELEFONE2, CLI_RESPONSAVEL, CLI_TELRESPONSAVEL, CLI_DECISOR, CLI_TELDECISOR, CLI_QTDPONTOS,CLI_EMAILS, CLI_CONCORRENTE, CLI_INDICACAO,  CLI_RAMOATUACAO, CLI_CADASTRO, CLI_ATUALIZACAO,  a.us_nome as usuarioatualiza, CLI_INATIVO ";
            query += " ,END_CEP,END_ENDERECO, END_NUMERO, END_COMPLEMENTO, END_BAIRRO, END_CIDADE, END_UF,  b.us_nome as usuarioacadastro , cli_consultor ";
            query += " from clientes  ";
            query += " left join ENDERECO on CLIENTES.CLI_CODIGO = ENDERECO.END_CODIGO ";
            query += "  inner join usuarios a on  a.US_ID = CLI_USUARIO    inner join usuarios b on b.US_ID = CLI_USUARIOCADASTRO  ";
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
                    txtId.Text = idCliente;
                   // txtId.Text = reader.GetString(0);
                    txtNome.Text = reader.GetString(1);
                    txtDDD.Text = reader.GetString(2);
                    txtTelefone1.Text = reader.GetString(3);
                    txtTelefone2.Text = reader.GetString(4);
                    txtResponsavel.Text = reader.GetString(5);
                    txtTelResp.Text = reader.GetString(6);
                    txtDecisor.Text = reader.GetString(7);
                    txtTelDescisor.Text = reader.GetString(8);
                    numPontos.Value = reader.GetInt16(9);
                  //  txtEmail.Text = reader.GetString(10);
                    cmbConcorrente.SelectedValue = reader.GetInt16(11);
                //    cmbIndicacao.SelectedValue = reader.GetInt16(12);
                    cmbRamoAtuacao.SelectedValue = reader.GetInt16(13);
                 //   dtpCadastro.Value = reader.GetDateTime(14);
                //    dtpAtualizacao.Value = reader.GetDateTime(15);
                //    lblUsuario.Text = reader.GetString(16); //usuario que alterou

                 //   if (reader.GetString(17).Trim() == "0")
                //        chkInativo.Checked = false;
                //    else
                 //       chkInativo.Checked = true;

                    string Cep = reader.GetString(18);
                    string Rua = reader.GetString(19);
                    string numero = reader.GetString(20);
                    string complemento = reader.GetString(21);
                    string bairro = reader.GetString(22);
                    string Cidade = reader.GetString(23);
                    string Uf = reader.GetString(24);

                    txtEndereco.Text = Rua + " ," + numero + "/" + complemento + " - " + bairro + " - " + Cidade + " - " + Uf; 
                 //   lblUsuarioCadastro.Text = reader.GetString(25);
                    cmbConsultor.SelectedValue = reader.GetInt16(26);

                   // cli.ClienteAuditleituraCompara(idCliente);

                }
            }

        }

        public void CarregaCliente()
        {
            txtId.Text = VariaveisStaticas.codigoclienteStatico;
            TranferenciaCliente();
        }

        public void resetCores()
        {
            txtNome.BackColor = Color.White;
            txtDDD.BackColor = Color.White;
            txtTelefone1.BackColor = Color.White;
            txtTelefone2.BackColor = Color.White;
            txtTelDescisor.BackColor = Color.White;
            txtTelResp.BackColor = Color.White;
            numPontos.BackColor = Color.White;
            cmbConcorrente.BackColor = Color.White;
            cmbRamoAtuacao.BackColor = Color.White;
            cmbMeiosPropeccao.BackColor = Color.White;
            cmbConsultor.BackColor = Color.White;
            msg = "";
          
        }

        string msg;
        public bool VerificaCampos()
        {
            resetCores();
            bool ok = true;


            if (txtNome.Text == "")
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

            if (txtTelefone1.Text == "")
            {
                ok = false;
                txtTelefone1.BackColor = Color.Yellow;
                msg += "\nTelefone 1 Obrigatório";
            }
            else if (txtTelefone1.Text.Length < 8)
            {
                ok = false;
                msg += "\nTelefone 1 faltando dígito";
                txtTelefone1.BackColor = Color.Yellow;
            }


           if (txtTelefone2.Text.Length < 8 && txtTelefone2.Text.Length > 0)
            {
                ok = false;
                msg += "\nTelefone 2 faltando dígito ";
                txtTelefone2.BackColor = Color.Yellow;
            }


            if (txtTelResp.Text.Length < 8 && txtTelResp.Text.Length > 0)
            {
                ok = false;
                msg += "\nTelefone do Responsavel faltando dígito";
                txtTelResp.BackColor = Color.Yellow;
            }


            if (txtTelDescisor.Text.Length < 8 && txtTelDescisor.Text.Length > 8)
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
            if (cmbConcorrente.SelectedItem == null)
            {
                cmbConcorrente.BackColor = Color.Yellow;
                msg += "\nConcorrente";
                ok = false;
            }
            if (cmbRamoAtuacao.SelectedItem == null)
            {
                cmbRamoAtuacao.BackColor = Color.Yellow;
                msg += "\nRamo de Atuação";
                ok = false;
            }
            if (cmbConsultor.SelectedItem == null)
            {
                cmbConsultor.BackColor = Color.Yellow;
                msg += "\nConsultor";
                ok = false;
            }
            if (cmbMeiosPropeccao.SelectedItem == null)
            {
                cmbMeiosPropeccao.BackColor = Color.Yellow;
                msg += "\nMeios Prospeccao";
                ok = false;
            }
            if (ok)
            {
               return ok;
            }
            else
            {
                return ok;
                
            }
        }
        
        private void btnProcurarCliente_Click(object sender, EventArgs e)
        {
            CadastroClientes1 pesquisarclientes = new CadastroClientes1();
            VariaveisStaticas.entrouNoClientePelaProspeccao = true;
            this.Hide();
            pesquisarclientes.ShowDialog();
            txtId.Text = VariaveisStaticas.codigoclienteStatico;
            VariaveisStaticas.entrouNoClientePelaProspeccao = false;
            this.Show();
            TranferenciaCliente();
            numPontos.Focus();
        }

        private void bntVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGerarProspeccao_Click(object sender, EventArgs e)
        {

            if (VerificaCampos() == false)
            {
                MessageBox.Show("Necessário Preenchimento dos Campos \n" + msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
             
            this.cli = new Clientes
            {
                Codigo = txtId.Text,
               // Nome = txtNome.Text,
                Telefone1 = txtTelefone1.Text,
                Telefone2 = txtTelefone2.Text,
                Responsavel = txtResponsavel.Text,
                TelefoneResponsavel = txtTelResp.Text,
                Decisor = txtDecisor.Text,
                TelefoneDecisor = txtTelDescisor.Text,
                Pontos = int.Parse(numPontos.Value.ToString()),
                Concorrentes = int.Parse(cmbConcorrente.SelectedValue.ToString()),
                RamoAtuacao = int.Parse(cmbRamoAtuacao.SelectedValue.ToString()),
                //Cadastro = DateTime.Now,
                Atualizacao = DateTime.Now,
                UsuarioAlterar = UsuarioLogado.usuario.id,
                DDD = txtDDD.Text.PadLeft(3, '0'),
                DDDDecisor = txtDDDDecisor.Text.PadLeft(3, '0'),
                DDDResp = txtDDDResp.Text.PadLeft(3, '0'),
                consultor = int.Parse(cmbConsultor.SelectedValue.ToString()),
                Fase = 1
            };

            this.prospeccaoclass = new Propeccao
            {
                //Data da prospecção pode ser diferente da data do cadastro.
                fDoc = Sistema.GeradoDoc(),
                fCodigon = txtId.Text,
                fData = dtpDataProspeccao.Value,
                fMeios = int.Parse(cmbMeiosPropeccao.SelectedValue.ToString()),
                fConsultor = int.Parse(cmbConsultor.SelectedValue.ToString()),
                fUsuario = UsuarioLogado.usuario.id,
                fObs = txtObsPropeccao.Text,
                fCadastro = DateTime.Now, 
                fInativa = false,
            };

            if (prospeccaoclass.verificaProspeccaoExistente(prospeccaoclass) == true)
            {
                MessageBox.Show("Esse cliente já possui Prospecção", "Já possui registro");
                
                if (emProspeccao == 1)
                {
                    this.Close();
                }
                reset();
            }
            else
            {
                AuditAntes.ClienteAuditleituraCompara(txtId.Text);

                if (cli.updateClientesPropeccao(cli))
                {
                    AuditDepois.ClienteAuditleituraCompara(txtId.Text);
                    cli.insertClientesAuditoria(txtId.Text, UsuarioLogado.usuario.id, Auditoria());
                    prospeccaoclass.InsertProspeccao(prospeccaoclass);
                    cli.insertClientesAuditoria( txtId.Text, UsuarioLogado.usuario.id, "Prospecção Gerada em: " + DateTime.Now.ToString());

                MessageBox.Show("Prospecção gerada com sucesso", "Sucesso");
                }
                
                if (emProspeccao == 1)
                {
                    this.Close();
                }
                reset();
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
            if (AuditAntes.TelefoneResponsavel != AuditDepois.TelefoneResponsavel)
            {
                mensagem += "   Tel Responsavel Antes: " + AuditAntes.TelefoneResponsavel.Trim() +
                    " - Depois: " + AuditDepois.TelefoneResponsavel.Trim() + Environment.NewLine;
            }
            if (AuditAntes.Decisor != AuditDepois.Decisor)
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
            if (AuditAntes.E_mail != AuditDepois.E_mail)
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
            string nomeDeQuemAlterouEOQueAlterou = "";

            if (mensagem != "")
            {
                nomeDeQuemAlterouEOQueAlterou = "Alterador por: " + UsuarioLogado.usuario.nome + Environment.NewLine + mensagem;
            }

            return nomeDeQuemAlterouEOQueAlterou;
        }

        private void cmbConsultor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                dtpDataProspeccao.Focus();
            }
        }

        private void dtpDataProspeccao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                btnProcurarCliente.Focus();
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                txtId.Focus();
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                numPontos.Focus();
            }
        }

        private void numPontos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                cmbMeiosPropeccao.Focus();
                if (!this.cmbMeiosPropeccao.DroppedDown)
                {
                    this.cmbMeiosPropeccao.DroppedDown = true;

                }
                
            }
        }

        private void cmbMeiosPropeccao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                txtDDD.Focus();
            }
        }

        private void txtDDD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                txtTelefone1.Focus();
            }         
        }

        private void txtTelefone2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                txtResponsavel.Focus();   
            } 
        }

        private void txtTelefone1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                txtTelefone2.Focus();
            } 
        }

        private void txtResponsavel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                txtTelResp.Focus();
            } 
        }

        private void txtTelResp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                txtDecisor.Focus();
            } 
        }

        private void txtDecisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                txtTelDescisor.Focus();
            } 
        }

        private void txtTelDescisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                cmbConcorrente.Focus();
                if (!this.cmbConcorrente.DroppedDown)
                {
                    this.cmbConcorrente.DroppedDown = true;

                }

            }
        }

        private void cmbConcorrente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                cmbRamoAtuacao.Focus();
                if (!this.cmbRamoAtuacao.DroppedDown)
                {
                    this.cmbRamoAtuacao.DroppedDown = true;

                }

            }
        }

        private void cmbRamoAtuacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                txtObsPropeccao.Focus();

            }
        }

        private void txtObsPropeccao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                btnGerarProspeccao.Focus();

            }
        }

        private void btnPesquisarProspeccao_Click(object sender, EventArgs e)
        {
   

            
            String Query = "select us_nome, pro_Data, cli_nome_fantasia,  mei_nome, pro_obs    from prospeccao";
            Query = Query + " inner join usuarios on us_id = pro_usuario inner join prospeccao_meios on MEI_CODIGO = PRO_MEIOS inner join clientes on cli_codigo = pro_codigon";

            Query = Query + " where pro_inativa = 0 ";


            if (combo.ComboTesta(cmbPesquisarConsultor))
            {
                Query = Query + " and pro_consultor = " + cmbPesquisarConsultor.SelectedValue.ToString();
            }

            if (txtPesquisarCliente.Text != "")
            {
                string Str = txtPesquisarCliente.Text.Trim();
                double Num;
                bool isNum = double.TryParse(Str, out Num);
                if (isNum)
                {
                    Query = Query + " and cli_codigo = '" + Str + "'";
                }
                else
                {
                    Query = Query + " and cli_nome_fantasia like '%" + Str + "%'";
                }  
            }

            string datainicio = dtpPesquisarInicio.Value.Date.ToString();
            string dataFim = dtpPesquisarFim.Value.Date.ToString();
            dataFim = dataFim.Replace("00:00:00" , "23:59:59");


            Query = Query + " and pro_data between '" +   datainicio +  "'   and '"  +  dataFim + "' "   ;


            Grid grid = new Grid();
            grid.GridPopularDataSource(dgvProspeccao, Query);
        }
    }
}
