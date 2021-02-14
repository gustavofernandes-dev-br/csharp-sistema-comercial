using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Endereco:ConexaoSQL

    {
        //ENDEREÇO
        public string Codigo { get; set; }
        public int Sequencia { get; set; }
        public int Tipo { get; set; }
        public string Cep { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Ender { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Pais { get; set; }
        public string Inativo  { get; set; }
        public DateTime Cadastro { get; set; }
        public DateTime Atualizacao { get; set; }
        public int Usuario { get; set; }
    
        //ESTADO
        public Int32 EstCodigo { get; set; }
        public string EstUF { get; set; }
        public int Regiao { get; set; }

        //MUNICIPIO
        public Int32 MunCodigo { get; set; }
        public string MunNome { get; set; }
        public int MunCodigoUF { get; set; }
        
        public void GetUf(comercial ds)
        {
            string query = "select EST_CODIGO, EST_UF from ENDERECO_ESTADO";
            this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);
            this.cmd.CommandType = System.Data.CommandType.Text;
            //cria uma nova instancia do sqldata adapter, passnado o comando
            this.adp = new System.Data.SqlClient.SqlDataAdapter(this.cmd);

            ds.ENDERECO_ESTADO.Clear();

            //preenche a tabela 'setores' dos dataset recebido por paramentro
            this.adp.Fill(ds.ENDERECO_ESTADO);
        }

        public void GetMunicipio(comercial ds, string ufpreenchido)
        {

            if (ufpreenchido == "")
            return;

            string query = "select  mun_codigo, mun_nome from endereco_municipio where mun_uf = " + ufpreenchido + "";
            this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);
            this.cmd.CommandType = System.Data.CommandType.Text;

            this.adp = new System.Data.SqlClient.SqlDataAdapter(this.cmd);

            ds.ENDERECO_MUNICIPIO.Clear();

            //preenche a tabela 'setores' dos dataset recebido por paramentro
            this.adp.Fill(ds.ENDERECO_MUNICIPIO);

        }

        public void GetMunicipionovo(comercial ds)
        {
            //UTILIZADO NO CARREGAMENTO DO FORM CLIENTE CASO UTILIZE O CEP PARA PESQUISAR
            string query = "select  mun_codigo, mun_nome from endereco_municipio";
            this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);
            this.cmd.CommandType = System.Data.CommandType.Text;

            this.adp = new System.Data.SqlClient.SqlDataAdapter(this.cmd);

            ds.ENDERECO_MUNICIPIO.Clear();

            //preenche a tabela 'setores' dos dataset recebido por paramentro
            this.adp.Fill(ds.ENDERECO_MUNICIPIO);
        }

        public bool insertEndereco(Endereco endereco)
        {
            //query
            string query = "insert into endereco values (@END_CODIGO, @END_SEQ, @END_TIPO_ENDERECO, @END_CEP, @END_ENDERECO, @END_NUMERO, @END_COMPLEMENTO, @END_BAIRRO, @END_CIDADE, @END_UF, @END_PAIS, @END_INATIVO, @END_CADASTRO, @END_ATUALIZACAO, @END_USUARIO) ";

            //cria uma nova instancia SQLcommand
            this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);

            //define o tipo do comando
            this.cmd.CommandType = System.Data.CommandType.Text;

            //alimenta ps paramentos

            this.cmd.Parameters.AddWithValue("@END_CODIGO", endereco.Codigo);
            this.cmd.Parameters.AddWithValue("@END_SEQ", endereco.Sequencia);
            this.cmd.Parameters.AddWithValue("@END_TIPO_ENDERECO", endereco.Tipo);
            this.cmd.Parameters.AddWithValue("@END_CEP", endereco.Cep);
            this.cmd.Parameters.AddWithValue("@END_ENDERECO", endereco.Ender);
            this.cmd.Parameters.AddWithValue("@END_NUMERO", endereco.Numero);
            this.cmd.Parameters.AddWithValue("@END_COMPLEMENTO", endereco.Complemento);
            this.cmd.Parameters.AddWithValue("@END_BAIRRO", endereco.Bairro);
            this.cmd.Parameters.AddWithValue("@END_CIDADE", endereco.Cidade);
            this.cmd.Parameters.AddWithValue("@END_UF", endereco.Uf);
            this.cmd.Parameters.AddWithValue("@END_PAIS", endereco.Pais);
            this.cmd.Parameters.AddWithValue("@END_INATIVO", endereco.Inativo);
            this.cmd.Parameters.AddWithValue("@END_CADASTRO", endereco.Cadastro);
            this.cmd.Parameters.AddWithValue("@END_ATUALIZACAO", endereco.Atualizacao);
            this.cmd.Parameters.AddWithValue("@END_USUARIO", endereco.Usuario);

            //executa o comendo e verifica o retorno
            if (this.cmd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }

        public bool UpdateEndereco(Endereco endereco)
        {
            //query
            string query = "UPDATE [dbo].[ENDERECO]  SET [END_CODIGO] = @END_CODIGO, [END_SEQ] = @END_SEQ, ";
                   query +=  "[END_TIPO_ENDERECO] = @END_TIPO_ENDERECO, [END_CEP] = @END_CEP, [END_ENDERECO] = @END_ENDERECO, [END_NUMERO] = @END_NUMERO, [END_COMPLEMENTO] = @END_COMPLEMENTO, ";
                   query += " [END_BAIRRO] = @END_BAIRRO, [END_CIDADE] = @END_CIDADE, [END_UF] = @END_UF, [END_PAIS] = @END_PAIS, [END_INATIVO] = @END_INATIVO, [END_CADASTRO] = @END_CADASTRO, [END_ATUALIZACAO] = @END_ATUALIZACAO, [END_USUARIO] = @END_USUARIO";
                   query += "  WHERE [END_CODIGO] = @END_CODIGO";

            //cria uma nova instancia SQLcommand
            this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);

            //define o tipo do comando
            this.cmd.CommandType = System.Data.CommandType.Text;

            //alimenta ps paramentos

            this.cmd.Parameters.AddWithValue("@END_CODIGO", endereco.Codigo);
            this.cmd.Parameters.AddWithValue("@END_SEQ", endereco.Sequencia);
            this.cmd.Parameters.AddWithValue("@END_TIPO_ENDERECO", endereco.Tipo);
            this.cmd.Parameters.AddWithValue("@END_CEP", endereco.Cep);
            this.cmd.Parameters.AddWithValue("@END_ENDERECO", endereco.Ender);
            this.cmd.Parameters.AddWithValue("@END_NUMERO", endereco.Numero);
            this.cmd.Parameters.AddWithValue("@END_COMPLEMENTO", endereco.Complemento);
            this.cmd.Parameters.AddWithValue("@END_BAIRRO", endereco.Bairro);
            this.cmd.Parameters.AddWithValue("@END_CIDADE", endereco.Cidade);
            this.cmd.Parameters.AddWithValue("@END_UF", endereco.Uf);
            this.cmd.Parameters.AddWithValue("@END_PAIS", endereco.Pais);
            this.cmd.Parameters.AddWithValue("@END_INATIVO", endereco.Inativo);
            this.cmd.Parameters.AddWithValue("@END_CADASTRO", endereco.Cadastro);
            this.cmd.Parameters.AddWithValue("@END_ATUALIZACAO", endereco.Atualizacao);
            this.cmd.Parameters.AddWithValue("@END_USUARIO", endereco.Usuario);

            //executa o comendo e verifica o retorno
            if (this.cmd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }
    }
}
