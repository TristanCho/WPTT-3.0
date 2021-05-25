using System;
using System.Linq;
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

        internal void mostrarDetallePersonal(DDetallePersonales dp)
        {

            MessageBox.Show("mostrarDetallePersonal");

            txtIdPersonal.Text = idpersonal;

            cbPrioridad.Items.Clear();
            cbPrioridad.Items.Add(dp.Prioridad);
            cbPrioridad.SelectedIndex = 0;

            cbProyecto.Items.Clear();
            cbProyecto.Items.Add(dp.IdProyecto);
            cbProyecto.SelectedIndex = 0;

            lblAplicacion.Text = dp.Aplicacion;

            lblEstadoTituloTarea.Text = dp.Titulo;//TODO estado + Titulo

            cbTareaProyecto.Items.Clear();
            cbTareaProyecto.Items.Add(dp.TareaProyecto);
            cbTareaProyecto.SelectedIndex = 0;

            cbTareaProyecto.Items.Clear();
            cbTareaProyecto.Items.Add(dp.EstadoTProyecto);
            cbTareaProyecto.SelectedIndex = 0;

            cbEmpleadoAsign.Items.Clear();
            cbEmpleadoAsign.Items.Add(dp.Id_empleado);
            cbEmpleadoAsign.SelectedIndex = 0;

            cbEmpleadoReAsign.Items.Clear();
            cbEmpleadoReAsign.Items.Add(dp.Id_empleadoReAsign);
            cbEmpleadoReAsign.SelectedIndex = 0;

            cbEstado.Items.Clear();
            cbEstado.Items.Add(dp.Estado);
            cbEstado.SelectedIndex = 0;

            dtcreacion.Text = dp.Fcreacion;
            dtCierre.Text = dp.Fcierre;

            cbTareaProyecto.Items.Clear();
            cbTareaProyecto.Items.Add(dp.TareaProyecto);
            cbTareaProyecto.SelectedIndex = 0;
             
            txtTareaGrupo.Text = dp.IdTareaGrupo;
            txtTareaOrigen.Text = dp.IdTareaOrigen;
            txtTareaDestino.Text = dp.IdTareaDestino;

            txtDescripcion.Text = dp.Descripcion;
            txtObservacionesTiempos.Text = dp.ObsTiempos;         

        }

        public DDetallePersonales getDetallePersonal(string idTarea)
        {
            return NPersonal.getDetallePersonal(idTarea);
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



     

        private void mostrarPrioridadCombobox()
        {
            cbPrioridad.Items.AddRange(NPersonal.mostrarPrioridad().ToArray());
            cbPrioridad.SelectedIndex = 0;
        }

        private void mostrarProyectosCombobox()
        {
            cbProyecto.Items.AddRange(NPersonal.mostrarProyectos().ToArray());
            cbProyecto.SelectedIndex = 0;          
        }

        private void mostrarTareaProyectoNullCombobox()
        {
            cbTareaProyecto.Items.AddRange(NPersonal.mostrarTareaProyectoNull().ToArray());
            cbTareaProyecto.SelectedIndex = 0;   
        }

        private void mostrarTareaProyectoCombobox()
        {
            cbTareaProyecto.Items.AddRange(NPersonal.mostrarTareaProyecto().ToArray());
            cbTareaProyecto.SelectedIndex = 0;
        }

        private void mostrarEmpleadosCombobox()
        {
            cbEmpleadoAsign.Items.AddRange(NPersonal.mostrarEmpleados().ToArray());
            cbEmpleadoReAsign.Items.AddRange(NPersonal.mostrarEmpleados().ToArray());
            cbEmpleadoAsign.SelectedIndex = 0;
            cbEmpleadoReAsign.SelectedIndex = 0;
        }

        private void mostrarEstadosCombobox()
        {
            cbEstado.Items.AddRange(NPersonal.mostrarEstados().ToArray());
            cbEstado.SelectedIndex = 0;
        }

        private void habilitar(bool valor)
        {
            this.txtIdPersonal.ReadOnly = true;
            this.cbProyecto.Enabled = true;
            this.cbTareaProyecto.Enabled = valor;
            this.dtcreacion.Enabled = !valor;            
            this.dtCierre.Enabled = valor;
            //this.txtTareaGrupo.ReadOnly = true;
            //this.txtTareaOrigen.ReadOnly = true;
           // this.txtTareaDestino.ReadOnly = true;
           //TODO Revisar el bloqueo de estos campos
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

        public void visualizaDatos(string idTarea, string prioridad, string idProyecto, string aplicacion,string tareaProyecto,string EstadoTProyecto, string titulo,
            string id_empleado, string id_empleadoReAsign, string estado, 
            string fcreacion, string fcierre, string idTareaGrupo, string idTareaOrigen, string idTareaDestino,
            string descripcion, string obsTiempos)
        {
            this.txtIdPersonal.Text = idTarea;
            this.cbPrioridad.Text = prioridad;
            this.cbProyecto.Text = idProyecto;
            this.lblAplicacion.Text = aplicacion;
            this.cbTareaProyecto.Text = tareaProyecto;
            this.cbEstado.Text = EstadoTProyecto;//TODO pendiente mostrar el titulo en FrmDetallePersonal
            this.lblEstadoTituloTarea.Text = titulo;
            this.cbEmpleadoAsign.Text = id_empleado;
            this.cbEmpleadoReAsign.Text = id_empleadoReAsign;
            this.cbEstado.Text = estado;
            this.dtcreacion.Text = fcreacion;
            this.dtCierre.Text = fcierre;
            this.txtTareaGrupo.Text = idTareaGrupo;
            this.txtTareaOrigen.Text = idTareaOrigen;
            this.txtTareaDestino.Text = idTareaDestino;
            this.txtDescripcion.Text = descripcion;
            this.txtObservacionesTiempos.Text = obsTiempos;   
        }


        ////////////////////////////CRISTHIAN/////////////////////////////////////////////

        public void rellenarComboboxes()
        {
            mostrarEstadosCombobox();
            mostrarProyectosCombobox();
            mostrarEmpleadosCombobox();
            mostrarPrioridadCombobox();
            //mostrarTareaProyectoCombobox();
            mostrarTareaProyectoNullCombobox();
            //mostrarModuloCombobox();
            //mostrarAplicacionCombobox();

            //mostrarTecnicos();
        }

        public void visualizaBotonesCambiarFormulario(bool value)
        {
            //btnAtras.Visible = value;
            //btnPrimero.Visible = value;
            // btnSiguiente.Visible = value;
            // btnFinal.Visible = value;
        }

        public void crearPersonal()
        {
            crearNuevo();
            rellenarComboboxes();
        }

        public void crearNuevo()
        {
            esnuevo = true;
            botonesVisible(true);
            setModo("CREACIÓN");
            botones();
            limpiar();
        }

        private void cbTareaProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Evento en cbTareaProyecto_SelectedIndexChanged");
        }
        public void mostrarTareaProyectoCombobox(string usuario, string tarea)
        {
            cbTareaProyecto.Items.AddRange(NPersonal.mostrarTareaProyectoCombobox(usuario, tarea).ToArray());
            //comboboxTareaPersonal.SelectedIndex = 0;

        }
        private void cbProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string s1 = cbProyecto.Text;
            MessageBox.Show(s1);
            if (s1 == "Sin asignar")
            {
                //MessageBox.Show("Es igual a Sin asignar");
                cbTareaProyecto.Items.AddRange(NPersonal.mostrarTareaProyectoNull().ToArray());
                //cbTareaProyecto.SelectedIndex = 0;
                //MessageBox.Show("en el if");
            }
            else
            {
                //mostrarTareaProyectoCombobox();
                cbTareaProyecto.Items.Clear();
                cbTareaProyecto.Items.AddRange(NPersonal.mostrarTareaProyecto().ToArray());
                cbTareaProyecto.SelectedIndex = 0;
                //// s1 = "blanco";
                //MessageBox.Show(s1);
                MessageBox.Show("Estoy en Else despues de mostrarTareaProyectoCombobox() L443 de FrmDetallePersonales");
            };
        }



        ////////////////////////////CRISTHIAN/////////////////////////////////////////////
    }
}
