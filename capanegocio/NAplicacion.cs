using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capadatos;

namespace capanegocio
{
    public class NAplicacion
    {
        public static DataTable mostraraplicacion()
        {
            DAplicacion objeto = new DAplicacion();
            return objeto.mostrarAplicaciones(objeto);
        }

        public static String insertarAplicacion( string titulo, string descripcion)
        {
            DAplicacion objeto = new DAplicacion(titulo, descripcion);
            return objeto.insertarAplicacion(objeto);
        }

        public static string editarAplicacion()
        {
            throw new NotImplementedException();
        }
    }
}
