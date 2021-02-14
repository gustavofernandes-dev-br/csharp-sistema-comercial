using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    //essa classe alimenta tres combobox durante a inclusao ou alteracao do cadastro de clientes

    //concorrentes , indicacao  e ramo de atuacao
    class Concorrentes:ConexaoSQL
    {
        public int id { get; set; }
        public string nome { get; set; }


        public void SelectConcorrentes(comercial ds)
        {
            string query = "select con_codigo, con_nome from clientes_concorrente where con_inativo = '0' order by con_nome";

            //cria uma nova instancia do sql comando e para a query a conexao ativa
            this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);

            //define o tipo de comando
            this.cmd.CommandType = System.Data.CommandType.Text;
            
            //cria uma nova instancia do sqldata adapter, passnado o comando
            this.adp = new System.Data.SqlClient.SqlDataAdapter(this.cmd);

            ds.view_Concorrentes.Clear();

            //preenche a tabela 'setores' dos dataset recebido por paramentro
            this.adp.Fill(ds.view_Concorrentes);
        }

        public void SelectIndicacao(comercial ds)
        {
            string query = "select ind_codigo, ind_nome from clientes_indicacao where ind_inativo = '0' order by ind_nome";

            //cria uma nova instancia do sql comando e para a query a conexao ativa
            this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);

            //define o tipo de comando
            this.cmd.CommandType = System.Data.CommandType.Text;

            //cria uma nova instancia do sqldata adapter, passnado o comando
            this.adp = new System.Data.SqlClient.SqlDataAdapter(this.cmd);

            ds.view_Indicacao.Clear();

            //preenche a tabela 'setores' dos dataset recebido por paramentro
            this.adp.Fill(ds.view_Indicacao);
        }


        public void SelectRamoAtuacao(comercial ds)
        {
            string query = "select ram_codigo, ram_nome from clientes_ramoatuacao where ram_inativo = '0' order by ram_nome";

            //cria uma nova instancia do sql comando e para a query a conexao ativa
            this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);

            //define o tipo de comando
            this.cmd.CommandType = System.Data.CommandType.Text;

            //cria uma nova instancia do sqldata adapter, passnado o comando
            this.adp = new System.Data.SqlClient.SqlDataAdapter(this.cmd);

            ds.view_RamoAtuacao.Clear();

            //preenche a tabela 'setores' dos dataset recebido por paramentro
            this.adp.Fill(ds.view_RamoAtuacao);
        }


    }
}
