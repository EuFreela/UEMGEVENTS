using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uemgevent.classes
{
    class Titulos
    {
        public int IdTitulos { set; get; }
        public string NomeInstituicaoTitulo { set; get; }
        public DateTime dataTitulo { set; get; }
        public int Titulacao_idTitulacao { set; get; }
        public int Palestrante_idPalestrante { set; get; }
        
    }
}
