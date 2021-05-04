using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capadatos;

namespace capanegocio
{
    public class NTarea
    {
        public static DataTable buscartareaTitulo(String textobuscar)
        {
            DTarea objeto = new DTarea();
            objeto.Textobuscar = textobuscar;
            return objeto.buscartareaTitulo(objeto);
        }


        public static DataTable buscartareaProyecto(String textobuscar)
        {
            DTarea objeto = new DTarea();
            objeto.Textobuscar = textobuscar;
            return objeto.buscartareaProyecto(objeto);
        }


        public static DataTable buscartareaPrioridad(String textobuscar)
        {
            DTarea objeto = new DTarea();
            objeto.Textobuscar = textobuscar;
            return objeto.buscartareaPrioridad(objeto);
        }
        public static DataTable buscartareaAplicacion(String textobuscar)
        {
            DTarea objeto = new DTarea();
            objeto.Textobuscar = textobuscar;
            return objeto.buscartareaAplicacion(objeto);
        }
        public static DataTable buscartareaEstados(String textobuscar)
        {
            DTarea objeto = new DTarea();
            objeto.Textobuscar = textobuscar;
            return objeto.buscartareaEstados(objeto);
        }

        public static DataTable buscartareaDescripcion(String textobuscar)
        {
            DTarea objeto = new DTarea();
            objeto.Textobuscar = textobuscar;
            return objeto.buscartareaDescripcion(objeto);
        }
        public static DataTable mostrartareas()
        {
            DTarea objeto = new DTarea();
            return objeto.mostrartarea(objeto);
        }

        public static DataTable mostrarDetalleTiempos(String codigo_tarea)
        {
            DTarea objeto = new DTarea();
            return objeto.mostrarDetalleTiempos(codigo_tarea);
        }

        public static string eliminarTarea(int id)
        {
            DTarea objeto = new DTarea();
            //objeto.Id = id;

            return objeto.eliminarTarea(id);
        }

        public static string editarTarea(int id, string titulo, string descripcion, string observaciones, /*DateTime fecha,*/ string estado, string proyecto)
        {
            DTarea objeto = new DTarea();
            objeto.Id = id;
            objeto.Titulo = titulo;
            objeto.Proyecto = proyecto;
            objeto.Descripcion = descripcion;
            objeto.Observaciones = observaciones;
            objeto.Estado = estado;
           // objeto.Fecha = fecha;
           //objeto.Tecnico = tecnico;

            return objeto.editarTarea(objeto);
        }

        public static string insertartarea(/*int id,*/ string titulo, string descripcion, string observaciones, /*DateTime fecha,*/ string estado,  string proyecto)
        {
            DTarea objeto = new DTarea();
            //objeto.Id = id;
            objeto.Titulo = titulo;
            objeto.Proyecto = proyecto;
            objeto.Descripcion = descripcion;
            objeto.Observaciones = observaciones;
            objeto.Estado = estado;
            //objeto.Fecha = fecha;
            //objeto.Tecnico = tecnico;

            return objeto.insertartarea(objeto);
        }

        public static string[] mostrarProyectoCombobox()
        {
            DTarea objeto = new DTarea();

            return objeto.mostrarProyectoCombobox(objeto);
        }

        public static string[] mostrarEstadoCombobox()
        {
            DTarea objeto = new DTarea();
            return objeto.mostrarEstadoCombobox(objeto);
        }

        public static DetalleTareas getDetalleTareas(String codigo_tarea)
        {
            DTarea objeto = new DTarea();
             return objeto.getDetalleTareas(codigo_tarea);
        }

        public static string[] mostrarEstadoModulo()
        {
            DTarea objeto = new DTarea();
            return objeto.mostrarEstadoModulo(objeto);
        }        
        public static string[] mostrarPrioridad()
        {
            DTarea objeto = new DTarea();
            return objeto.mostrarPrioridad(objeto);
        }

        public static string[] mostrarTenicos()
        {
            DTarea objeto = new DTarea();
            return objeto.mostrarTenicos(objeto);
        }
    }
}
