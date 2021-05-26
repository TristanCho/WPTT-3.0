using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capadatos;
using capanegocio;
using WPTT_1._0;

namespace capapresentacion
{
    public partial class FrmDetalleProyecto : Form
    {
        bool esnuevo = false;
        bool eseditar = false;
        public string idproyecto = "";
        public string npaginas = "";
        public FrmPrincipal frmparent;
        public FrmDetalleProyecto()
        {
            InitializeComponent();
            habilitar(false);
        }
        public void guardarProyecto()
        {

            try
            {
                string rpta = "";
                if (this.txtTituloProyecto.Text == string.Empty)
                {
                    mensajeerror("Formulario incompleto");
                    this.iconoerror.SetError(this.txtTituloProyecto, "Ingresar Título");
                }
                else
                {
                    if (esnuevo)
                    {
                        rpta = NProyecto.insertarproyecto(
                            this.txtTituloProyecto.Text.Trim(),
                           this.txtcodigoProyecto.Text.Trim(),
                            this.txtObservacionesProyecto.Text.Trim(),
                            Convert.ToDateTime(this.dtFechaProyecto.Value));
                    }
                    else
                    {

                        rpta = NProyecto.editarproyecto(
                            Convert.ToInt32(this.txtIdProyecto.Text),
                            this.txtTituloProyecto.Text.Trim(),
                           this.txtcodigoProyecto.Text.Trim(),
                            this.txtObservacionesProyecto.Text.Trim(),
                            Convert.ToDateTime(this.dtFechaProyecto.Value));
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (esnuevo)
                        {
                            this.mensajeok("Se ha creado el proyecto satisfactoriamente");
                            bloqueaProyecto();
                        }
                        else
                        {
                            this.mensajeok("Se ha editado el proyecto satisfactoriamente");
                            limpiar();
                        }

                    }
                    else
                    {
                        this.mensajeerror(rpta);
                    }

                    FrmParent.frmparent.AbrirFormulario(new FrmProyecto());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.StackTrace);
            }

        }


        private void mensajeok(string mensaje)
        {
            MessageBox.Show(mensaje, "Detalle de Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Detalle de Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void limpiar()
        {
            this.txtIdProyecto.Text = string.Empty;
            this.txtTituloProyecto.Text = string.Empty;
            this.txtObservacionesProyecto.Text = string.Empty;
            txtcodigoProyecto.Text = string.Empty;
            this.dtFechaProyecto.Text = string.Empty;
        }
        public void habilitar(bool valor)
        {

            this.txtIdProyecto.ReadOnly = true;
            this.txtcodigoProyecto.ReadOnly = true;
            this.txtTituloProyecto.ReadOnly = !valor;
            this.txtObservacionesProyecto.Enabled = valor;
            this.dtFechaProyecto.Enabled = valor;

        }

        private void FrmDetalleProyecto_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarX);
        }

        private void cerrarX(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            this.Hide();
            frmPrincipal.Show();
        }

        public void setModo(String modo)
        {
            lEdicion.Text = "[MODO " + modo + "]";
        }

        public void nuevoClicado()
        {
            crearProyecto();
        }
        public void bloqueaProyecto()
        {
            txtObservacionesProyecto.Enabled = false;
            txtTituloProyecto.ReadOnly = true;
            dtFechaProyecto.Enabled = false;
            llamaVisualizaDatos();
        }
        public void crearProyecto()
        {
            esnuevo = true;
            txtObservacionesProyecto.Enabled = true;
            txtTituloProyecto.ReadOnly = false;
            dtFechaProyecto.Enabled = true;
            setModo("CREACIÓN");
            limpiar();
        }

        public void editarProyecto()
        {
            if (!this.txtIdProyecto.Text.Equals(""))
            {
                this.eseditar = true;
                esnuevo = false;
                setModo("EDICIÓN");
                habilitar(true);
            }
            else
            {
                this.mensajeerror("seleccione el registro a modificar");
            }
        }

        public void botonEliminarProyecto()
        {
            if (!lEdicion.Text.Equals("[MODO EDICIÓN]") && !lEdicion.Text.Equals("[MODO CREACIÓN]"))
            {
                try
                {
                    DialogResult opcion;
                    opcion = MessageBox.Show("¿Desea continuar?", "Eliminar Proyecto", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcion == DialogResult.OK)
                    {

                        string rpta = "";

                        rpta = NProyecto.eliminarproyecto(Convert.ToInt32(txtIdProyecto.Text));

                        if (rpta.Equals("OK"))
                        {
                            this.mensajeok("Registro eliminado");
                            FrmParent.frmparent.AbrirFormulario(new FrmProyecto());
                        }
                        else
                        {
                            this.mensajeerror("¡Ups!, Al parecer tienes tareas asignadas a este proyecto...");
                            this.mensajeerror(rpta);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        public void visualizaDatos(string id, string codigo_proyecto, string proyecto, string observaciones, string fecha_creacion)
        {
            this.txtIdProyecto.Text = id;
            this.txtTituloProyecto.Text = proyecto;
            this.txtObservacionesProyecto.Text = observaciones;
            this.txtcodigoProyecto.Text = codigo_proyecto;
            //this.txtDescripcionProyecto.Text = descripcion;
            this.dtFechaProyecto.Text = fecha_creacion;
        }


        public void llamaVisualizaDatos()
        {

            visualizaDatos(
                Convert.ToString(DInformacionProyecto.dataListProyectos.Rows[DInformacionProyecto.index].Cells["id"].Value),
                Convert.ToString(DInformacionProyecto.dataListProyectos.Rows[DInformacionProyecto.index].Cells["codigo_proyecto"].Value),
                Convert.ToString(DInformacionProyecto.dataListProyectos.Rows[DInformacionProyecto.index].Cells["titulo"].Value),
                Convert.ToString(DInformacionProyecto.dataListProyectos.Rows[DInformacionProyecto.index].Cells["observaciones"].Value),
                Convert.ToString(DInformacionProyecto.dataListProyectos.Rows[DInformacionProyecto.index].Cells["fecha"].Value));

        }
        public void botonSiguiente()
        {
            DInformacionProyecto.sumaIndex();
            llamaVisualizaDatos();
        }

        public void botonAtras()
        {
            DInformacionProyecto.restaIndex();
            llamaVisualizaDatos();
        }

        public void botonUltimo()
        {
            DInformacionProyecto.finalIndex();
            llamaVisualizaDatos();
        }

        public void botonPrimero()
        {
            DInformacionProyecto.primerIndex();
            llamaVisualizaDatos();
        }

        public void volver()
        {
            this.Close();
            FrmParent.frmparent.AbrirFormulario(new FrmProyecto());
        }
    }

}
