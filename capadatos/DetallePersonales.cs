using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capadatos
{
    public class DetallePersonales
    {
        private string titulo;
        private string referencias;
        private string codigo;
        private string proyecto;
        private string tiempo_estimado;
        private string aplicacion;
        private string estado;
        private string prioridad;
        private string modulo;
        private string vDeteccion;
        private string vSolucion;
        private string descripcion;
        private string solucion;
        private string tDeteccion;
        private string tSolucion;
        private string tVerificacion;
        private string fDeteccion;
        private string fSolucion;
        private string fVerificacion;
        private string historia;

        public DetallePersonales(string titulo, string referencias, string codigo,
            string proyecto, string prioridad, string tiempo_estimado,
            string estado, string aplicacion, string modulo, string vDeteccion,
            string vSolucion, string historia, string descripcion, string solucion,
            string tDeteccion, string tSolucion, string tVerificacion,
            string fDeteccion, string fSolucion,
            string fVerificacion)
        {
            this.titulo = titulo;
            this.referencias = referencias;
            this.codigo = codigo;
            this.proyecto = proyecto;
            this.tiempo_estimado = tiempo_estimado;
            this.aplicacion = aplicacion;
            this.estado = estado;
            this.prioridad = prioridad;
            this.modulo = modulo;
            this.vDeteccion = vDeteccion;
            this.vSolucion = vSolucion;
            this.descripcion = descripcion;
            this.solucion = solucion;
            this.tDeteccion = tDeteccion;
            this.tSolucion = tSolucion;
            this.tVerificacion = tVerificacion;
            this.fDeteccion = fDeteccion;
            this.fSolucion = fSolucion;
            this.fVerificacion = fVerificacion;
            this.historia = historia;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Referencias { get => referencias; set => referencias = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Proyecto { get => proyecto; set => proyecto = value; }
        public string Tiempo_estimado { get => tiempo_estimado; set => tiempo_estimado = value; }
        public string Aplicacion { get => aplicacion; set => aplicacion = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Prioridad { get => prioridad; set => prioridad = value; }
        public string Modulo { get => modulo; set => modulo = value; }
        public string VDeteccion { get => vDeteccion; set => vDeteccion = value; }
        public string VSolucion { get => vSolucion; set => vSolucion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Solucion { get => solucion; set => solucion = value; }
        public string TDeteccion { get => tDeteccion; set => tDeteccion = value; }
        public string TSolucion { get => tSolucion; set => tSolucion = value; }
        public string TVerificacion { get => tVerificacion; set => tVerificacion = value; }
        public string FDeteccion { get => fDeteccion; set => fDeteccion = value; }
        public string FSolucion { get => fSolucion; set => fSolucion = value; }
        public string FVerificacion { get => fVerificacion; set => fVerificacion = value; }
        public string Historia { get => historia; set => historia = value; }
    }
}
