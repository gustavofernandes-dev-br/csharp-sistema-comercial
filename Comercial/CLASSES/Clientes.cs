using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Clientes:ConexaoSQL
    {
        public string Codigo { get; set; }
        public string Nome  { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Responsavel { get; set; }
        public string TelefoneResponsavel { get; set; }
        public string Decisor { get; set; }
        public string TelefoneDecisor { get; set; }
        public int Pontos { get; set; }
        public int Concorrentes { get; set; }
        public string E_mail { get; set; }
        public int Indicacao { get; set; }
        public int RamoAtuacao { get; set; }
        public DateTime Cadastro{ get; set; }
        public DateTime Atualizacao { get; set; }
        public int UsuarioAlterar { get; set; }
        public int UsuarioCadastro { get; set; }
        public int consultor { get; set; }
        public string Inativo { get; set; }
        public string DDD { get; set; }
        public string DDDResp { get; set; }
        public string DDDDecisor { get; set; }
        public int Fase { get; set; }


        //campos para auditoria como string
        public string audit_cep { get; set; }
        public string audit_rua { get; set; }
        public string audit_numero { get; set; }
        public string audit_complemento { get; set; }
        public string audit_bairro { get; set; }
        public string audit_cidade { get; set; }
        public string audit_uf { get; set; }
        public string audit_indicacao{ get; set; }
        public string audit_concorrente { get; set; }
        public string audit_ramoatua { get; set; }
        public string audit_obs { get; set; }
        public string audit_cosultor { get; set; }
        public string audit_fase { get; set; }


        //consulta aba auditoria na telade clientes
        //select na tela de cliente na aba Auditoria, alimenta o DataSet que está vinculado ao datagrid view
        public void ClienteAuditSelect(comercial ds, string codigo, string data1, string data2)
        {
            //uma query igual , pra rodar antes e depois
            string query = "SELECT CAU_CODIGO, CAU_DATA, us_nome as CAU_USUARIO, CAU_OBS FROM CLIENTES_AUDITORIA inner join usuarios on us_id = CAU_USUARIO WHERE CAU_DATA BETWEEN '" + data1 + " 00:00:00' AND '" + data2 + " 23:59:59' and  CAU_CODIGO = '" + codigo + "' order by cau_data desc ";
            this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);
            this.cmd.CommandType = System.Data.CommandType.Text;
            //usando sqlDataReader para ler os dados do banco de dados
            this.reader = this.cmd.ExecuteReader();

            //verifica retorno das linhas
            if (this.reader.HasRows)
            {
                ds.CLIENTES_AUDITORIA.Rows.Clear();
                while (this.reader.Read())
                {
                    //cria um dataRow com a estrutura da tabela bugs
                    System.Data.DataRow row = ds.CLIENTES_AUDITORIA.NewRow();
                    //pega o item a item da linha atual do reader
                    row[0] = this.reader.GetString(0);
                    row[1] = this.reader.GetDateTime(1);
                    row[2] = this.reader.GetString(2);
                    row[3] = this.reader.GetString(3);
                   
                    //adiciona o DataRow preenchido na tabela do DataSet
                    ds.CLIENTES_AUDITORIA.Rows.Add(row);
                }
            }
            //liberar o reader (leitor)
            this.reader.Close();
            
        }


        //Dá um select antes e depos de alterar para análise do que foi alterado.  
        public Clientes ClienteAuditleituraCompara(string codigo)
        {
             //uma query igual , pra rodar antes e depois
            string  query = "select CLI_CODIGO, CLI_NOME_FANTASIA,CLI_DDD, CLI_TELEFONE1, CLI_TELEFONE2, CLI_RESPONSAVEL, CLI_TELRESPONSAVEL, ";
                    query += " CLI_DECISOR, CLI_TELDECISOR, CLI_QTDPONTOS, con_nome, CLI_EMAILS, ind_nome, ram_nome, ";
                    query += " CLI_INATIVO, END_CEP, END_ENDERECO, END_NUMERO, END_COMPLEMENTO, END_BAIRRO, END_CIDADE, END_UF, us_nome, CLI_DDD_DESCISOR, CLI_DDD_RESPONSAVEL,FAS_DESCRICAO ";
                    query += "  from clientes  inner join endereco on end_codigo = cli_codigo ";
                    query += "  inner join clientes_indicacao on IND_CODIGO = CLI_INDICACAO ";
                    query += "  inner join usuarios on us_id = CLI_consultor ";
                    query += "  inner join CLIENTES_CONCORRENTE on CON_CODIGO = CLI_CONCORRENTE ";
                    query += "  inner join clientes_ramoatuacao on ram_codigo = CLI_RAMOATUACAO ";
                    query += "  inner join FASES on FAS_codigo = CLI_FASE ";
                    query += "   where cli_codigo = '" + codigo + "'";

                    //string nome, ddd, tel1, tel2, resp, telresp, decisor, teldecisor, email, inativo;
                    //string concorrente, indicacao, ramoatuacao;
                    //string cep, rua, numero, complemento, bairro, cidade, uf;
                    //int pontos;
                  
            this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);
            this.cmd.CommandType = System.Data.CommandType.Text;
            
            //usando sqlDataReader para ler os dados do banco de dados
            this.reader = this.cmd.ExecuteReader();
            
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    this.Codigo = reader.GetString(0);
                    this.Nome = reader.GetString(1);
                    this.DDD = reader.GetString(2);
                    this.Telefone1 = reader.GetString(3);
                    this.Telefone2 = reader.GetString(4);
                    this.Responsavel = reader.GetString(5);
                    this.TelefoneResponsavel = reader.GetString(6);
                    this.Decisor = reader.GetString(7);
                    this.TelefoneDecisor = reader.GetString(8);
                    this.Pontos = reader.GetInt16(9);
                    this.audit_concorrente = reader.GetString(10);
                    this.E_mail = reader.GetString(11);
                    this.audit_indicacao = reader.GetString(12);
                    this.audit_ramoatua = reader.GetString(13);
                    this.Inativo = reader.GetString(14);
                    this.audit_cep = reader.GetString(15);
                    this.audit_rua = reader.GetString(16);
                    this.audit_numero = reader.GetString(17);
                    this.audit_complemento = reader.GetString(18);
                    this.audit_bairro = reader.GetString(19);
                    this.audit_cidade = reader.GetString(20);
                    this.audit_uf = reader.GetString(21);
                    this.audit_cosultor = reader.GetString(22);
                    this.DDDDecisor = reader.GetString(23);
                    this.DDDResp = reader.GetString(24);
                    this.audit_fase = reader.GetString(25);


                }
            }
            reader.Close();
            return this;
        }

       



        //Select para carregar a informações na tela pea alterar 
        public void ClienteSelectParaAlterar(string codigo)
        {
          string nome,ddd,tel1,tel2,resp,telresp,decisor,teldecisor, email, inativo;
          int pontos,  concorrente,  indicacao, ramoatuacao, usuario,usuarioCadastro, consultor;
          DateTime cadastro,  atualizacao; 
           
            //crias a query sql
            string query = "select CLI_CODIGO, CLI_NOME_FANTASIA, CLI_DDD, CLI_TELEFONE1, CLI_TELEFONE2, CLI_RESPONSAVEL, CLI_TELRESPONSAVEL, CLI_DECISOR, CLI_TELDECISOR, CLI_QTDPONTOS,CLI_EMAILS, CLI_CONCORRENTE, CLI_INDICACAO,  CLI_RAMOATUACAO, CLI_CADASTRO, CLI_ATUALIZACAO, CLI_USUARIO, CLI_INATIVO,CLI_USUARIOCADASTRO, cli_consultor,  CLI_DDD_DESCISOR, CLI_DDD_RESPONSAVEL,CLI_FASE ";
            query += " from clientes  where cli_codigo = '"+codigo+"'";

            MessageBox.Show(query);

            this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);
            this.cmd.CommandType = System.Data.CommandType.Text;

           
            //usando sqlDataReader para ler os dados do banco de dados
            this.reader = this.cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    codigo = reader.GetString(0);
                    nome = reader.GetString(1);
                    ddd = reader.GetString(2);
                    tel1 = reader.GetString(3);
                    tel2 = reader.GetString(4);
                    resp = reader.GetString(5);
                    telresp = reader.GetString(6);
                    decisor = reader.GetString(7);
                    teldecisor = reader.GetString(8);
                    pontos = reader.GetInt16(9);
                    email = reader.GetString(10);
                    concorrente = reader.GetInt16(11);
                    indicacao = reader.GetInt16(12);
                    ramoatuacao = reader.GetInt16(13);
                    cadastro = reader.GetDateTime(14);
                    atualizacao = reader.GetDateTime(15);
                    usuario = reader.GetInt16(16);
                    inativo = reader.GetString(17);
                    usuarioCadastro = reader.GetInt16(18);
                    consultor = reader.GetInt32(19);
                    DDDDecisor = reader.GetString(20);
                    DDDResp = reader.GetString(21);
                    Fase = reader.GetInt32(22);
                }
            }

            //return ds;
        }

        //Utilizado para inserir auditoria junto com a função auditoria
        public bool insertClientesAuditoria(string codigo, int user, string obsaudit)
        {
            //query
            string query = "insert into clientes_auditoria values ( @CAU_CODIGO, GETDATE() , @CAU_USUARIO , @CAU_OBS)";

            //cria uma nova instancia SQLcommand
            this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);

            //define o tipo do comando
            this.cmd.CommandType = System.Data.CommandType.Text;

            //alimenta ps paramentos
            this.cmd.Parameters.AddWithValue("@CAU_CODIGO", codigo);
            this.cmd.Parameters.AddWithValue("@CAU_USUARIO", user);
            this.cmd.Parameters.AddWithValue("@CAU_OBS", obsaudit);


            //executa o comendo e verifica o retorno
            if (this.cmd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }

        //inserir clientes
        public bool insertClientes(Clientes CLIENTES1)
        {
            try
            {

        
            
            //query
           
            string query = "insert into CLIENTES(CLI_CODIGO, CLI_NOME_FANTASIA, CLI_DDD, CLI_TELEFONE1, CLI_TELEFONE2, CLI_RESPONSAVEL,";
             query += "CLI_TELRESPONSAVEL, CLI_DECISOR, CLI_TELDECISOR, CLI_QTDPONTOS, CLI_CONCORRENTE, CLI_EMAILS, CLI_INDICACAO, ";
             query += "CLI_RAMOATUACAO,  ";
             query += " CLI_CADASTRO, CLI_ATUALIZACAO, CLI_USUARIO, CLI_INATIVO,CLI_USUARIOCADASTRO, cli_consultor,  CLI_DDD_DESCISOR, CLI_DDD_RESPONSAVEL,CLI_FASE)";
             query += "values(@CODIGO, @FANTASIA, @DDD, @TELEFONE1, @TELEFONE2, @RESPONSAVEL, @TELRESPONSAVEL, @DECISOR, @TELDECISOR, @QTDPONTOS, ";
             query += "@CONCORRENTE, @EMAILS, @INDICACAO, @RAMOATUACAO,  @CADASTRO, @ATUALIZACAO, @USUARIO, @INATIVO,@USUARIOCADASTRO, @consultor, @DDDDECISOR, @DDDRESPONSAVEL, '0')";
			
            //cria uma nova instancia SQLcommand
            this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);

            //define o tipo do comando
            this.cmd.CommandType = System.Data.CommandType.Text;

            //alimenta ps paramentos
            this.cmd.Parameters.AddWithValue("@CODIGO",CLIENTES1.Codigo);
            this.cmd.Parameters.AddWithValue("@FANTASIA", CLIENTES1.Nome);
            this.cmd.Parameters.AddWithValue("@DDD", CLIENTES1.DDD);
            this.cmd.Parameters.AddWithValue("@TELEFONE1", CLIENTES1.Telefone1);
            this.cmd.Parameters.AddWithValue("@TELEFONE2", CLIENTES1.Telefone2);
            this.cmd.Parameters.AddWithValue("@RESPONSAVEL", CLIENTES1.Responsavel);
            this.cmd.Parameters.AddWithValue("@TELRESPONSAVEL", CLIENTES1.TelefoneResponsavel);
            this.cmd.Parameters.AddWithValue("@DECISOR", CLIENTES1.Decisor);
            this.cmd.Parameters.AddWithValue("@TELDECISOR", CLIENTES1.TelefoneDecisor);
            this.cmd.Parameters.AddWithValue("@QTDPONTOS", CLIENTES1.Pontos);
            this.cmd.Parameters.AddWithValue("@CONCORRENTE", CLIENTES1.Concorrentes);
            this.cmd.Parameters.AddWithValue("@EMAILS", CLIENTES1.E_mail);
            this.cmd.Parameters.AddWithValue("@INDICACAO", CLIENTES1.Indicacao);
            this.cmd.Parameters.AddWithValue("@RAMOATUACAO", CLIENTES1.RamoAtuacao);
            this.cmd.Parameters.AddWithValue("@CADASTRO", CLIENTES1.Cadastro);
            this.cmd.Parameters.AddWithValue("@ATUALIZACAO", CLIENTES1.Atualizacao);
            this.cmd.Parameters.AddWithValue("@USUARIO", CLIENTES1.UsuarioAlterar);
            this.cmd.Parameters.AddWithValue("@INATIVO", CLIENTES1.Inativo);
            this.cmd.Parameters.AddWithValue("@USUARIOCADASTRO", CLIENTES1.UsuarioCadastro);
            this.cmd.Parameters.AddWithValue("@Consultor", CLIENTES1.consultor);
            this.cmd.Parameters.AddWithValue("@DDDDECISOR", CLIENTES1.DDDDecisor);
            this.cmd.Parameters.AddWithValue("@DDDRESPONSAVEL", CLIENTES1.DDDResp);
            
              
            //executa o comendo e verifica o retorno
            if (this.cmd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;

            }
            catch (Exception)
            {

                throw;
            }
        }


        //alera os dados dos clientes
        public bool updateClientes(Clientes CLIENTES2)
        {
            try
            {

        

                bool resposta;
           
                //query
                string query = "update clientes set  CLI_NOME_FANTASIA = @FANTASIA, CLI_DDD = @DDD, CLI_TELEFONE1 = @TELEFONE1, CLI_TELEFONE2 = @TELEFONE2, CLI_RESPONSAVEL = @RESPONSAVEL, ";
                query += "CLI_TELRESPONSAVEL =  @TELRESPONSAVEL , CLI_DECISOR = @DECISOR, CLI_TELDECISOR = @TELDECISOR, CLI_QTDPONTOS = @QTDPONTOS, CLI_CONCORRENTE = @CONCORRENTE, CLI_EMAILS = @EMAILS, ";
                query += "CLI_INDICACAO = @INDICACAO, CLI_RAMOATUACAO = @RAMOATUACAO, CLI_CADASTRO = @CADASTRO, CLI_ATUALIZACAO = @ATUALIZACAO, CLI_USUARIO =  @USUARIO, CLI_INATIVO = @INATIVO";
                query += " ,CLI_CONSULTOR = @CONSULTOR, CLI_DDD_DESCISOR = @DDDDECISOR, CLI_DDD_RESPONSAVEL = @DDDRESPONSAVEL, CLI_FASE = @FASE";
                query += "   WHERE CLI_CODIGO = @CODIGO";
                //cria uma nova instancia SQLcommand
                this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);

                //define o tipo do comando
                this.cmd.CommandType = System.Data.CommandType.Text;

                //alimenta ps paramentos
                this.cmd.Parameters.AddWithValue("@CODIGO", CLIENTES2.Codigo);
                this.cmd.Parameters.AddWithValue("@FANTASIA", CLIENTES2.Nome);
                this.cmd.Parameters.AddWithValue("@DDD", CLIENTES2.DDD);
                this.cmd.Parameters.AddWithValue("@TELEFONE1", CLIENTES2.Telefone1);
                this.cmd.Parameters.AddWithValue("@TELEFONE2", CLIENTES2.Telefone2);
                this.cmd.Parameters.AddWithValue("@RESPONSAVEL", CLIENTES2.Responsavel);
                this.cmd.Parameters.AddWithValue("@TELRESPONSAVEL", CLIENTES2.TelefoneResponsavel);
                this.cmd.Parameters.AddWithValue("@DECISOR", CLIENTES2.Decisor);
                this.cmd.Parameters.AddWithValue("@TELDECISOR", CLIENTES2.TelefoneDecisor);
                this.cmd.Parameters.AddWithValue("@QTDPONTOS", CLIENTES2.Pontos);
                this.cmd.Parameters.AddWithValue("@CONCORRENTE", CLIENTES2.Concorrentes);
                this.cmd.Parameters.AddWithValue("@EMAILS", CLIENTES2.E_mail);
                this.cmd.Parameters.AddWithValue("@INDICACAO", CLIENTES2.Indicacao);
                this.cmd.Parameters.AddWithValue("@RAMOATUACAO", CLIENTES2.RamoAtuacao);
                this.cmd.Parameters.AddWithValue("@CADASTRO", CLIENTES2.Cadastro);
                this.cmd.Parameters.AddWithValue("@ATUALIZACAO", CLIENTES2.Atualizacao);
                this.cmd.Parameters.AddWithValue("@USUARIO", CLIENTES2.UsuarioAlterar);
                this.cmd.Parameters.AddWithValue("@INATIVO", CLIENTES2.Inativo);
                this.cmd.Parameters.AddWithValue("@CONSULTOR", CLIENTES2.consultor);
                this.cmd.Parameters.AddWithValue("@DDDDECISOR", CLIENTES2.DDDDecisor);
                this.cmd.Parameters.AddWithValue("@DDDRESPONSAVEL", CLIENTES2.DDDResp);
                this.cmd.Parameters.AddWithValue("@FASE", CLIENTES2.Fase);
              
                //executa o comendo e verifica o retorno
                if (cmd.ExecuteNonQuery() > 0)
                    resposta = true;
                else
                    resposta = false;
                return resposta;

            }
            catch (Exception)
            {

                throw;
            } 
        }

        public bool updateClientesPropeccao(Clientes CLIENTES3)
        {
            try
            {

         
            //query
            string query = "update clientes set  CLI_DDD = @DDD, CLI_TELEFONE1 = @TELEFONE1, CLI_TELEFONE2 = @TELEFONE2, CLI_RESPONSAVEL = @RESPONSAVEL, ";
            query += " CLI_TELRESPONSAVEL =  @TELRESPONSAVEL , CLI_DECISOR = @DECISOR, CLI_TELDECISOR = @TELDECISOR, CLI_QTDPONTOS = @QTDPONTOS, CLI_CONCORRENTE = @CONCORRENTE,  ";
            query += "  CLI_RAMOATUACAO = @RAMOATUACAO, CLI_ATUALIZACAO = @ATUALIZACAO, CLI_USUARIO = @USUARIO,CLI_DDD_DESCISOR = @DDDDECISOR, CLI_DDD_RESPONSAVEL = @DDDRESPONSAVEL, CLI_FASE = @FASE ";
            query += "   WHERE CLI_CODIGO = @CODIGO";
            //cria uma nova instancia SQLcommand
            this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);
            //define o tipo do comando
            this.cmd.CommandType = System.Data.CommandType.Text;

            //alimenta ps paramentos
            this.cmd.Parameters.AddWithValue("@CODIGO", CLIENTES3.Codigo);
            this.cmd.Parameters.AddWithValue("@DDD", CLIENTES3.DDD);
            this.cmd.Parameters.AddWithValue("@TELEFONE1", CLIENTES3.Telefone1);
            this.cmd.Parameters.AddWithValue("@TELEFONE2", CLIENTES3.Telefone2);
            this.cmd.Parameters.AddWithValue("@RESPONSAVEL", CLIENTES3.Responsavel);
            this.cmd.Parameters.AddWithValue("@TELRESPONSAVEL", CLIENTES3.TelefoneResponsavel);
            this.cmd.Parameters.AddWithValue("@DECISOR", CLIENTES3.Decisor);
            this.cmd.Parameters.AddWithValue("@TELDECISOR", CLIENTES3.TelefoneDecisor);
            this.cmd.Parameters.AddWithValue("@QTDPONTOS", CLIENTES3.Pontos);
            this.cmd.Parameters.AddWithValue("@CONCORRENTE", CLIENTES3.Concorrentes);
            this.cmd.Parameters.AddWithValue("@RAMOATUACAO", CLIENTES3.RamoAtuacao);
            this.cmd.Parameters.AddWithValue("@ATUALIZACAO", CLIENTES3.Atualizacao);
            this.cmd.Parameters.AddWithValue("@USUARIO", CLIENTES3.UsuarioAlterar);
            this.cmd.Parameters.AddWithValue("@DDDDECISOR", CLIENTES3.DDDDecisor);
            this.cmd.Parameters.AddWithValue("@DDDRESPONSAVEL", CLIENTES3.DDDResp);
            this.cmd.Parameters.AddWithValue("@FASE", CLIENTES3.Fase);
            //executa o comendo e verifica o retorno
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else
               return false;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool updateClientesContato(Clientes CLIENTES3)
        {
            try
            {

            //query
            string query = "update clientes set  CLI_DECISOR = @DECISOR, CLI_TELDECISOR = @TELDECISOR,";
            query += "   CLI_ATUALIZACAO = @ATUALIZACAO, CLI_USUARIO = @USUARIO, CLI_DDD_DESCISOR = @DDDDECISOR, CLI_FASE = @FASE ";
            query += "   WHERE CLI_CODIGO = @CODIGO";
            //cria uma nova instancia SQLcommand
            this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);
            //define o tipo do comando
            this.cmd.CommandType = System.Data.CommandType.Text;

            //alimenta ps paramentos
            this.cmd.Parameters.AddWithValue("@CODIGO", CLIENTES3.Codigo);
            this.cmd.Parameters.AddWithValue("@DECISOR", CLIENTES3.Decisor);
            this.cmd.Parameters.AddWithValue("@TELDECISOR", CLIENTES3.TelefoneDecisor);
            this.cmd.Parameters.AddWithValue("@QTDPONTOS", CLIENTES3.Pontos);
            this.cmd.Parameters.AddWithValue("@USUARIO", CLIENTES3.UsuarioAlterar);
            this.cmd.Parameters.AddWithValue("@DDDDECISOR", CLIENTES3.DDDDecisor);
            this.cmd.Parameters.AddWithValue("@FASE", CLIENTES3.Fase);
            this.cmd.Parameters.AddWithValue("@ATUALIZACAO", CLIENTES3.Atualizacao);
            //executa o comendo e verifica o retorno
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;

            }
            catch (Exception)
            {

                throw;
            }
        }
        
        //SELECT PARA DATA GRI VIEW , TODOS CLIENTES
        public void GetClientes(comercial ds1, string codigo, string inativos)
        {
            //crias a query sql
            string query = "select clientes.CLI_CODIGO AS CODIGO, CLI_NOME_FANTASIA AS NOME_FANTASIA,  '(' + CLI_DDD + ')' +  CLI_TELEFONE1 , '(' + CLI_DDD + ')' +  CLI_TELEFONE2,  CLI_DECISOR,  '(' + CLI_DDD + ')' +  CLI_TELDECISOR, CLI_QTDPONTOS, CON_NOME, CLI_CADASTRO, CLI_ATUALIZACAO, cli_fase from clientes ";
            query += "INNER JOIN CLIENTES_CONCORRENTE ON CON_CODIGO = CLI_CONCORRENTE ";
            query += "INNER JOIN CLIENTES_INDICACAO ON IND_CODIGO = CLI_INDICACAO ";
            query += "INNER JOIN CLIENTES_RAMOATUACAO ON RAM_CODIGO = CLI_RAMOATUACAO ";
            query += " where cli_nome_fantasia LIKE '%"+codigo+"%' ";
            query += " and cli_inativo = '"+inativos+"'"; 
            query += "order by CLI_NOME_FANTASIA";
                                             
            this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);
            this.cmd.CommandType = System.Data.CommandType.Text;
            
            //usando sqlDataReader para ler os dados do banco de dados
            this.reader = this.cmd.ExecuteReader();

            //verifica retorno das linhas
            if (this.reader.HasRows)
            {
                ds1.CLIENTES_GRIDVIEW.Rows.Clear();
                while (this.reader.Read())
                {
                    //cria um dataRow com a estrutura da tabela bugs
                    System.Data.DataRow row = ds1.CLIENTES_GRIDVIEW.NewRow();
                    //pega o item a item da linha atual do reader
                    row[0] = this.reader.GetString(0);
                    row[1] = this.reader.GetString(1);
                    row[2] = this.reader.GetString(2);
                    row[3] = this.reader.GetString(3);
                    row[4] = this.reader.GetString(4);
                    row[5] = this.reader.GetString(5);
                    row[6] = this.reader.GetValue(6);
                    row[7] = this.reader.GetString(7); 
                    row[8] = this.reader.GetDateTime(8);
                    row[9] = this.reader.GetDateTime(9);
                    row[10] = this.reader.GetValue(10);


                    //adiciona o DataRow preenchido na tabela do DataSet
                    ds1.CLIENTES_GRIDVIEW.Rows.Add(row);
                }
            }
            //liberar o reader (leitor)
            this.reader.Close();
        }

        //SELECT PARA DATA GRI VIEW , SOMENTE CLIENTES DO USUSARIO LOGADO
        public void GetClientesPorConsultor(comercial ds3, string codigo, string inativos, int IdConsultor)
        {

            //crias a query sql
            string query = "select clientes.CLI_CODIGO AS CODIGO, CLI_NOME_FANTASIA AS NOME_FANTASIA,  '(' + CLI_DDD + ')' +  CLI_TELEFONE1 , '(' + CLI_DDD + ')' +  CLI_TELEFONE2,  CLI_DECISOR,  '(' + CLI_DDD + ')' +  CLI_TELDECISOR, CLI_QTDPONTOS, CON_NOME, CLI_CADASTRO, CLI_ATUALIZACAO,cli_fase from clientes ";
            query += "INNER JOIN CLIENTES_CONCORRENTE ON CON_CODIGO = CLI_CONCORRENTE ";
            query += "INNER JOIN CLIENTES_INDICACAO ON IND_CODIGO = CLI_INDICACAO ";
            query += "INNER JOIN CLIENTES_RAMOATUACAO ON RAM_CODIGO = CLI_RAMOATUACAO ";
            query += " where cli_nome_fantasia LIKE '%" + codigo + "%' ";
            query += " and cli_inativo = '" + inativos + "'";
            query += " and cli_consultor = " + IdConsultor + "";
            query += "order by CLI_NOME_FANTASIA";


            this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);
            this.cmd.CommandType = System.Data.CommandType.Text;



            //usando sqlDataReader para ler os dados do banco de dados
            this.reader = this.cmd.ExecuteReader();

            //verifica retorno das linhas
            if (this.reader.HasRows)
            {
                ds3.CLIENTES_GRIDVIEW.Rows.Clear();
                while (this.reader.Read())
                {
                    //cria um dataRow com a estrutura da tabela bugs
                    System.Data.DataRow row = ds3.CLIENTES_GRIDVIEW.NewRow();
                    //pega o item a item da linha atual do reader
                    row[0] = this.reader.GetString(0);
                    row[1] = this.reader.GetString(1);
                    row[2] = this.reader.GetString(2);
                    row[3] = this.reader.GetString(3);
                    row[4] = this.reader.GetString(4);
                    row[5] = this.reader.GetString(5);
                    row[6] = this.reader.GetValue(6);
                    row[7] = this.reader.GetString(7);
                    row[8] = this.reader.GetDateTime(8);
                    row[9] = this.reader.GetDateTime(9);
                    row[10] = this.reader.GetValue(10);

                    //adiciona o DataRow preenchido na tabela do DataSet
                    ds3.CLIENTES_GRIDVIEW.Rows.Add(row);
                }
            }
            //liberar o reader (leitor)
            this.reader.Close();
        }


      
    }
}
