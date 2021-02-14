using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class SqlExec: ConexaoSQL
    {
        public bool SqlExecuta(String query)
        {
            try
            {
                 this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);
                 this.cmd.CommandType = System.Data.CommandType.Text;
                 if (this.cmd.ExecuteNonQuery() > 0)
                     return true;
                 else
                 return false;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public string SqlPegarValor(String query)
        {
            try
            { 
                this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);
                this.cmd.CommandType = System.Data.CommandType.Text;
                this.reader = cmd.ExecuteReader();
                String retorno = "";
                
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                       retorno = Convert.ToString(reader[0].ToString());
                       return retorno;
                    }
                }
                return retorno;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public bool SqlVerificaPK(String query)
        {
            try
            {
                this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);
                this.cmd.CommandType = System.Data.CommandType.Text;
                this.reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        
        public bool verificaRepetido(String query)
        {
            bool result = false;
            try
            {
                this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);
                this.cmd.CommandType = System.Data.CommandType.Text;
                this.adp = new System.Data.SqlClient.SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                adp.Fill(data);

                if (data.Rows.Count >= 1)
                {
                    result = true;
                }
            }
            catch (SqlException mensagem)
            {
                throw new Exception(mensagem.Message);
            }
            return result;
        }
    }
}
