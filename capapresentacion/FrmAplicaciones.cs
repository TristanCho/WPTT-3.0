﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using capadatos;
using capanegocio;
using WPTT_1._0;

namespace capapresentacion
{
    public partial class FrmAplicaciones : Form
    {
        public FrmPrincipal frmparent;

        public FrmAplicaciones()
        {
            InitializeComponent();
            activaCheckBox();
            mostrarproyectos();
            tamañoColumnas();
            quitarBordes();
        }

        private void tamañoColumnas()
        {
            this.dataListAplicaciones.Columns[1].Width = 30;
        }

        private void mensajeok(string mensaje)
        {
            MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cerrarX(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarX);
        }

        private void FrmPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void mostrarproyectos()
        {
            this.dataListAplicaciones.DataSource = NProyecto.mostrarproyectos();
            ocultarcolumnas();
            //this.btnEliminarProyecto.Visible = true;
            this.lblTotal.Text = "Número de proyectos: " + Convert.ToString(dataListAplicaciones.Rows.Count);
        }

        private void ocultarcolumnas()
        {
            MessageBox.Show("Pendiente revisar las columnas a ocultar");
            //this.dataListAplicaciones.Columns[0].Visible = false;

           // this.dataListAplicaciones.Columns[2].Visible = false;
            //this.dataListProyectos.Columns[3].Visible = false;
            //this.btnEliminarProyecto.Enabled = false;
            //this.cbEliminar.Checked = false;
        }

        public void nuevoProyecto()
        {
            FrmDetalleProyecto detalleproyecto = new FrmDetalleProyecto();
            FrmParent.frmparent.lanzarNuevoElemento(detalleproyecto);
            detalleproyecto.visualizaBotonesCambiarFormulario(false);
            detalleproyecto.crearProyecto();
            //  detalleproyecto.setBotonEliminar(false);
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmDetalleProyecto detalleproyecto = new FrmDetalleProyecto();
            FrmParent.frmparent.lanzarNuevoElemento(detalleproyecto);
            detalleproyecto.visualizaBotonesCambiarFormulario(false);
            detalleproyecto.crearProyecto();
            //  detalleproyecto.setBotonEliminar(false);
        }

        private void quitarBordes()
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            TopMost = true;
            ShowInTaskbar = false;
            this.Text = String.Empty;
            this.ControlBox = false;

            //quita bordes del datagrid
            this.dataListAplicaciones.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            this.dataListAplicaciones.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            this.dataListAplicaciones.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            this.dataListAplicaciones.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
        }
        /*Utilizado para mover el panel atraves de la pantalla*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        /*fin del drag*/

        private void cbEliminar_CheckedChanged_1(object sender, EventArgs e)
        {
            activaCheckBox();
        }

        private void activaCheckBox()
        {
            /* if (this.cbEliminar.Checked)
             {
                 this.dataListProyectos.Columns[0].Visible = true;
                 this.btnEliminarProyecto.Visible = true;
             }
             else
             {
                 this.dataListProyectos.Columns[0].Visible = false;
                 this.btnEliminarProyecto.Visible = false;
             }*/
        }
     

