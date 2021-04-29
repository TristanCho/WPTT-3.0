using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capadatos;

namespace capanegocio
{
   
    public class NLogin
    {        
        public void informacionLogin(String usuario,String conexionBD)
        {
            DLoginStatico.usuario = usuario;
            DLoginStatico.conexionBD = conexionBD;
            DLoginStatico.sacaTecnico(usuario);            
        }

        public bool logueo(string usuario, string hostname)
        {
            DLogin login = new DLogin(usuario,hostname);
           // login.Hostname = hostname;
           // login.Usuario = usuario;
            return login.login();
        }
    }
}
