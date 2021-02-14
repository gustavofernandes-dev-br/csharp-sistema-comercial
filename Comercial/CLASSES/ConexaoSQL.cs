using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
   abstract class ConexaoSQL
    {
        //atributos privados
         private SqlConnection sqlConn;

         //atributos protegidos
         //sqlcommand - classe responsvel por receber os comandos
         //requer conecao ativa
        protected SqlCommand cmd;



         //SqlDataAdapter é a classe que recebe a colecao retornada pelo
         //banco de dados e preenche a tabela informada
        protected SqlDataAdapter adp;


         //sqldatareader e a classe que faz a leitura linha a linha
         // dos dados retornados pela a execucao do comendo sql comando.executer reader
        protected SqlDataReader reader;


        //Datatables é a classe usada para criar tabelas
        protected DataTable tb;
        protected ConexaoSQL()
        {
           //local
          //  this.sqlConn = new SqlConnection("Data Source=GUSTAVO-PC\\PDVNET;Initial Catalog=BDGUSTAVO;User id=sa;Password=inter#system");
                    
                //nuvens
           this.sqlConn = new SqlConnection("Data Source=200.98.141.69,60705\\CLIENTES;Initial Catalog=BDGUSTAVO;User id=gustavo;Password=gus123456");
        }


         //constutor padrao
        protected ConexaoSQL(string strHost)
        {
            this.sqlConn = new SqlConnection(strHost);
        }

         //propriedade somente leitura

        protected SqlConnection ConexaoAtiva
        {
            get 
            {
                if (this.sqlConn.State == ConnectionState.Closed)
                    this.sqlConn.Open();
                //retorna a conexao
                return this.sqlConn;
            
            }
        
        }

    }
}
