using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public static class Sistema
    {
        //Ainda não consegui colocar um enumerado publico
        //Colocando os códigos dos formularios aqui somente como referencia
        // Principal = 1
        // pesquisa clientes = 2
        // Clientes = 3
        // Prospeccao = 4
        // Contato = 5
        // Visita = 6
        // Proposta = 7
        // Contrato = 9
        // usuarios = 8
        


        public static String GeradoDoc()
        {
            string Doc = UsuarioLogado.usuario.id.ToString("000") + DateTime.Now.ToString("yyyyMMddHHmmssfff");
            
            
            return Doc;
        }




    }
}
