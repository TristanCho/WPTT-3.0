using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capadatos
{
    public class DDetallePersonales
    {
        private string id_empleado;
        private string descripcion;
        private string fcreacion;
        private string prioridad;
        private string estado;
        private string fcierre;
        private string idTareaGrupo;
        private string idTareaDestino;
        private string idTareaOrigen;
        private string idTareaProyecto;
        private string idProyecto;
        private string id_empleadoInsert;
        private string id_empleadoReAsign;
        private string obsTiempos;
        
      

        public DDetallePersonales(string id_empleado, string descripcion, string fcreacion,
            string prioridad, string estado, string fcierre,
            string idTareaGrupo, string idTareaDestino, string idTareaOrigen, string idTareaProyecto,
            string idProyecto, string id_empleadoInsert, string id_empleadoReAsign, string obsTiempos)
        {
            this.id_empleado = id_empleado;
            this.descripcion = descripcion;
            this.fcreacion = fcreacion;
            this.prioridad = prioridad;
            this.estado = estado;
            this.fcierre = fcierre;
            this.idTareaGrupo = idTareaGrupo;
            this.idTareaDestino = idTareaDestino;
            this.idTareaOrigen = idTareaOrigen;
            this.idTareaProyecto = idTareaProyecto;
            this.idProyecto = idProyecto;
            this.id_empleadoInsert = id_empleadoInsert;
            this.id_empleadoReAsign = id_empleadoReAsign;
            this.obsTiempos = obsTiempos;
        }

        public string Id_empleado { get => id_empleado; set => id_empleado = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Fcreacion { get => fcreacion; set => fcreacion = value; }
        public string Prioridad { get => prioridad; set => prioridad = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Fcierre { get => fcierre; set => fcierre = value; }
        public string IdTareaGrupo { get => idTareaGrupo; set => idTareaGrupo = value; }
        public string IdTareaDestino { get => idTareaDestino; set => idTareaDestino = value; }
        public string IdTareaOrigen { get => idTareaOrigen; set => idTareaOrigen = value; }
        public string IdTareaProyecto { get => idTareaProyecto; set => idTareaProyecto = value; }
        public string IdProyecto { get => idProyecto; set => idProyecto = value; }
        public string Id_empleadoInsert { get => id_empleadoInsert; set => id_empleadoInsert = value; }
        public string Id_empleadoReAsign { get => id_empleadoReAsign; set => id_empleadoReAsign = value; }
        public string ObsTiempos { get => obsTiempos; set => obsTiempos = value; }
    }
}
