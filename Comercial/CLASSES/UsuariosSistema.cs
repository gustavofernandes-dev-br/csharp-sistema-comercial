using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    class UsuariosSistema:ConexaoSQL
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public string email { get; set; }
        public string perfil { get; set; }
        public DateTime cadastro { get; set; }
        public string ativo { get; set; }

        public UsuariosSistema GetLogin(string uLogin, string uSenha)
        {
            this.cmd = new System.Data.SqlClient.SqlCommand("select * from usuarios where US_NOME = @login and US_SENHA = @senha and us_inativo = '0'", this.ConexaoAtiva);
            this.cmd.CommandType = System.Data.CommandType.Text;

            //passa os parametros com valor
            this.cmd.Parameters.AddWithValue("@login", uLogin);
            this.cmd.Parameters.AddWithValue("@senha", uSenha);

            //atribui o resultado da query para o leitor
            this.reader = this.cmd.ExecuteReader();

            //verifica se há linhas no leitor
            if (this.reader.HasRows)
            {
                //faz a leitura da linha
                this.reader.Read();

                //alimenta o objeto usuario com os dados da linha retornada do banco de dados
                this.id = this.reader.GetInt16(0);
                this.nome = this.reader.GetString(1);
                this.email = this.reader.GetString(2);
                this.senha = this.reader.GetString(3);
                this.usuario = this.reader.GetString(3);
                this.perfil = this.reader.GetString(5);
                this.cadastro = this.reader.GetDateTime(6);
                this.ativo = this.reader.GetString(7);
            }
            this.reader.Close();
            return this;

        }

        //public void SelectConsultores(comercial ds)
        //{
        //    string query = "Select US_ID, US_NOME,US_PERFIL from usuarios where US_INATIVO = 0 order by us_nome";

        //    //cria uma nova instancia do sql comando e para a query a conexao ativa
        //    this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);

        //    //define o tipo de comando
        //    this.cmd.CommandType = System.Data.CommandType.Text;

        //    //cria uma nova instancia do sqldata adapter, passnado o comando
        //    this.adp = new System.Data.SqlClient.SqlDataAdapter(this.cmd);

        //    ds.Consultores.Clear();

        //    //preenche a tabela 'setores' dos dataset recebido por paramentro
        //    this.adp.Fill(ds.Consultores);
        //}


        //public void SelectConsultoresEspecifico(comercial ds, int perfil)
        //{
        //    string query = "Select US_ID, US_NOME,US_PERFIL from usuarios where us_id = "+perfil+" order by us_nome";

        //    //cria uma nova instancia do sql comando e para a query a conexao ativa
        //    this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);

        //    //define o tipo de comando
        //    this.cmd.CommandType = System.Data.CommandType.Text;

        //    //cria uma nova instancia do sqldata adapter, passnado o comando
        //    this.adp = new System.Data.SqlClient.SqlDataAdapter(this.cmd);

        //    ds.Consultores.Clear();

        //    //preenche a tabela 'setores' dos dataset recebido por paramentro
        //    this.adp.Fill(ds.Consultores);
        //}

    }
}
