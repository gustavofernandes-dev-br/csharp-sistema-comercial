using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class ConexaoBanco
    {
        public static SqlConnection conn = null;

        public void ConexaoString()
        {
            //local
           // conn = new SqlConnection("Data Source=GUSTAVO-PC\\PDVNET;Initial Catalog=BDGUSTAVO;User id=sa;Password=inter#system");
            
           conn = new SqlConnection("Data Source=200.98.141.69,60705\\CLIENTES;Initial Catalog=BDGUSTAVO;User id=gustavo;Password=gus123456");
            conn.Open();
        }
    }
}
