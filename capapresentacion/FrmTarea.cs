﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capanegocio;
using WPTT_1._0;

namespace capapresentacion
{
    public partial class FrmTarea : Form
    {
        public FrmPrincipal frmparent;
        FrmDetalleTarea detalleTareas = new FrmDetalleTarea();
        public FrmTarea()
        {
            InitializeComponent();
            mostrartareas();
            ocultarcolumnas();
            quitabordes();
            tamañoColumnas();
        }
        private void tamañoColumnas()
        {
            this.dataListTareas.Columns[4].Width = 200;
            this.dataListTareas.Columns[6].Width = 150;
            this.dataListTareas.Columns[7].Width = 50;
        }
        private void quitabordes()
        {
            this.dataListTareas.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            this.dataListTareas.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            this.dataListTareas.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            this.dataListTareas.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
        }

        private void FrmTarea_Load(object sender, EventArgs e)
        {
            cboBuscarTareas.SelectedIndex = 0;
        }

        public void mostrartareas()
        {
            this.dataListTareas.DataSource = NTarea.mostrartareas();
            this.ocultarcolumnas();
            // this.btnEliminarProyecto.Visible = true;
            this.lblTotal.Text = "Número de tareas: " + Convert.ToString(dataListTareas.Rows.Count);
            this.cbEliminar.Checked = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmParent.frmparent.lanzarNuevoElemento(detalleTareas);
            detalleTareas.crearNuevo();
            detalleTareas.setTecnico();
            detalleTareas.setBotonEliminar(false);
        }

        private void ocultarcolumnas()
        {
            btnEliminarTarea.Visible = false;
            this.dataListTareas.Columns[0].Visible = false;
            this.dataListTareas.Columns[1].Visible = false;
            this.dataListTareas.Columns[2].Visible = false;
        }

        private void txtBuscarTarea_TextChanged(object sender, EventArgs e)
        {
            this.buscarTarea(this.txtBuscarTarea.Text);
        }

        private void buscarTarea(string texto)
        {
            if (cboBuscarTareas.SelectedItem != null)
            {
                switch (cboBuscarTareas.SelectedItem.ToString())
                {
                    case "Tarea":
                        this.dataListTareas.DataSource = NTarea.buscartareaTitulo(texto);
                        break;
                    case "Descripción":
                        this.dataListTareas.DataSource = NTarea.buscartareaDescripcion(texto);
                        break;
                    case "Aplicación":
                        this.dataListTareas.DataSource = NTarea.buscartareaAplicacion(texto);
                        break;
                    case "Proyecto":
                        this.dataListTareas.DataSource = NTarea.buscartareaProyecto(texto);
                        break;
                    case "Prioridad":
                        this.dataListTareas.DataSource = NTarea.buscartareaPrioridad(texto);
                        break;
                    case "Estados":
                        this.dataListTareas.DataSource = NTarea.buscartareaEstados(texto);
                        break;

                }
            }
           // this.ocultarcolumnas();
        }



        private void cboBuscarTareas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbEliminar.Checked)
            {
                this.dataListTareas.Columns[0].Visible = true;
                this.btnEliminarTarea.Visible = true;
            }
            else
            {
                this.dataListTareas.Columns[0].Visible = false;
                this.btnEliminarTarea.Visible = false;
            }
        }

        private void dataListTareas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FrmDetalleTarea detalleTarea = new FrmDetalleTarea();

                DInformacionTarea.dataListTareas = dataListTareas;
                DInformacionTarea.index = this.dataListTareas.CurrentRow.Index;
                DInformacionTarea.detalleTarea = detalleTarea;


                FrmParent.frmparent.lanzarNuevoElemento(detalleTarea);
                 detalleTarea.mostrarDetalleTareas(detalleTarea.getDetalleTareas(Convert.ToString(this.dataListTareas.CurrentRow.Cells["codigo_tarea"].Value)));



               /* detalleTarea.visualizaDatos(
                    Convert.ToString(this.dataListTareas.CurrentRow.Cells["id"].Value),
                    Convert.ToString(this.dataListTareas.CurrentRow.Cells["proyecto"].Value),
                    Convert.ToString(this.dataListTareas.CurrentRow.Cells["tarea"].Value),
                    Convert.ToString(this.dataListTareas.CurrentRow.Cells["descripcion"].Value),
                    Convert.ToString(this.dataListTareas.CurrentRow.Cells["observaciones"].Value),
                    Convert.ToString(this.dataListTareas.CurrentRow.Cells["fecha_creacion"].Value),
                    Convert.ToString(this.dataListTareas.CurrentRow.Cells["estado"].Value)
                    );*/
            }
            catch (Exception)
            {
                MessageBox.Show("Error en el evento Double click ", "Error en el evento Double click ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataListTareas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListTareas.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)dataListTareas.Rows[e.RowIndex].Cells["Eliminar"];
                chkeliminar.Value = !Convert.ToBoolean(chkeliminar.Value);
            }
            //Console.WriteLine(Convert.ToString(this.dataListTareas.CurrentRow.Cells["codigo_tarea"].Value));

            mostrarDetalleTareaClicada(Convert.ToString(this.dataListTareas.CurrentRow.Cells["codigo_tarea"].Value));
        }
        private void mostrarDetalleTareaClicada(string codigo_tarea)
        {
            this.dataListDetalleTareas.Columns[0].Visible = false;
            dataListDetalleTareas.DataSource= NTarea.mostrarDetalleTiempos(codigo_tarea);
       }
        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Desea continuar?", "Eliminar Tarea", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int aux = 0;
                    int id;
                    string rpta = "";
                    foreach (DataGridViewRow row in dataListTareas.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            aux = 1;

                            id = Convert.ToInt32(row.Cells[1].Value);
                            rpta = NTarea.eliminarTarea(Convert.ToInt32(id));

                            if (rpta.Equals("OK"))
                            {
                                this.mensajeok("Registro eliminado");
                            }
                            else
                            {
                                this.mensajeerror("¡Ups!, No se ha podido eliminar la tarea");
                                this.mensajeerror(rpta);
                            }
                        }
                    }
                    if (aux < 1)
                    {
                        MessageBox.Show("No haz seleccionado ningúna Tarea", "Eliminar Tarea", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                    this.mostrartareas();
                }
                else
                {
                    this.btnEliminarTarea.Enabled = false;
                    this.cbEliminar.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void mensajeok(string mensaje)
        {
            MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
