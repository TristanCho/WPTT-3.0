using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capadatos;
using System.Data;

namespace capanegocio
{
    public class NTiempo
    {

        public static DataTable mostrartiempos()
        {
            DTiempo objeto = new DTiempo();
            return objeto.mostrartiempos(objeto);
        }

        public static DataTable buscartiempo(String textobuscar)
        {
            DTiempo objeto = new DTiempo();
            objeto.Textobuscar = textobuscar;
            return objeto.buscartiempo(objeto);
        }

        //TODO cambiar el id_Tarea para que reciba un string desde la entrada de datos
        public static string insertartiempo(string fecha,string fechaInicio,string fechaFin,string observaciones,string accion,string id_tarea,
            string idTareaPersonal,
            string usuario,int imputable,int imputado)
        {
            DTiempo objeto = new DTiempo(fecha,  fechaInicio,  fechaFin,  observaciones,  accion,  id_tarea,
             idTareaPersonal,  usuario,  imputable,  imputado);


            return objeto.insertartiempo(objeto);
        }

        public static string editartiempo(string id,string fecha, string fechaInicio, string fechaFin, string observaciones, string accion, string id_tarea,
            string idTareaPersonal,
            string usuario, int imputable, int imputado)
        {
            DTiempo objeto = new DTiempo(fecha, fechaInicio, fechaFin, observaciones, accion, id_tarea,
            idTareaPersonal, usuario, imputable, imputado);
            objeto.Id = Convert.ToInt32(id);
            return objeto.editartiempo(objeto);
        }

        public static string eliminartiempo(int id)
        {
            DTiempo objeto = new DTiempo();
            objeto.Id = id;

            return objeto.eliminartiempo(objeto);
        }

        public static string[] mostrarTareaCombobox()
        {
            DTiempo objeto = new DTiempo();

            return objeto.mostrarTareaCombobox(objeto);
        }

        public static string[] mostrarTareaPersonalCombobox(string usuario, string tarea)
        {
            DTiempo objeto = new DTiempo();

            return objeto.mostrarTareaPersonalCombobox(usuario,tarea);
        }
    }
}
