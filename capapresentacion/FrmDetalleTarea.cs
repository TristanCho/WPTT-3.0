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



        public void activarEdicion(bool value)
        {
            eseditar = value;
            rellenarComboboxes();
            botones();
        }


        public void crearTarea()
        {
            crearNuevo();
            rellenarComboboxes();

        }



        private void habilitar(bool valor)
        {
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

        public void guardarTarea()
        {
            try
            {
                string rpta = "";


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
                botones();
                FrmTarea tarea = new FrmTarea();
                FrmParent.frmparent.lanzarNuevoElemento(tarea);

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }

        private void FrmDetalleTarea_Load(object sender, EventArgs e)
        {

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

        public void botonEliminarTarea()
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

                        this.Close();
                        FrmParent.frmparent.lanzarNuevoElemento(new FrmTarea());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }


            }
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

        public void crearNuevo()
        {
            esnuevo = true;
            setModo("CREACIÓN");
            botones();
            limpiar();
            rellenarComboboxes();
        }
        public void setModo(String modo)
        {
            lEdicion.Text = "[MODO " + modo + "]";
        }

        public void removerDelIndex()
        {
            DInformacionTarea.removerDelIndex();
        }

        private void botones()
        {
            if (esnuevo || this.eseditar)
            {
                habilitar(true);
            }
            else
            {
                habilitar(false);
            }
        }

        private void limpiar()
        {
            txtTituloTarea.Text = string.Empty;
            txtReferencia.Text = string.Empty;
            txtIdTarea.Text = string.Empty;
            comboboxProyecto.Items.Clear();
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

        public void cancelar()
        {
            lectura();
            mostrarDetalleTareas(getDetalleTareas(Convert.ToString(DInformacionTarea.dataListTareas.Rows[DInformacionTarea.index].Cells["codigo_tarea"].Value)));
        }

        public void lectura()
        {
            esnuevo = false;
            this.eseditar = false;
            botones();
            setModo("LECTURA");
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



        public void siguiente()
        {
            DInformacionTarea.sumaIndex();
            mostrarDetalleTareas(getDetalleTareas(Convert.ToString(DInformacionTarea.dataListTareas.Rows[DInformacionTarea.index].Cells["codigo_tarea"].Value)));

        }
        public void botonUltimo()
        {
            DInformacionTarea.finalIndex();
            mostrarDetalleTareas(getDetalleTareas(Convert.ToString(DInformacionTarea.dataListTareas.Rows[DInformacionTarea.index - 1].Cells["codigo_tarea"].Value)));

        }

        public void atras()
        {
            DInformacionTarea.restaIndex();
            mostrarDetalleTareas(getDetalleTareas(Convert.ToString(DInformacionTarea.dataListTareas.Rows[DInformacionTarea.index].Cells["codigo_tarea"].Value)));

        }
        public void primero()
        {
            DInformacionTarea.primerIndex();
            mostrarDetalleTareas(getDetalleTareas(Convert.ToString(DInformacionTarea.dataListTareas.Rows[DInformacionTarea.index].Cells["codigo_tarea"].Value)));

        }


        public void volver()
        {
            this.Close();
            FrmParent.frmparent.AbrirFormulario(new FrmTarea());
        }

        public static implicit operator FrmDetalleTarea(FrmDetallePersonal v)
        {
            throw new NotImplementedException();
        }
    }
}
