using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uemgevent.classes
{
    class Interface_has_Palestrante_InfoPalestrante_Titulos_Estados
    {        
        public Palestrante Palestrante { set; get; }
        public Titulacao Titulacao { set; get; }
        public Titulos Titulos { set; get; }
        public InfoPalestrante InfoPalestrante { set; get; }
        public Estados Estados { set; get; }

        public Interface_has_Palestrante_InfoPalestrante_Titulos_Estados()
        {
            this.Palestrante = new Palestrante();
            this.Titulacao = new Titulacao();
            this.Titulos = new Titulos();
            this.InfoPalestrante = new InfoPalestrante();
            this.Estados = new Estados();
        }

    }
}
