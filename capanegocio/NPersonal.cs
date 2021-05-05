using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capadatos;
using System.Data;

namespace capanegocio
{
  public class NPersonal
    {
        public static DataTable mostrarpersonales()
        {
            DPersonal objeto = new DPersonal();
            return objeto.mostrarpersonales(objeto);
        }

        public static DataTable buscarproyecto(String textobuscar)
        {
            DProyecto objeto = new DProyecto();
            objeto.Textobuscar = textobuscar;
            return objeto.buscarproyecto(objeto);
        }
        public static string insertarproyecto(string titulo, string codigo_proyecto, string observaciones, DateTime fecha)
        {
            DProyecto objeto = new DProyecto();
            objeto.Titulo = titulo;
            objeto.Observaciones = observaciones;
            objeto.Fecha = fecha;
            objeto.Codigo_proyecto = codigo_proyecto;

            return objeto.insertarproyecto(objeto);
        }

        public static string editarproyecto(int id, string titulo, string codigo_proyecto, string observaciones, DateTime fecha)
        {
            DProyecto objeto = new DProyecto();
            objeto.Id = id;
            objeto.Titulo = titulo;
            objeto.Observaciones = observaciones;
            objeto.Codigo_proyecto = codigo_proyecto;
            objeto.Fecha = fecha;

            return objeto.editarproyecto(objeto);
        }

        public static string eliminarproyecto(int id)
        {
            DProyecto objeto = new DProyecto();
            objeto.Id = id;

            return objeto.eliminarproyecto(objeto);
        }



        public static DProyectoDatos siguienteInforme(String textobuscar)
        {
            DProyecto objeto = new DProyecto();
            objeto.Textobuscar = textobuscar;
            return objeto.siguienteInforme(objeto);
        }

        public static DProyectoDatos anteriorInforme(String textobuscar)
        {
            DProyecto objeto = new DProyecto();
            objeto.Textobuscar = textobuscar;
            return objeto.anteriorInforme(objeto);
        }
    }
}
