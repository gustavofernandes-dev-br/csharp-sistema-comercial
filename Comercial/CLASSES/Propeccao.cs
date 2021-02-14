using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.CLASSES;

namespace WindowsFormsApplication1
{
    class Propeccao:ConexaoSQL
    {
        public String fDoc { get; set; }
        public String fCodigon { get; set; }
        public int fConsultor { get; set; }
        public DateTime fData { get; set; }
        public DateTime fCadastro { get; set; }
        public DateTime fAtualizacao { get; set; }
        public int fMeios { get; set; }
        public string fObs { get; set; }
        public int fUsuario { get; set; }
        public bool fInativa { get; set; }

        public bool verificaProspeccaoExistente(Propeccao prospeccao)
        {
            string query = "SELECT * FROM PROSPECCAO WHERE PRO_CODIGON = @CODIGO";

            try
            {

            this.cmd = new System.Data.SqlClient.SqlCommand(query, ConexaoAtiva);
            this.cmd.CommandType = System.Data.CommandType.Text;
            this.cmd.Parameters.AddWithValue("@CODIGO", prospeccao.fCodigon);

            this.reader = this.cmd.ExecuteReader();

            if (reader.HasRows)
            {
                this.reader.Close();
                return true;
            }
            else
            {
                this.reader.Close();
                return false;
            }

            }
            catch (Exception)
            {
                throw;
            }
        }
        

        public bool InsertProspeccao(Propeccao prospeccao)
        {
           // if (verificaProspeccaoExistente(prospeccao) == true)
            // return false;
            try
                {
                    string query = "INSERT INTO PROSPECCAO VALUES (@DOC,  @CODIGON ,@CONSULTOR, @DATA,@CADASTRO, @MEIOS, @OBS, @USUARIO, @INATIVA)";

                    this.cmd = new System.Data.SqlClient.SqlCommand(query , this.ConexaoAtiva);
                    this.cmd.CommandType = System.Data.CommandType.Text;

                    this.cmd.Parameters.AddWithValue("@DOC", prospeccao.fDoc);
                    this.cmd.Parameters.AddWithValue("@CODIGON", prospeccao.fCodigon);
                    this.cmd.Parameters.AddWithValue("@CONSULTOR", prospeccao.fConsultor);
                    this.cmd.Parameters.AddWithValue("@DATA", prospeccao.fData);
                    this.cmd.Parameters.AddWithValue("@CADASTRO", prospeccao.fCadastro);
                    this.cmd.Parameters.AddWithValue("@MEIOS", prospeccao.fMeios);
                    this.cmd.Parameters.AddWithValue("@OBS", prospeccao.fObs);
                    this.cmd.Parameters.AddWithValue("@USUARIO", prospeccao.fUsuario);
                    this.cmd.Parameters.AddWithValue("@INATIVA", prospeccao.fInativa);
           
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

    }

}
