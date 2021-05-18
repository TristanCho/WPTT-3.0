using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capadatos
{
    public class DDetallePersonales
    {
        private string idTarea;
        private string prioridad;
        private string idProyecto;
        private string aplicacion;
        private string estadoTProyect;
        private string titulo;        
        private string tareaProyecto;        
        private string id_empleado;
        private string id_empleadoReAsign;
        private string estado;
        private string fcreacion;
        private string fcierre;
        private string idTareaGrupo;
        private string idTareaOrigen;          
        private string idTareaDestino;
        private string descripcion;
        private string obsTiempos;


        public DDetallePersonales(string idTarea, string prioridad, string idProyecto, string aplicacion, string tareaProyecto,string estadoTProyect, string titulo,
            string id_empleado, string id_empleadoReAsign, string estado,
            string fcreacion, string fcierre, string idTareaGrupo, string idTareaOrigen, string idTareaDestino,
            string descripcion, string obsTiempos)
        {
            this.IdTarea = idTarea;
            this.Prioridad = prioridad;
            this.IdProyecto = idProyecto;
            this.Aplicacion = aplicacion;
            this.titulo = titulo;
            this.TareaProyecto = tareaProyecto;
            this.estadoTProyect = estadoTProyect;
            this.Id_empleado = id_empleado;
            this.Id_empleadoReAsign = id_empleadoReAsign;
            this.Estado = estado;
            this.Fcreacion = fcreacion;
            this.Fcierre = fcierre;
            this.IdTareaGrupo = idTareaGrupo;
            this.IdTareaOrigen = idTareaOrigen;
            this.IdTareaDestino = idTareaDestino;
            this.Descripcion = descripcion;
            this.ObsTiempos = obsTiempos;
        }

        public string IdTarea { get => idTarea; set => idTarea = value; }
        public string Prioridad { get => prioridad; set => prioridad = value; }
        public string IdProyecto { get => idProyecto; set => idProyecto = value; }
        public string Aplicacion { get => aplicacion; set => aplicacion = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string TareaProyecto { get => tareaProyecto; set => tareaProyecto = value; }
        public string EstadoTProyecto { get => estadoTProyect; set => estadoTProyect = value; }
        public string Id_empleado { get => id_empleado; set => id_empleado = value; }
        public string Id_empleadoReAsign { get => id_empleadoReAsign; set => id_empleadoReAsign = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Fcreacion { get => fcreacion; set => fcreacion = value; }
        public string Fcierre { get => fcierre; set => fcierre = value; }
        public string IdTareaGrupo { get => idTareaGrupo; set => idTareaGrupo = value; }
        public string IdTareaOrigen { get => idTareaOrigen; set => idTareaOrigen = value; }
        public string IdTareaDestino { get => idTareaDestino; set => idTareaDestino = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string ObsTiempos { get => obsTiempos; set => obsTiempos = value; }
    }
}
