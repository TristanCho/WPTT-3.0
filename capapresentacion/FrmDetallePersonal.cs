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
    public partial class FrmDetallePersonal : Form
    {
        bool esnuevo = false;
        bool eseditar = false;
        public string idpersonal = "";
        public FrmPrincipal frmparent;
        public FrmDetallePersonal()
        {
            InitializeComponent();
            habilitar(false);
            botonesVisible(false);
        }
        private void mensajeok(string mensaje)
        {
            MessageBox.Show(mensaje, "Detalle de Personal", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Detalle de Personal", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void limpiar()
        {
            this.txtIdPersonal.Text = string.Empty;
            this.cbProyecto.Items.Clear();
            this.cbTareaProyecto.Items.Clear();
            this.dtcreacion.Value = DateTime.Now;
            this.dtCierre.Value = DateTime.Now;
            this.txtTareaGrupo.Text = "";
            this.txtTareaOrigen.Text = "";
            this.txtTareaDestino.Text = "";
            this.txtDescripcion.Text = string.Empty;
            this.txtObservacionesTiempos.Text = string.Empty;            
        }
        private void habilitar(bool valor)
        {
            this.txtIdPersonal.ReadOnly = true;
            this.cbProyecto.Enabled = true;
            this.cbTareaProyecto.Enabled = valor;
            this.dtcreacion.Enabled = !valor;            
            this.dtCierre.Enabled = valor;
            this.txtTareaGrupo.ReadOnly = true;
            this.txtTareaOrigen.ReadOnly = true;
            this.txtTareaDestino.ReadOnly = true;
            this.txtDescripcion.ReadOnly = true;
            this.txtObservacionesTiempos.ReadOnly = true;
        }

        private void botonesVisible(bool estado)
        {
            btnGuardar.Visible = estado;
            btnCancelar.Visible = estado;
            btnEditar.Visible = !estado;
            btnNuevo.Visible = !estado;
            txtDescripcion.Enabled = estado;           
        }

        private void botones()
        {
            if (esnuevo || eseditar)
            {
                habilitar(true);
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = true;
                btnEditar.Enabled = false;
                btnCancelar.Enabled = true;
            }
            else
            {
                habilitar(false);
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
            }
        }

        internal void setBotonEliminar(bool value)
        {
            btnEliminarProyecto.Visible = value;
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            crearProyecto();
            btnEliminarProyecto.Visible = false;
        }

        public void crearProyecto()
        {
            esnuevo = true;
            txtDescripcion.Enabled = true;
            botonesVisible(true);
            setModo("CREACIÓN");
            botones();
            limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";               
              
                    if (esnuevo)
                    {
                    /*
                        rpta = NPersonal.insertarPersonal(
                            this.cbProyecto.Text.Trim(),
                            this.cbTareaProyecto.Text.Trim(),
                            this.txtDescripcion.Text.Trim(),
                            Convert.ToDateTime(this.dtcreacion.Value));
                    */
                    }
                    else
                    {
                    /*
                        rpta = NPersonal.editarPersonal(
                            Convert.ToInt32(this.txtIdPersonal.Text),
                           // this.txtTituloPersonal.Text.Trim(),
                           //this.txtcodigoProyecto.Text.Trim(),
                            this.txtDescripcion.Text.Trim(),
                            Convert.ToDateTime(this.dtcreacion.Value));
                    */
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (esnuevo)
                        {
                            this.mensajeok("Se ha creado el proyecto satisfactoriamente");
                            limpiar();

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

                    botonesVisible(false);
                    botones();
                    this.Hide();
                    FrmProyecto proyecto = new FrmProyecto();
                    FrmParent.frmparent.lanzarNuevoElemento(proyecto);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdPersonal.Text.Equals(""))
            {
                this.eseditar = true;
                this.botones();
                setModo("EDICIÓN");
                // txtObservacionesProyecto.Enabled = true;
                //txtDescripcionProyecto.Enabled = true;
                //this.txtDescripcionProyecto.Visible = true;
                botonesVisible(true);
            }
            else
            {
                this.mensajeerror("seleccione el registro a modificar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            esnuevo = false;
            this.eseditar = false;
            botones();
            botonesVisible(false);
            //limpiar();
            //this.Hide();
            setModo("LECTURA");
            this.Hide();
            //llamaVisualizaDatos();
        }
        private void btnEliminarProyecto_Click(object sender, EventArgs e)
        {

            if (!lEdicion.Text.Equals(""))
            {
                try
                {
                    DialogResult opcion;
                    opcion = MessageBox.Show("¿Desea continuar?", "Eliminar Proyecto", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcion == DialogResult.OK)
                    {

                        string rpta = "";

                        rpta = NProyecto.eliminarproyecto(Convert.ToInt32(txtIdPersonal.Text));

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

        public void visualizaDatos(string idTarea, string prioridad,string id_empleado,string EstadoTPersonal, string id_empleadoReAsign, string fcreacion, string fcierre,
             string idTareaGrupo, string idTareaOrigen, string idTareaDestino,string ProyectoPrincipal, string Aplicacion, string codigoTarea, string estadoTarea,string descripcion)
        {
            this.txtIdPersonal.Text = idTarea;
            this.cbProyecto.Text = ProyectoPrincipal;
            this.cbTareaProyecto.Text = codigoTarea;
            this.dtcreacion.Text = fcreacion;
            this.dtCierre.Text = fcierre;


        }
    
    }
}
