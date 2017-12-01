using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uemgevent.classes
{
    class Eventos
    {
        public int IdEvento { set; get; }
        public string TituloEvento { set; get; }
        public DateTime DataEvento { set; get; }
        public string HInicio { set; get; }
        public string HFim { set; get; }
        public int Usuarios_IdUsuarios { set; get; }
        public int Palestrante_idPalestrante { set; get; }

    }
}
