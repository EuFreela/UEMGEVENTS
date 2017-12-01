using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uemgevent.classes
{
    class Usuarios
    {
        public int IdUsuarios { set; get; }
        public short Ativo { set; get; }
        public string Nome { set; get; }
        public string Email { set; get; }
        public string Username { set; get; }
        public string Passwd;
        public int perfilCodPerfil { set; get; }

    }
}
