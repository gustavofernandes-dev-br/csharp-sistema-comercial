using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1
{
    public partial class FormContato : Form
    {
        Clientes AuditAntes = new Clientes();
        Clientes AuditDepois = new Clientes();
        string perfil = UsuarioLogado.usuario.perfil.ToString();
        UsuariosSistema sistema = new UsuariosSistema();
        Clientes cli = new Clientes();
        Combo combo = new Combo();
        Boolean fVisita;
        ClsContato clsContato = new ClsContato();

        int emContato = 0;
        public void EmContato()
        {
            emContato = 1;
        }

        enum GridPesquisar
        { 
            eCodigo = 1,
            eConsultor = 2,
            eNomeCliente = 3,
            eData = 4,
            eMarcouVisita = 5,
            eDecisor = 6,
            eTelDecisor = 7,
            eProximoContato = 8
        }


        public FormContato()
        {
            InitializeComponent();
        
        }

        private void FormContato_Load(object sender, EventArgs e)
        {
            this.Text = "PDV NET Inteligencia em sistemas - Contato";
            //if (System.IO.File.Exists("c:\\COMERCIAL\\imagem\\pdvsuite.ico"))
            //{
            //    Icon icon = Icon.ExtractAssociatedIcon("c:\\COMERCIAL\\imagem\\pdvsuite.ico");
            //    this.Icon = icon;
            //}
            this.combo.ComboConsultores(cmbConsultor);
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
        public void LimpaCampos()
        {
            dtpDataProspeccao.Value = DateTime.Now;
            txtNome.Text = string.Empty;
            txtId.Text = string.Empty;
            txtDDDDecisor.Text = string.Empty;
            txtDecisor.Text = string.Empty;
            txtTelDescisor.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtObsPropeccao.Text = string.Empty;
        }
        //public void resetCores()
        //{
        //    txtNome.BackColor = Color.White;
        //    txtDDDDecisor.BackColor = Color.White;
        //    txtTelDescisor.BackColor = Color.White;
        //    cmbConsultor.BackColor = Color.White;
        //    msg = "";
        //}

        private void reset()
        {

            if (UsuarioLogado.usuario.perfil != "3")
            {
               this.combo.ComboLimpa(cmbConsultor);
            }
            txtId.Text = "";
            txtNome.Text = "";
            txtDecisor.Text = "";
            txtTelDescisor.Text = "";
            txtObsPropeccao.Text = "";
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtObsPropeccao.CharacterCasing = CharacterCasing.Upper;
            txtDecisor.CharacterCasing = CharacterCasing.Upper;
            //fVisita = false;
            rdbVisitaNao.Checked = true;
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
            rdbVisitaNao.Focus();
        }
        public void resetCores()
        {
            txtNome.BackColor = Color.White;
            txtDDDDecisor.BackColor = Color.White;
            txtTelDescisor.BackColor = Color.White;
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
            if (txtDDDDecisor.Text == "")
            {
                ok = false;
                txtDDDDecisor.BackColor = Color.Yellow;
                msg += "\nDDD";
            }
            if (txtTelDescisor.Text.Length < 8 && txtTelDescisor.Text.Length > 8)
            {
                ok = false;
                msg += "\nTelefone do Decisor faltando dígito";
                txtTelDescisor.BackColor = Color.Yellow;
            }
            if (cmbConsultor.SelectedItem == null)
            {
                cmbConsultor.BackColor = Color.Yellow;
                msg += "\nConsultor";
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


        public void TranferenciaCliente()
        {
            if (VariaveisStaticas.codigoclienteStatico == null)
            {
                return;
            }
            string idCliente = VariaveisStaticas.codigoclienteStatico.Trim();
            // MessageBox.Show(dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString());
            //crias a query sql
            string query = "select CLI_CODIGO, CLI_NOME_FANTASIA, CLI_DDD, CLI_TELEFONE1, CLI_TELEFONE2, CLI_RESPONSAVEL, CLI_TELRESPONSAVEL, CLI_DECISOR, CLI_TELDECISOR, CLI_QTDPONTOS,CLI_EMAILS, CLI_CONCORRENTE, CLI_INDICACAO,  CLI_RAMOATUACAO, CLI_CADASTRO, CLI_ATUALIZACAO,  a.us_nome as usuarioatualiza, CLI_INATIVO ";
            query += " ,END_CEP,END_ENDERECO, END_NUMERO, END_COMPLEMENTO, END_BAIRRO, END_CIDADE, END_UF,  b.us_nome as usuarioacadastro , cli_consultor,CLI_DDD_DESCISOR ";
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
                    txtNome.Text = reader.GetString(1);
                    txtDecisor.Text = reader.GetString(7);
                    txtTelDescisor.Text = reader.GetString(8);
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
                    txtDDDDecisor.Text = reader.GetString(27);
                    //cli.ClienteAuditleituraCompara(idCliente);

                }
            }

        }

        private void btnGerarContato_Click(object sender, EventArgs e)
        {
            if (VerificaCampos() == false)
            {
                MessageBox.Show("Necessário Preenchimento dos Campos \n" + msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.cli = new Clientes
            {
                Codigo = txtId.Text.Trim(),
                Decisor = txtDecisor.Text,
                TelefoneDecisor = txtTelDescisor.Text,
                Atualizacao = DateTime.Now,
                UsuarioAlterar = UsuarioLogado.usuario.id,
                DDDDecisor = txtDDDDecisor.Text.PadLeft(3, '0'),
                consultor = int.Parse(cmbConsultor.SelectedValue.ToString()),
                Fase = 2
            };
            this.clsContato = new ClsContato
            {
                fDoc = Sistema.GeradoDoc(),
                fCodigon = txtId.Text,
                fConsultor = int.Parse(cmbConsultor.SelectedValue.ToString()),
                fData = dtpDataProspeccao.Value,
                fCadastro = DateTime.Now,
                fDecisor = txtDecisor.Text,
                fDDD = txtDDDDecisor.Text,
                fTelefone = txtTelDescisor.Text,
                fProximoContato = dtpProximoContato.Value,
                fVisita = this.fVisita,
                fUsuario = UsuarioLogado.usuario.id,
                fInativo = false, 
                fObs = txtObsPropeccao.Text
            };

            if (clsContato.VerificaRepetidos() )
            {

                MessageBox.Show("Já existe um contato para este cliente nesta mesma data", "Já existe");       
            }
            
            
            AuditAntes.ClienteAuditleituraCompara(txtId.Text.Trim());

            if (cli.updateClientesContato(cli))
            {
                AuditDepois.ClienteAuditleituraCompara(txtId.Text);
                cli.insertClientesAuditoria(txtId.Text, UsuarioLogado.usuario.id, Auditoria());
                clsContato.Insert(clsContato);

                MessageBox.Show("Contato gerado com sucesso", "Sucesso");
            }

            if (emContato == 1)
            {
                this.Close();
            }
            else
            {
                reset();
            }
        }

        private void rdbVisitaSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVisitaSim.Checked == true)
            {
                lblVisita.Text = "Data da Visita";
            }
            else
            {
                lblVisita.Text = "Data Próximo Contato";
            }
        }

        private void rdbVisitaNao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVisitaSim.Checked == true)
            {
                lblVisita.Text = "Data da Visita";
                fVisita = true;
            }
            else
            {
                lblVisita.Text = "Data Próximo Contato";
                fVisita = false;
            }
        }

        private void bntVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

        //private void btnGerarProspeccao_Click(object sender, EventArgs e)
        //{
        //    if (VerificaCampos() == false)
        //    {
        //        MessageBox.Show("Necessário Preenchimento dos Campos \n" + msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    this.cli = new Clientes
        //    {
        //        Codigo = txtId.Text,
        //        Decisor = txtDecisor.Text,
        //        TelefoneDecisor = txtTelDescisor.Text,
        //        Atualizacao = DateTime.Now,
        //        UsuarioAlterar = UsuarioLogado.usuario.id,
        //        DDDDecisor = txtDDDDecisor.Text.PadLeft(3, '0'),
        //        consultor = int.Parse(cmbConsultor.SelectedValue.ToString()),
        //        Fase = 1

        //    };

        //    this.prospeccaoclass = new Propeccao
        //    {
        //        idCliente = txtId.Text,
        //        dataDaProspeccao = dtpDataProspeccao.Value,
        //       // meiosDeProspeccao = int.Parse(cmbMeiosPropeccao.SelectedValue.ToString()),
        //        consultor = int.Parse(cmbConsultor.SelectedValue.ToString()),
        //        usuario = UsuarioLogado.usuario.id,
        //        observacaoProspect = txtObsPropeccao.Text,
        //        cadastro = DateTime.Now

        //    };

        //    if (prospeccaoclass.verificaProspeccaoExistente(prospeccaoclass) == true)
        //    {
        //        MessageBox.Show("Esse cliente já possui Prospecção", "Já possui registro");
        //        reset();
        //        if (emProspeccao == 1)
        //        {
        //            this.Close();
        //        }

        //    }
        //    else
        //    {
        //        AuditAntes.ClienteAuditleituraCompara(txtId.Text);

        //        if (cli.updateClientesPropeccao(cli))
        //        {
        //            AuditDepois.ClienteAuditleituraCompara(txtId.Text);
        //            cli.insertClientesAuditoria(txtId.Text, UsuarioLogado.usuario.id, Auditoria());
        //            prospeccaoclass.InsertProspeccao(prospeccaoclass);
        //            cli.insertClientesAuditoria(txtId.Text, UsuarioLogado.usuario.id, "Prospecção Gerada em: " + DateTime.Now.ToString());

        //            MessageBox.Show("Prospecção gerada com sucesso", "Sucesso");
        //        }
        //        reset();
        //        if (emProspeccao == 1)
        //        {
        //            this.Close();
        //        }

        //    }
        //}

    }
}
