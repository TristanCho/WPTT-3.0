using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class FrmDetalleTarea : Form
    {

        bool esnuevo = false;
        bool eseditar = false;
        
        public FrmDetalleTarea()
        {
            InitializeComponent();
            botonesVisible(false);
            habilitar(false);
        }

        public void mostrarProyectoCombobox()
        {
            comboboxProyecto.Items.AddRange(NTarea.mostrarProyectoCombobox().ToArray());
            comboboxProyecto.SelectedIndex = 0;

        }

        public void mostrarEstadoCombobox()
        {
            comboboxEstado.Items.AddRange(NTarea.mostrarEstadoCombobox().ToArray());
            comboboxEstado.SelectedIndex = 0;
        }


        public void setTecnico()
        {
            //lTecnico.Text = DLoginStatico.tecnico;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdTarea.Text.Equals(""))
            {
                this.eseditar = true;
                this.botones();
                setModo("EDICION");
                botonesVisible(true);
                visualizaBotonesCambiarFormulario(false);
                rellenarComboboxes();
            }
            else
            {
                this.mensajeerror("selleccione el registro a modificar");
            }
        }

        public void visualizaBotonesCambiarFormulario(bool value)
        {
            btnAtras.Visible = value;
            btnPrimero.Visible = value;
            btnSiguiente.Visible = value;
            btnFinal.Visible = value;
        }

        private void botonesVisible(bool estado)
        {
            btnGuardar.Visible = estado;
            btnCancelar.Visible = estado;

            btnEditar.Visible = !estado;
            btnNuevo.Visible = !estado;
        }

        public void crearTarea()
        {
            crearNuevo();
            rellenarComboboxes();

        }

        internal void setBotonEliminar(bool value)
        {
            btnEliminarProyecto.Visible = value;
        }

        public void visualizaDatos(string id, string proyecto, string tarea, string descripcion, 
            string observaciones, string fecha_creacion, string estado)
        {
            txtIdTarea.Text = id;
            txtTituloTarea.Text = tarea;
            comboboxProyecto.SelectedIndex = comboboxProyecto.FindStringExact(proyecto);
            txtDescripcionTarea.Text = descripcion;
            txtResolucion.Text = observaciones;
            //dtFechaTarea.Text = fecha_creacion;
            comboboxEstado.SelectedIndex = comboboxEstado.FindStringExact(estado);
           
        }

        private void habilitar(bool valor)
        {
           // this.txtIdTarea.ReadOnly = false;
            this.txtDescripcionTarea.ReadOnly = !valor;
            this.txtTituloTarea.ReadOnly = !valor;
            this.comboboxEstado.Enabled = valor;
            this.comboboxProyecto.Enabled = valor;
            txtResolucion.ReadOnly = !valor;
            txtHistoria.ReadOnly = !valor;
            txtEstimado.ReadOnly = !valor;
            comboboxPrioridad.Enabled = valor;
            comboboxAplicacion.Enabled = valor;
            comboboxModulo.Enabled = valor;
            txtDeteccion.ReadOnly = !valor;
            txtReferencia.ReadOnly = !valor;
            txtVSolucion.ReadOnly = !valor;
            dtFDeteccion.Enabled = valor;
            dtFSolucion.Enabled = valor;
            dtFVerificacion.Enabled = valor;
            comboboxTDeteccion.Enabled = valor;
            comboboxSolucion.Enabled = valor;
            comboboxTVerificacion.Enabled = valor;
        }

        private void FrmDetalleTarea_Load(object sender, EventArgs e)
        {

        }
        public void prueballamada()
        {
            Console.WriteLine("prueba de llamada");
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            crearNuevo();
            rellenarComboboxes();
 
        }

        public void rellenarComboboxes()
        {
            mostrarProyectoCombobox();
            mostrarEstadoCombobox();
            mostrarModuloCombobox();
            mostrarAplicacionCombobox();
            mostrarPrioridadCombobox();
            mostrarTecnicos();
        }

        private void mostrarTecnicos()
        {
            comboboxTDeteccion.Items.AddRange(NTarea.mostrarTenicos().ToArray());
            comboboxTDeteccion.SelectedIndex = 0;

            comboboxSolucion.Items.AddRange(NTarea.mostrarTenicos().ToArray());
            comboboxSolucion.SelectedIndex = 0;

            comboboxTVerificacion.Items.AddRange(NTarea.mostrarTenicos().ToArray());
            comboboxTVerificacion.SelectedIndex = 0;
        }

        private void mostrarPrioridadCombobox()
        {
            comboboxPrioridad.Items.AddRange(NTarea.mostrarPrioridad().ToArray());
            comboboxPrioridad.SelectedIndex = 0;
        }

        private void mostrarAplicacionCombobox()
        {
            comboboxAplicacion.Items.AddRange(NTarea.mostrarAplicacion().ToArray());
            comboboxAplicacion.SelectedIndex = 0;
        }

        private void mostrarModuloCombobox()
        {
            comboboxModulo.Items.AddRange(NTarea.mostrarEstadoModulo().ToArray());
            comboboxModulo.SelectedIndex = 0;
        }

        public void crearNuevo() {
            esnuevo = true;
            botonesVisible(true);
            setModo("CREACIÓN");
            botones();
            limpiar();
        }
        public void setModo(String modo)
        {
            lEdicion.Text = "[MODO " + modo + "]";
        }
        private void botones()
        {
            if (esnuevo || this.eseditar)
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

        private void limpiar()
        {
            txtTituloTarea.Text = string.Empty;
            txtReferencia.Text = string.Empty;
            txtIdTarea.Text = string.Empty;
            comboboxProyecto.Items.Clear();
            //txtEstimado.Text = string.Empty;
            comboboxPrioridad.Items.Clear();
            comboboxEstado.Items.Clear();
            comboboxAplicacion.Items.Clear();
            txtDeteccion.Text = string.Empty;
            comboboxModulo.Items.Clear();
            txtDeteccion.Text = string.Empty;
            txtReferencia.Text = string.Empty;
            txtVSolucion.Text = string.Empty;
            txtHistoria.Text = string.Empty;
            txtDescripcionTarea.Text = string.Empty;
            txtResolucion.Text = string.Empty;
            comboboxTDeteccion.Items.Clear();
            comboboxSolucion.Items.Clear();
            comboboxTVerificacion.Items.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lectura();
        }

        public void lectura()
        {
            esnuevo = false;
            this.eseditar = false;
            botones();
            botonesVisible(false);
            //limpiar();
            this.Hide();
            setModo("LECTURA");
            //llamaVisualizaDatos();
        }

        internal void mostrarDetalleTareas(DDetalleTareas tarea)
        {
            txtTituloTarea.Text = tarea.Titulo;
            txtReferencia.Text = tarea.Referencias;
            txtIdTarea.Text = tarea.Codigo;

            comboboxProyecto.Items.Clear();
            comboboxProyecto.Items.Add(tarea.Proyecto);
            comboboxProyecto.SelectedIndex = 0;

            txtEstimado.Text = tarea.Tiempo_estimado;

            comboboxPrioridad.Items.Clear();
            comboboxPrioridad.Items.Add(tarea.Prioridad);
            comboboxPrioridad.SelectedIndex = 0;

            comboboxEstado.Items.Clear();
            comboboxEstado.Items.Add(tarea.Estado);
            comboboxEstado.SelectedIndex = 0;


            comboboxAplicacion.Items.Clear();
            comboboxAplicacion.Items.Add(tarea.Aplicacion);
            comboboxAplicacion.SelectedIndex = 0;

            txtDeteccion.Text = tarea.TDeteccion;

            comboboxModulo.Items.Clear();
            comboboxModulo.Items.Add(tarea.Modulo);
            comboboxModulo.SelectedIndex = 0;

            txtDeteccion.Text = tarea.VDeteccion;

            txtReferencia.Text = tarea.Referencias;
            txtVSolucion.Text = tarea.VSolucion;
            txtHistoria.Text = tarea.Historia;

            txtDescripcionTarea.Text = tarea.Descripcion;
            txtResolucion.Text = tarea.Solucion;

            comboboxTDeteccion.Items.Clear();
            comboboxTDeteccion.Items.Add(tarea.TDeteccion);
            comboboxTDeteccion.SelectedIndex = 0;

            comboboxSolucion.Items.Clear();
            comboboxSolucion.Items.Add(tarea.TSolucion);
            comboboxSolucion.SelectedIndex = 0;

            comboboxTVerificacion.Items.Clear();
            comboboxTVerificacion.Items.Add(tarea.TVerificacion);
            comboboxTVerificacion.SelectedIndex = 0;

            dtFDeteccion.Text = tarea.FDeteccion;
            dtFSolucion.Text = tarea.FSolucion;
            dtFVerificacion.Text = tarea.FVerificacion;



        }

        public DDetalleTareas getDetalleTareas(string codigo_tarea)
        {
           return NTarea.getDetalleTareas(codigo_tarea);
        }

        private void mensajeok(string mensaje)
        {
            MessageBox.Show(mensaje, "Detalle de Tarea", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Detalle de Tarea", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            try
            {
                string rpta = "";

                if (this.txtTituloTarea.Text == string.Empty)
                {
                    mensajeerror("Formulario incompleto");
                    //this.iconoerror.SetError(this.txtTituloTarea, "Ingresar Título");
                }
                else
                {
                    if (esnuevo)
                    {
                        rpta = NTarea.insertartarea(
                            txtTituloTarea.Text,
                            Convert.ToInt32(txtEstimado.Text),
                            this.comboboxProyecto.SelectedItem.ToString(),
                            comboboxPrioridad.SelectedItem.ToString(),
                            comboboxEstado.SelectedItem.ToString(),
                            comboboxAplicacion.SelectedItem.ToString(),
                            txtDeteccion.Text,
                            comboboxModulo.SelectedItem.ToString(),
                            txtReferencia.Text,
                            txtVSolucion.Text,
                            txtHistoria.Text,
                            txtDescripcionTarea.Text,
                            txtResolucion.Text,
                            comboboxTDeteccion.SelectedItem.ToString(),
                            comboboxSolucion.SelectedItem.ToString(),
                            comboboxTVerificacion.SelectedItem.ToString(),
                             Convert.ToDateTime(dtFDeteccion.Value),
                             Convert.ToDateTime(dtFSolucion.Value),
                             Convert.ToDateTime(dtFVerificacion.Value)
                            );
                    }
                    else
                    {
                        //TODO falta por acabar, salta error
                        rpta = NTarea.editarTarea(
                            this.txtIdTarea.Text,
                            txtTituloTarea.Text,
                            Convert.ToInt32(txtEstimado.Text),
                            this.comboboxProyecto.SelectedItem.ToString(),
                            comboboxPrioridad.SelectedItem.ToString(),
                            comboboxEstado.SelectedItem.ToString(),
                            comboboxAplicacion.SelectedItem.ToString(),
                            txtDeteccion.Text,
                            comboboxModulo.SelectedItem.ToString(),
                            txtReferencia.Text,
                            txtVSolucion.Text,
                            txtHistoria.Text,
                            txtDescripcionTarea.Text,
                            txtResolucion.Text,
                            comboboxTDeteccion.SelectedItem.ToString(),
                            comboboxSolucion.SelectedItem.ToString(),
                            comboboxTVerificacion.SelectedItem.ToString(),
                             Convert.ToDateTime(dtFDeteccion.Value),
                             Convert.ToDateTime(dtFSolucion.Value),
                             Convert.ToDateTime(dtFVerificacion.Value));
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (esnuevo)
                        {
                            this.mensajeok("Se ha creado la tarea satisfactoriamente");
                        }
                        else
                        {
                            this.mensajeok("Se ha editado la tarea satisfactoriamente");
                        }
                    }
                    else
                    {
                        this.mensajeerror(rpta);
                    }
                    botonesVisible(false);
                    botones();
                    this.limpiar();
                    FrmTarea tarea = new FrmTarea();
                    FrmParent.frmparent.lanzarNuevoElemento(tarea);
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }
        

        private void btnEliminarProyecto_Click(object sender, EventArgs e)
        {
            if (!txtIdTarea.Text.Equals(""))
            {
                try
                {
                    DialogResult opcion;
                    opcion = MessageBox.Show("¿Desea continuar?", "Eliminar Tarea", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcion == DialogResult.OK)
                    {
                        string rpta = "";

                        rpta = NTarea.eliminarTarea(txtIdTarea.Text);

                        if (rpta.Equals("OK"))
                        {
                            this.mensajeok("Registro eliminado");
                        }
                        else
                        {
                            this.mensajeerror("¡Ups!, Ha surgido un error");
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

        private void btnFinal_Click(object sender, EventArgs e)
        {
            DInformacionTarea.finalIndex();
            mostrarDetalleTareas(getDetalleTareas(Convert.ToString(DInformacionTarea.dataListTareas.Rows[DInformacionTarea.index-1].Cells["codigo_tarea"].Value)));

            
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
           
            DInformacionTarea.sumaIndex();
            mostrarDetalleTareas(getDetalleTareas(Convert.ToString(DInformacionTarea.dataListTareas.Rows[DInformacionTarea.index].Cells["codigo_tarea"].Value)));

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            DInformacionTarea.restaIndex();

            mostrarDetalleTareas(getDetalleTareas(Convert.ToString(DInformacionTarea.dataListTareas.Rows[DInformacionTarea.index].Cells["codigo_tarea"].Value)));

        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {

            DInformacionTarea.primerIndex();
            
            mostrarDetalleTareas(getDetalleTareas(Convert.ToString(DInformacionTarea.dataListTareas.Rows[DInformacionTarea.index].Cells["codigo_tarea"].Value)));

        }

        public static implicit operator FrmDetalleTarea(FrmDetallePersonal v)
        {
            throw new NotImplementedException();
        }
    }
}
