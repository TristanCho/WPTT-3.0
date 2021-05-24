using System;
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

        public static DataTable buscarpersonales(String textobuscar)
        {
            DPersonal objeto = new DPersonal();
            objeto.TextoBuscar = textobuscar;
            return objeto.buscarpersonales(objeto);
        }

        public static DDetallePersonales getDetallePersonal(String idTarea)
        {
            DPersonal objeto = new DPersonal();
            return objeto.getDetallePersonal(idTarea);
        }              

        public static string insertarPersonal(string id_empleado, string descripcion, string fcreacion, string prioridad, string estado, string fcierre,
            string idTareaGrupo, string idTareaDestino, string idTareaOrigen, string idTareaProyecto, string idProyecto, string id_empleadoInsert, string id_empleadoReAsign )
        {
            DPersonal objeto = new DPersonal();
                        
            objeto.Id_empleado = id_empleado;
            objeto.Descripcion = descripcion;
            objeto.Fcreacion = fcreacion;
            objeto.Prioridad = prioridad;
            objeto.Estado = estado;
            objeto.Fcierre = fcierre;
            objeto.IdTareaGrupo = idTareaGrupo;
            objeto.IdTareaDestino = idTareaDestino;
            objeto.IdTareaOrigen = idTareaOrigen;
            objeto.IdTareaProyecto = idTareaProyecto;
            objeto.IdProyecto = idProyecto;
            objeto.Id_empleadoInsert = id_empleadoInsert;
            objeto.Id_empleadoReAsign = id_empleadoReAsign;

            return objeto.insertarPersonal(objeto);
        }


        public static string editartarPersonal(string idTarea,string id_empleado, string descripcion, string fcreacion, string prioridad, string estado, string fcierre,
            string idTareaGrupo, string idTareaDestino, string idTareaOrigen, string idTareaProyecto, string idProyecto, string id_empleadoInsert, string id_empleadoReAsign)
        {
            DPersonal objeto = new DPersonal();

            objeto.IdTarea = idTarea;
            objeto.Id_empleado = id_empleado;
            objeto.Descripcion = descripcion;
            objeto.Fcreacion = fcreacion;
            objeto.Prioridad = prioridad;
            objeto.Estado = estado;
            objeto.Fcierre = fcierre;
            objeto.IdTareaGrupo = idTareaGrupo;
            objeto.IdTareaDestino = idTareaDestino;
            objeto.IdTareaOrigen = idTareaOrigen;
            objeto.IdTareaProyecto = idTareaProyecto;
            objeto.IdProyecto = idProyecto;
            objeto.Id_empleadoInsert = id_empleadoInsert;
            objeto.Id_empleadoReAsign = id_empleadoReAsign;

            return objeto.editarPersonal(objeto);
        }

        public static string eliminarPersonal(string idTarea)
        {
            DPersonal objeto = new DPersonal();
            objeto.IdTarea = idTarea;

            return objeto.eliminarPersonal(objeto);         
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


       
        public static string[] mostrarPrioridad()
        {
            DPersonal objeto = new DPersonal();
            return objeto.mostrarPrioridadCombobox(objeto);
        }

        public static string[] mostrarTareaProyectoNull()
        {
            DPersonal objeto = new DPersonal();          
            return objeto.mostrarTareaProyectoNullCombobox(objeto);
        }

        public static string[] mostrarTareaProyecto()
        {
            DPersonal objeto = new DPersonal();
            return objeto.mostrarTareaProyectoCombobox(objeto);
        }

        public static string[] mostrarProyectos()
        {
            DPersonal objeto = new DPersonal();
            return objeto.mostrarProyectoCombobox(objeto);
        }

        public static string[] mostrarEmpleados()
        {
            DPersonal objeto = new DPersonal();
            return objeto.mostrarEmpleadosCombobox(objeto);
        }

        public static string[] mostrarEstados()
        {
            DPersonal objeto = new DPersonal();
            return objeto.mostrarEstadosCombobox(objeto);
        }

        //mostrarEstados



    }
}
