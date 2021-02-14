using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
namespace WindowsFormsApplication1
        
{
   class MeioProspeccao : ConexaoSQL
    {
        public int Codigo {get;set;}
        public string Nome { get; set; }

        public void SelectMeiosProspeccao(comercial ds)
        {
            string query = "SELECT [mei_CODIGO],[mei_NOME] FROM [dbo].[PROSPECCAO_MEIOS]  where mei_inativo = 0 order by mei_nome";

            this.cmd = new System.Data.SqlClient.SqlCommand(query, ConexaoAtiva);
            this.cmd.CommandType = System.Data.CommandType.Text;
            this.adp = new System.Data.SqlClient.SqlDataAdapter(this.cmd);

            ds.PROSPECCAO_MEIOS.Clear();
                        //preenche a tabela 'setores' dos dataset recebido por paramentro
            this.adp.Fill(ds.PROSPECCAO_MEIOS);
        }
    }
}
