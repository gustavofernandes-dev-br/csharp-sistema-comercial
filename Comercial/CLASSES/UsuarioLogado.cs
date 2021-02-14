using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WindowsFormsApplication1
{
    static class UsuarioLogado
    {
            //essa classe manterá uma instancia da classe usuario 
            //em todo tempo em execução do programa 
            //e é por isso que a classe e o atributo são STATIC . 
            //Dessa forma podemos a qualquer 
            //momento armazenar ou resgatar o valor contido no objeto
            //usuario sem a necessidade
            //de criar uma noca instacia
        public static UsuariosSistema usuario;
    }
}
