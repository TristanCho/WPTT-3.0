﻿using System;
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
                rellenarComboboxes();
            }
            else
            {
                this.mensajeerror("selleccione el registro a modificar");
            }
        }
        private void botonesVisible(bool estado)
        {
            btnGuardar.Visible = estado;
            btnCancelar.Visible = estado;

            btnEditar.Visible = !estado;
            btnNuevo.Visible = !estado;
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
            this.txtIdTarea.ReadOnly = valor;
            this.txtDescripcionTarea.ReadOnly = !valor;
            this.txtTituloTarea.ReadOnly = !valor;
            this.comboboxEstado.Enabled = valor;
            this.comboboxProyecto.Enabled = valor;
            txtResolucion.ReadOnly = !valor;
            txtReferencia.ReadOnly = !valor;
            txtEstimado.ReadOnly = !valor;
            comboboxPrioridad.Enabled = valor;
            comboboxPrioridad.Enabled = valor;
            comboboxAplicacion.Enabled = valor;
            txtDeteccion.ReadOnly = !valor;
            comboboxModulo.Enabled = valor;
            txtDeteccion.ReadOnly = !valor;
            txtReferencia.ReadOnly = !valor;
            txtSolucion.ReadOnly = !valor;
            txtFVerificacion.ReadOnly = !valor;
            txtFSolucion.ReadOnly = !valor;
            comboboxTDeteccion.Enabled = valor;
            comboboxSolucion.Enabled = valor;
            comboboxTVerificacion.Enabled = valor;
            txtFDeteccion.ReadOnly = !valor;
            //this.dtFechaTarea.Enabled = valor;
        }

        private void FrmDetalleTarea_Load(object sender, EventArgs e)
        {

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            crearNuevo();
            rellenarComboboxes();
 
        }

        private void rellenarComboboxes()
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
            comboboxAplicacion.Items.AddRange(NTarea.mostrarPrioridad().ToArray());
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
            txtEstimado.Text = string.Empty;
            comboboxPrioridad.Items.Clear();
            comboboxEstado.Items.Clear();
            comboboxAplicacion.Items.Clear();
            txtDeteccion.Text = string.Empty;
            comboboxModulo.Items.Clear();
            txtDeteccion.Text = string.Empty;
            txtReferencia.Text = string.Empty;
            txtSolucion.Text = string.Empty;
            txtHistoria.Text = string.Empty;
            txtDescripcionTarea.Text = string.Empty;
            txtResolucion.Text = string.Empty;
            comboboxTDeteccion.Items.Clear();
            comboboxSolucion.Items.Clear();
            comboboxTVerificacion.Items.Clear();
            txtFDeteccion.Text = string.Empty;
            txtFSolucion.Text = string.Empty;
            txtFSolucion.Text = string.Empty;








            this.txtIdTarea.Text = string.Empty;
            this.txtTituloTarea.Text = string.Empty;
            this.comboboxProyecto.Items.Clear();
            this.comboboxEstado.Items.Clear();
            //dtFechaTarea.Text = string.Empty;
            this.txtDescripcionTarea.Text = string.Empty;
            this.txtResolucion.Text = string.Empty;
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

        internal void mostrarDetalleTareas(DetalleTareas tarea)
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
            txtSolucion.Text = tarea.Solucion;
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

            txtFDeteccion.Text = tarea.FDeteccion;
            txtFSolucion.Text = tarea.FSolucion;
            txtFSolucion.Text = tarea.FVerificacion;



        }

        public DetalleTareas getDetalleTareas(string codigo_tarea)
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
                            this.txtTituloTarea.Text.Trim().ToUpper(),
                            this.txtDescripcionTarea.Text.Trim(),  
                            this.txtResolucion.Text.Trim(),
                           // Convert.ToDateTime(this.dtFechaTarea.Value),
                            this.comboboxEstado.SelectedItem.ToString() ,
                            this.comboboxProyecto.SelectedItem.ToString()
                            );
                    }
                    else
                    {
                        //TODO falta por acabar, salta error
                        rpta = NTarea.editarTarea(
                            Convert.ToInt32(this.txtIdTarea.Text),
                            this.txtTituloTarea.Text.Trim().ToUpper(),
                            this.txtDescripcionTarea.Text.Trim(),
                            this.txtResolucion.Text.Trim(),
                           // Convert.ToDateTime(this.dtFechaTarea.Value),
                            this.comboboxEstado.SelectedItem.ToString(),
                            this.comboboxProyecto.SelectedItem.ToString()
                            );
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
                    opcion = MessageBox.Show("¿Desea continuar?", "Eliminar Proyecto", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcion == DialogResult.OK)
                    {
                        string rpta = "";

                        rpta = NTarea.eliminarTarea(Convert.ToInt32(txtIdTarea.Text));

                        if (rpta.Equals("OK"))
                        {
                            this.mensajeok("Registro eliminado");
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

                /*if (aux < 1)
                {
                    MessageBox.Show("No haz seleccionado ningún proyecto", "Eliminar Proyecto", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                this.mostrarproyectos();*/
            }

        }
        /*
        public void llamaVisualizaDatos()
        {

            visualizaDatos(
                Convert.ToString(DInformacionTarea.dataListTareas.Rows[DInformacionTarea.index].Cells["id"].Value),
                Convert.ToString(DInformacionTarea.dataListTareas.Rows[DInformacionTarea.index].Cells["proyecto"].Value),
                Convert.ToString(DInformacionTarea.dataListTareas.Rows[DInformacionTarea.index].Cells["tarea"].Value),
                Convert.ToString(DInformacionTarea.dataListTareas.Rows[DInformacionTarea.index].Cells["descripcion"].Value),
                Convert.ToString(DInformacionTarea.dataListTareas.Rows[DInformacionTarea.index].Cells["observaciones"].Value),
                Convert.ToString(DInformacionTarea.dataListTareas.Rows[DInformacionTarea.index].Cells["fecha_creacion"].Value),
                Convert.ToString(DInformacionTarea.dataListTareas.Rows[DInformacionTarea.index].Cells["estado"].Value),
                Convert.ToString(DInformacionTarea.dataListTareas.Rows[DInformacionTarea.index].Cells["tecnico"].Value)
                );
        }
     */
    }
}
