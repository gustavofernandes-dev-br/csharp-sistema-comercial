using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class clsVisita:ConexaoSQL
    {
        public String fDoc { get; set; }
        public String fCodigon { get; set; }
        public int fConsultor { get; set; }
        public DateTime fDataVisita { get; set; }
        public DateTime fCadastro { get; set; }
        public string fObs { get; set; }
        public string fEndereco { get; set; }
        public int fUsuario { get; set; }
        public bool fInativo { get; set; }
        public DateTime fAtualização { get; set; }
        public DateTime fGoogle { get; set; }
    }







}