        public void editarProyecto()
        {

            foreach (DataGridViewRow row in dataListAplicaciones.Rows)
            {
                if (Convert.ToBoolean(row.Selected))
                {
                    FrmDetalleProyecto detalleProyecto = new FrmDetalleProyecto();

                    DInformacionProyecto.dataListProyectos = dataListAplicaciones;
                    DInformacionProyecto.index = this.dataListAplicaciones.CurrentRow.Index;
                    DInformacionProyecto.detalleProyecto = detalleProyecto;

                    detalleProyecto.visualizaDatos(
                         Convert.ToString(this.dataListAplicaciones.CurrentRow.Cells["id"].Value),
                         Convert.ToString(this.dataListAplicaciones.CurrentRow.Cells["codigo_proyecto"].Value),
                         Convert.ToString(this.dataListAplicaciones.CurrentRow.Cells["titulo"].Value),
                         Convert.ToString(this.dataListAplicaciones.CurrentRow.Cells["observaciones"].Value),
                         Convert.ToString(this.dataListAplicaciones.CurrentRow.Cells["fecha"].Value)
                         );


                    FrmParent.frmparent.lanzarNuevoElemento(detalleProyecto);
                    StaticBarraHorizontal.horizontalParent.visualizaBotonesCambiarFormulario(true);
                    StaticBarraHorizontal.horizontalParent.visualizaBotonGuardar(false);
                    detalleProyecto.setModo("EDICIÓN");
                    detalleProyecto.habilitar(true);
                    break;

                }
            }

        }
        public void botonEliminarProyectoPrincipal()
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Desea continuar?", "Eliminar Proyecto", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int aux = 0;
                    int id;
                    string rpta = "";
                    foreach (DataGridViewRow row in dataListAplicaciones.Rows)
                    {
                        if (Convert.ToBoolean(row.Selected))
                        {
                            aux = 1;

                            id = Convert.ToInt32(row.Cells[1].Value);
                            rpta = NProyecto.eliminarproyecto(id);


                        }
                    }
                    if (rpta.Equals("OK"))
                    {
                        this.mensajeok("Registro eliminado");
                    }
                    else
                    {
                        this.mensajeerror("¡Ups!, Al parecer tienes tareas asignadas a este proyecto...");
                        this.mensajeerror(rpta);
                    }
                    if (aux < 1)
                    {
                        MessageBox.Show("No haz seleccionado ningún proyecto", "Eliminar Proyecto", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                    this.mostrarproyectos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
        /*PROCEDURES*/
        private void btnEliminarProyecto_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Desea continuar?", "Eliminar Proyecto", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int aux = 0;
                    int id;
                    string rpta = "";
                    foreach (DataGridViewRow row in dataListAplicaciones.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            aux = 1;

                            id = Convert.ToInt32(row.Cells[1].Value);
                            rpta = NProyecto.eliminarproyecto(id);

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
                    if (aux < 1)
                    {
                        MessageBox.Show("No haz seleccionado ningún proyecto", "Eliminar Proyecto", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                    this.mostrarproyectos();
                }
                else
                {
                    //  this.btnEliminarProyecto.Enabled = false;
                    // this.cbEliminar.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void buscarProyecto(string texto)
        {
            this.dataListAplicaciones.DataSource = NProyecto.buscarproyecto(texto);
            this.ocultarcolumnas();
        }

        private void txtBuscarProyecto_TextChanged(object sender, EventArgs e)
        {
            this.buscarProyecto(this.txtBuscarProyecto.Text);
        }

        private void FrmProyecto_Load(object sender, EventArgs e)
        {

        }

        public int getNumeroIndice()
        {
            return dataListAplicaciones.Rows.Count;
        }

        private void dataListAplicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListAplicaciones.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)dataListAplicaciones.Rows[e.RowIndex].Cells["Eliminar"];
                chkeliminar.Value = !Convert.ToBoolean(chkeliminar.Value);
            }
        }
     

        private void dataListAplicaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("En  Doble clic");
            try
            {
                FrmDetalleProyecto detalleProyecto = new FrmDetalleProyecto();

                DInformacionProyecto.dataListProyectos = dataListAplicaciones;
                DInformacionProyecto.index = this.dataListAplicaciones.CurrentRow.Index;
                DInformacionProyecto.detalleProyecto = detalleProyecto;

                detalleProyecto.visualizaDatos(
                     Convert.ToString(this.dataListAplicaciones.CurrentRow.Cells["id"].Value),
                     Convert.ToString(this.dataListAplicaciones.CurrentRow.Cells["codigo_proyecto"].Value),
                     Convert.ToString(this.dataListAplicaciones.CurrentRow.Cells["titulo"].Value),
                     Convert.ToString(this.dataListAplicaciones.CurrentRow.Cells["observaciones"].Value),
                     Convert.ToString(this.dataListAplicaciones.CurrentRow.Cells["fecha"].Value)
                     );


                FrmParent.frmparent.lanzarNuevoElemento(detalleProyecto);
                StaticBarraHorizontal.horizontalParent.visualizaBotonesCambiarFormulario(true);
                StaticBarraHorizontal.horizontalParent.visualizaBotonGuardar(false);
                detalleProyecto.setModo("LECTURA");

            }
            catch (Exception)
            {
                MessageBox.Show("Error en el evento Double click ", "Error en el evento Double click ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
