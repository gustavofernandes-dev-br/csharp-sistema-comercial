using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication1
{
   class ObsCli: ConexaoSQL
    {


        public string CodigoObs { get; set; }
        public string Obs { get; set; }
        public int Sequencia { get; set; }
        public int Usuario { get; set; }
        public DateTime Dcadastro { get; set; }



        public bool deleteObs(ObsCli obs)
        {
            this.cmd = new System.Data.SqlClient.SqlCommand("sp_cliente_obs_excluir", this.ConexaoAtiva);

            //define o tipo do comando
            this.cmd.CommandType = System.Data.CommandType.StoredProcedure;

            this.cmd.Parameters.AddWithValue("@COB_CODIGO", obs.CodigoObs);
            
            //executa o comendo e verifica o retorno
            if (this.cmd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;

        }



        public bool insertObs(ObsCli obs)
        {
            this.cmd = new System.Data.SqlClient.SqlCommand("sp_cliente_obs_Inserir", this.ConexaoAtiva);

            //define o tipo do comando
            this.cmd.CommandType = System.Data.CommandType.StoredProcedure;

            this.cmd.Parameters.AddWithValue("@COB_CODIGO", obs.CodigoObs);
            this.cmd.Parameters.AddWithValue("@COB_OBS", obs.Obs);
            this.cmd.Parameters.AddWithValue("@COB_USUARIO", obs.Usuario);
            this.cmd.Parameters.AddWithValue("@COB_DATA", obs.Dcadastro);
            this.cmd.Parameters.AddWithValue("@COB_SEQ", obs.Sequencia);

            //executa o comendo e verifica o retorno
            if (this.cmd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;

        }

        public void UpdateObs(ObsCli obs)
        {
            //this.cmd = new System.Data.SqlClient.SqlCommand("sp_cliente_obs_update", this.ConexaoAtiva);

            ////define o tipo do comando
            //this.cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //this.cmd.Parameters.AddWithValue("@COB_CODIGO", endereco.CodigoObs);
            //this.cmd.Parameters.AddWithValue("@COB_OBS", endereco.Obs);

            ////executa o comendo e verifica o retorno
            //if (this.cmd.ExecuteNonQuery() > 0)
            //    return true;
            //else
            //    return false;

        }



        public void SelectObs(comercial ds, string CodigoObs)
        {
            this.cmd = new System.Data.SqlClient.SqlCommand("sp_cliente_obs_Select", this.ConexaoAtiva);

            //define o tipo do comando
            this.cmd.CommandType = System.Data.CommandType.StoredProcedure;

            this.cmd.Parameters.AddWithValue("@COB_CODIGO", CodigoObs);

              this.reader = this.cmd.ExecuteReader();

            //verifica retorno das linhas
            if (this.reader.HasRows)
            {
                ds.CLIENTES_OBS.Rows.Clear();

                while (this.reader.Read())
                {
                         //cria um dataRow com a estrutura da tabela bugs
                    System.Data.DataRow row = ds.CLIENTES_OBS.NewRow();
                    //pega o item a item da linha atual do reader
                    
                    row[0] = this.reader.GetValue(0);
                    row[1] = this.reader.GetString(1);
                    row[2] = this.reader.GetDateTime(2);
                    row[3] = this.reader.GetString(3);
                  
                                       
                    //adiciona o DataRow preenchido na tabela do DataSet
                    ds.CLIENTES_OBS.Rows.Add(row);
                }
            }
            //liberar o reader (leitor)
            this.reader.Close();
        




        }


    }
}
