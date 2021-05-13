﻿using System;
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
    public partial class FrmDetalleTiempos : Form
    {
        bool esnuevo = false;
        bool eseditar = false;
        public string idtiempo = "";
        public FrmPrincipal frmparent;
        public FrmDetalleTiempos()
        {
            InitializeComponent();
            habilitar(false);
            botonesVisible(false);
            //comboboxAccion.SelectedIndex = 0;
        }

        private void mensajeok(string mensaje)
        {
            MessageBox.Show(mensaje, "Detalle de Tiempo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Detalle de Tiempo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void botonNuevoClicado()
        {
            mostrarTareaCombobox();
            //comboboxAccion.Items.AddRange( new string[] { "A", "D", "V", "DI" });
            //mostrarTareaPersonalCombobox(DLoginStatico.usuario, comboboxTarea.SelectedItem.ToString());
        }
        private void limpiar()
        {
            this.txtIdTiempo.Text = string.Empty;
            this.txtObservaciones.Text = string.Empty;
            this.dtFechaInicio.Text = string.Empty;
            this.dtFechaFin.Text = string.Empty;
            txtCodTarea.Text = string.Empty;
            //comboboxAccion.Items.Clear();
        }

        private void habilitar(bool valor)
        {
            this.txtIdTiempo.ReadOnly = true;
            this.comboboxTarea.Enabled = valor;
            this.txtObservaciones.ReadOnly = !valor;
            this.txtId.ReadOnly = true;
            this.dtFechaInicio.Enabled = valor;
            this.dtFechaFin.Enabled = valor;
            this.dtFecha.Enabled = valor;
            comboboxAccion.Enabled = valor;
            comboboxTareaPersonal.Enabled = valor;
            txtCodTarea.ReadOnly =true;
            checkImputable.Enabled = valor;
            checkImputado.Enabled = valor;


        }
        private void botonesVisible(bool estado)
        {
            btnGuardar.Visible = estado;
            btnCancelar.Visible = estado;
            btnEditar.Visible = !estado;
            btnNuevo.Visible = !estado;
            txtObservaciones.Enabled = estado;

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

        public void desbloqueaBotones()
        {
            esnuevo = true;
            txtObservaciones.Enabled = true;
            btnEliminarTiempo.Visible = false;
            botonesVisible(true);
            setModo("CREACIÓN");
            botones();
            limpiar();
        }

        internal void setBotonEliminar(bool value)
        {
            btnEliminarTiempo.Visible = value;
        }

        private void FrmDetalleTiempos_Load(object sender, EventArgs e)
        {
            this.botones();
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esnuevo = true;
            txtObservaciones.Enabled = true;
            btnEliminarTiempo.Visible = false;

            desbloqueaBotones();
            botonesVisible(true);
            setModo("CREACIÓN");
            botones();
            limpiar();
            botonNuevoClicado();
        }
        private string getTareaPersonal()
        {
           //Console.WriteLine(comboboxTareaPersonal.SelectedValue.ToString());
            if (comboboxTareaPersonal.SelectedValue == null)
            {
                Console.WriteLine("nullo");
                 return "";
             }
            Console.WriteLine(comboboxTareaPersonal.SelectedValue.ToString());
            return comboboxTareaPersonal.SelectedValue.ToString();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            try
            {
                string rpta = "";
                if (this.comboboxTarea.Text==string.Empty)
                {
                    mensajeerror("Formulario incompleto");
                    this.iconoerror.SetError(this.comboboxTarea, "Ingresar Tarea");
                }
                else
                {
                    if (esnuevo)
                    {
                        //Console.WriteLine(comboboxTareaPersonal.SelectedItem.ToString()+"console");
                        rpta = NTiempo.insertartiempo(
                       dtFecha.Value.ToString(), dtFechaInicio.Value.ToString(), dtFechaFin.Value.ToString(),
                       txtObservaciones.Text, comboboxAccion.SelectedItem.ToString(), comboboxTarea.SelectedItem.ToString(),
                       getTareaPersonal(),
                       DLoginStatico.usuario, booleanToInt(checkImputable.Checked), booleanToInt(checkImputado.Checked));
                    }
                    else
                    {
                        rpta = NTiempo.editartiempo(txtId.Text,
                       dtFecha.Value.ToString(), dtFechaInicio.Value.ToString(), dtFechaFin.Value.ToString(),
                       txtObservaciones.Text, comboboxAccion.SelectedItem.ToString(), comboboxTarea.SelectedItem.ToString(),
                       getTareaPersonal(),
                       DLoginStatico.usuario, booleanToInt(checkImputable.Checked), booleanToInt(checkImputado.Checked));
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (esnuevo)
                        {
                            this.mensajeok("Se ha creado el Registro de tiempo satisfactoriamente");
                        }
                        else
                        {
                            this.mensajeok("Se ha editado el Registro de tiempo satisfactoriamente");
                        }

                    }
                    else
                    {
                        this.mensajeerror(rpta);
                    }

                    botonesVisible(false);
                    botones();
                    this.Hide();
                    FrmTiempos tiempos = new FrmTiempos();
                    FrmParent.frmparent.lanzarNuevoElemento(tiempos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdTiempo.Text.Equals(""))
            {
                this.eseditar = true;
                this.botones();
                setModo("EDICIÓN");
                botonesVisible(true);
                mostrarTareaCombobox();
                
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
            setModo("LECTURA");
            this.Hide();
        }
        public void visualizaDatos(string fecha, string fechaInicio, string fechaFin,
            string tiempo, string observaciones, string accion, string id, string id_tarea,
            string codigo_tarea, string imputable, string imputado)
        {
            dtFecha.Value = DateTime.Parse(fecha);
            dtFechaInicio.Value = DateTime.Parse(fechaInicio);
            dtFechaFin.Value = DateTime.Parse(fechaFin);
            txtIdTiempo.Text = tiempo;
            txtObservaciones.Text = observaciones;

            comboboxAccion.Items.Clear();
            comboboxAccion.Items.Add(accion);
           // comboboxAccion
            comboboxAccion.SelectedIndex = 0;

            //Console.WriteLine(id_tarea);
            comboboxTarea.Items.Add(id_tarea);
            comboboxTarea.SelectedIndex = 1;

            txtCodTarea.Text = codigo_tarea;
            txtId.Text = id;

            checkImputable.Checked = transformarBoolean(imputable);
            checkImputado.Checked = transformarBoolean(imputado);
        }
               
        private bool transformarBoolean(string estado)
        {
            if (estado.Equals("False"))
                return false;
            
            return true;
        }

        private int booleanToInt(bool numero)
        {
            if (numero )
                return 1;

            return 0;
        }

        public void mostrarTareaCombobox()
        {
            comboboxTarea.Items.AddRange(NTiempo.mostrarTareaCombobox().ToArray());
            comboboxTarea.SelectedIndex = 1;
            comboboxAccion.Items.Clear();
            comboboxAccion.Items.AddRange(new string[] { "A", "D", "V", "DI" });
            comboboxAccion.SelectedIndex = 1;
        }
        public void mostrarTareaPersonalCombobox(string usuario, string tarea)
        {
            comboboxTareaPersonal.Items.AddRange(NTiempo.mostrarTareaPersonalCombobox(usuario, tarea).ToArray());

           // comboboxTareaPersonal.SelectedIndex = 0;

        }

        private void btnEliminarTiempo_Click(object sender, EventArgs e)
        {
            if (!lEdicion.Text.Equals(""))
            {
                try
                {
                    DialogResult opcion;
                    opcion = MessageBox.Show("¿Desea continuar?", "Eliminar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcion == DialogResult.OK)
                    {

                        string rpta = "";

                        rpta = NTiempo.eliminartiempo(Convert.ToInt32(txtId.Text));

                        if (rpta.Equals("OK"))
                        {
                            this.mensajeok("Registro eliminado");
                            FrmParent.frmparent.AbrirFormulario(new FrmTiempos());
                        }
                        else
                        {
                            this.mensajeerror("¡Ups!, Algo ha salido mal...");
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

        private void FrmDetalleTiempos_Load_1(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            esnuevo = false;
            this.eseditar = false;
            botones();
            botonesVisible(false);
            setModo("LECTURA");
            this.Hide();
        }

        private void comboboxTarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("cambiando de item");
            
            mostrarTareaPersonalCombobox(DLoginStatico.usuario, comboboxTarea.SelectedItem.ToString());
        }
    }
}
