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

        public static string eliminarTarea(string id)
        {
            DTarea objeto = new DTarea();
            //objeto.Id = id;

            return objeto.eliminarTarea(id);
        }

        public static string editarTarea(string id, string titulo, int tiempo_estimado,
            string proyecto, string prioridad,
            string estado, string aplicacion, string vdeteccion,
            string modulo, string referencias, string vsolucion,
            string historia,
            string descripcion,
            string solucion,
            string tdeteccion, string tsolucion, string tverificacion,
            DateTime fdeteccion, DateTime fsolucion, DateTime fverificacion)
        {
            DTarea objeto = new DTarea();
            objeto.Id = id;
            objeto.Titulo = titulo;
            objeto.TiempoEstimado = tiempo_estimado;
            objeto.Proyecto = proyecto;
            objeto.Prioridad = prioridad;
            objeto.Estado = estado;
            objeto.Aplicacion = aplicacion;
            objeto.Vdeteccion = vdeteccion;
            objeto.Modulo = modulo;
            objeto.Referencias = referencias;
            objeto.Vsolucion = vsolucion;
            objeto.Historia = historia;
            objeto.Descripcion = descripcion;
            objeto.Solucion = solucion;
            objeto.Tdeteccion = tdeteccion;
            objeto.Tsolucion = tsolucion;
            objeto.Tverificacion = tverificacion;
            objeto.Fechadeteccion = fdeteccion;
            objeto.Fechasolucion = fsolucion;
            objeto.Fechaverificacion = fverificacion;

            return objeto.editarTarea(objeto);
        }

        public static string insertartarea(string titulo,int tiempo_estimado,
            string proyecto, string prioridad,
            string estado,string aplicacion,string vdeteccion,
            string modulo,string referencias,string vsolucion,
            string historia,
            string descripcion,
            string solucion,
            string tdeteccion, string tsolucion, string tverificacion,
            DateTime fdeteccion, DateTime fsolucion, DateTime fverificacion)
        {
            DTarea objeto = new DTarea();

            objeto.Titulo = titulo;
            objeto.TiempoEstimado = tiempo_estimado;
            objeto.Proyecto = proyecto;
            objeto.Prioridad = prioridad;
            objeto.Estado = estado;
            objeto.Aplicacion = aplicacion;
            objeto.Vdeteccion = vdeteccion;
            objeto.Modulo = modulo;
            objeto.Referencias = referencias;
            objeto.Vsolucion = vsolucion;
            objeto.Historia = historia;
            objeto.Descripcion = descripcion;
            objeto.Solucion = solucion;
            objeto.Tdeteccion = tdeteccion;
            objeto.Tsolucion = tsolucion;
            objeto.Tverificacion = tverificacion;
            objeto.Fechadeteccion = fdeteccion;
            objeto.Fechasolucion = fsolucion;
            objeto.Fechaverificacion = fverificacion;


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

        public static DDetalleTareas getDetalleTareas(String codigo_tarea)
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
        public static string[] mostrarAplicacion()
        {
            DTarea objeto = new DTarea();
            return objeto.mostrarAplicaciones(objeto);
        }

        public static string[] mostrarTenicos()
        {
            DTarea objeto = new DTarea();
            return objeto.mostrarTenicos(objeto);
        }
    }
}
