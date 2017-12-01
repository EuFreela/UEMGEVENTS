using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uemgevent.classes
{
    class Login
    {
        private List<Usuarios> LU;
        private DBO DBO;
        Hash hw;
        public string Username { set; get; }
        public string Passwd { set; get; }
        public int Perfil { set; get; }
        public int idUsuario { set; get; }


        public Login()
        {
            DBO = new DBO();
            LU = new List<Usuarios>(DBO.SelectFromAll("usuarios"));
            hw = new Hash();
        }

        public Boolean ValidarUsuario(string username, string passwd)
        {
            Boolean r = false;
            this.Username = username;
            this.Passwd = passwd;
            this.hw.SetValueHash( this.Passwd );            
            this.LU.ForEach( delegate(Usuarios user)
            {
                if ((this.hw.GetValueHash() == user.Passwd) && (this.Username == user.Username))
                {
                    r = true;
                    this.Perfil = user.perfilCodPerfil;
                    this.idUsuario = user.IdUsuarios;
                }
            });
            return r;
        }        


    }
}
