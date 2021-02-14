using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ClsContato: ConexaoSQL
    {
        public String fDoc { get; set; }
        public String fCodigon { get; set; }
        public int fConsultor { get; set; }
        public DateTime fData { get; set; }
        public DateTime fCadastro { get; set; }
        public DateTime fProximoContato { get; set; }
        //public DateTime fAtualizacao { get; set; }
        public string fDecisor { get; set; }
        public string fDDD { get; set; }
        public string fTelefone { get; set; }
        public bool fVisita { get; set; }
        public string fObs { get; set; }
        public int fUsuario { get; set; }
        public bool fInativo { get; set; }

        Clientes cli = new Clientes();


        public bool VerificaRepetidos()
        {
            SqlExec sql = new SqlExec();
            string query = "Select * from contato where con_data = '" + fData + "' and con_codigon ='" + fCodigon + "' " + " and con_consultor = " + fConsultor  ;

            if (sql.verificaRepetido(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Insert(ClsContato contato)
        {
            // if (verificacontatoExistente(contato) == true)
            // return false;
            try
            {
                string query = "INSERT INTO CONTATO VALUES (@DOC,  @CODIGON ,@CONSULTOR, @DATA,";
                query = query + "@CADASTRO,@CONTATO, @TELEFONE,@PROXIMO_CONTATO , @OBS, ";
                query = query + "@DOC_VISITA, @USUARIO, @INATIVO, @DDD)";
                
                this.cmd = new System.Data.SqlClient.SqlCommand(query, this.ConexaoAtiva);
                this.cmd.CommandType = System.Data.CommandType.Text;

                this.cmd.Parameters.AddWithValue("@DOC", contato.fDoc);
                this.cmd.Parameters.AddWithValue("@CODIGON", contato.fCodigon);
                this.cmd.Parameters.AddWithValue("@CONSULTOR", contato.fConsultor);
                this.cmd.Parameters.AddWithValue("@DATA", contato.fData);
                this.cmd.Parameters.AddWithValue("@CADASTRO", contato.fCadastro);
                this.cmd.Parameters.AddWithValue("@CONTATO", contato.fDecisor);
                this.cmd.Parameters.AddWithValue("@DDD", contato.fDDD);
                this.cmd.Parameters.AddWithValue("@TELEFONE", contato.fTelefone);
                this.cmd.Parameters.AddWithValue("@PROXIMO_CONTATO", contato.fProximoContato);
                this.cmd.Parameters.AddWithValue("@DOC_VISITA", contato.fVisita);
                this.cmd.Parameters.AddWithValue("@USUARIO", contato.fUsuario);
                this.cmd.Parameters.AddWithValue("@INATIVO", contato.fInativo);
                this.cmd.Parameters.AddWithValue("@OBS", contato.fObs);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    string msgAuditoria =  "Contato Gerado em: " + DateTime.Now.ToString() + Environment.NewLine;
                    cli.insertClientesAuditoria(fCodigon, UsuarioLogado.usuario.id, msgAuditoria);
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



    }
}
