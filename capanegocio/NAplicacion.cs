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

        public static string editarAplicacion(int id, string titulo, string descripcion)
        {
            DAplicacion objeto = new DAplicacion(id,titulo,descripcion);
            return objeto.editarAplicacion(objeto);
        }

        public static string eliminaraplicacion(int id)
        {
            DAplicacion objeto = new DAplicacion();
            objeto.Id = id;

            return objeto.eliminaraplicacion(id);
        }
    }
}
