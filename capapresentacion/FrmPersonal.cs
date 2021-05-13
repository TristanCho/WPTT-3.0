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
    public partial class FrmPersonal : Form
    {
        public FrmPrincipal frmparent;
        FrmDetalleTarea detalleTareas = new FrmDetalleTarea();
        public FrmPersonal()
        {
            InitializeComponent();
            mostrartareas();
            ocultarcolumnas();
            quitabordes();
            tamañoColumnas();
        }
        private void tamañoColumnas()
        {
           // this.dataListPersonales.Columns[4].Width = 200;
       //     this.dataListPersonales.Columns[6].Width = 150;
      //      this.dataListPersonales.Columns[7].Width = 50;
        }
        private void quitabordes()
        {
            this.dataListPersonal.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            this.dataListPersonal.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            this.dataListPersonal.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            this.dataListPersonal.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
        }

        private void FrmTarea_Load(object sender, EventArgs e)
        {
            
        }

        public void mostrartareas()
        {
            this.dataListPersonal.DataSource = NPersonal.mostrarpersonales();
            //this.ocultarcolumnas();
            // this.btnEliminarProyecto.Visible = true;
            this.lblTotal.Text = "Número de TPersonales: " + Convert.ToString(dataListPersonal.Rows.Count);
            this.cbEliminar.Checked = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
           // FrmParent.frmparent.lanzarNuevoElemento(detalleTareas);
            detalleTareas.crearNuevo();
            detalleTareas.setTecnico();
            detalleTareas.setBotonEliminar(false);
        }

        private void ocultarcolumnas()
        {
            btnEliminarTarea.Visible = false;
            this.dataListPersonal.Columns[0].Visible = false;
           // this.dataListPersonales.Columns[1].Visible = false;
          //  this.dataListPersonales.Columns[2].Visible = false;
        }

        private void txtBuscarPersonal_TextChanged(object sender, EventArgs e)
        {
            this.buscarPersonales(this.txtBuscarPersonal.Text);
        }     

        private void buscarPersonales(string texto)
        {
            this.dataListPersonal.DataSource = NPersonal.buscarpersonales(texto);
            this.ocultarcolumnas();
        }             

        private void cbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbEliminar.Checked)
            {
                this.dataListPersonal.Columns[0].Visible = true;
                this.btnEliminarTarea.Visible = true;
            }
            else
            {
                this.dataListPersonal.Columns[0].Visible = false;
                this.btnEliminarTarea.Visible = false;
            }
        }

        private void dataListTareas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FrmDetalleTarea detalleTarea = new FrmDetalleTarea();

                DInformacionTarea.dataListTareas = dataListPersonal;
                DInformacionTarea.index = this.dataListPersonal.CurrentRow.Index;
                DInformacionTarea.detalleTarea = detalleTarea;


                //FrmParent.frmparent.lanzarNuevoElemento(detalleTarea);
                detalleTarea.mostrarDetalleTareas(detalleTarea.getDetalleTareas(Convert.ToString(this.dataListPersonal.CurrentRow.Cells["codigo_tarea"].Value)));

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
            if (e.ColumnIndex == dataListPersonal.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)dataListPersonal.Rows[e.RowIndex].Cells["Eliminar"];
                chkeliminar.Value = !Convert.ToBoolean(chkeliminar.Value);
            }
            //Console.WriteLine(Convert.ToString(this.dataListTareas.CurrentRow.Cells["codigo_tarea"].Value));

            //mostrarDetalleTareaClicada(Convert.ToString(this.dataListPersonales.CurrentRow.Cells["codigo_tarea"].Value));
        }
        //private void mostrarDetalleTareaClicada(string codigo_tarea)
        //{
        //    //this.dataListDetalleTareas.Columns[0].Visible = false;
        //    dataListDetalleTareas.DataSource = NTarea.mostrarDetalleTiempos(codigo_tarea);
        //}
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
                    foreach (DataGridViewRow row in dataListPersonal.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            aux = 1;

                            id = Convert.ToInt32(row.Cells[1].Value);
                            //rpta = NTarea.eliminarTarea(Convert.ToInt32(id));

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

        private void dataListPersonales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListPersonal.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)dataListPersonal.Rows[e.RowIndex].Cells["Eliminar"];
                chkeliminar.Value = !Convert.ToBoolean(chkeliminar.Value);
            }
            //Console.WriteLine(Convert.ToString(this.dataListTareas.CurrentRow.Cells["codigo_tarea"].Value));

            //mostrarDetalleTareaClicada(Convert.ToString(this.dataListPersonales.CurrentRow.Cells["codigo_tarea"].Value));
        }

        private void dataListPersonal_CellDoubleClick(object sender, EventArgs e)
        {
            try
            {
                FrmDetallePersonal detallePersonal = new FrmDetallePersonal();

                //DInformacionProyecto.detallePersonal = dataListPersonal;
                //DInformacionProyecto.index = this.dataListPersonal.CurrentRow.Index;
                //DInformacionProyecto.detalleProyecto = detalleProyecto;

                //detallePersonal.visualizaDatos(
                //    Convert.ToString(this.dataListPersonal.CurrentRow.Cells["idTarea"].Value),
                //    Convert.ToString(this.dataListPersonal.CurrentRow.Cells["id_empleado"].Value),
                //    Convert.ToString(this.dataListPersonal.CurrentRow.Cells["descripcion"].Value),
                //    Convert.ToString(this.dataListPersonal.CurrentRow.Cells["fcreacion"].Value),
                //    Convert.ToString(this.dataListPersonal.CurrentRow.Cells["prioridad"].Value),
                //    Convert.ToString(this.dataListPersonal.CurrentRow.Cells["estado"].Value),
                //    Convert.ToString(this.dataListPersonal.CurrentRow.Cells["fcierre"].Value),
                //    Convert.ToString(this.dataListPersonal.CurrentRow.Cells["idTareaGrupo"].Value),
                //    Convert.ToString(this.dataListPersonal.CurrentRow.Cells["idTareaDestino"].Value),
                //    Convert.ToString(this.dataListPersonal.CurrentRow.Cells["idTareaOrigen"].Value)
                //    );

                //Console.WriteLine(this.dataListProyectos.SelectedRows[2].Cells["id"].Value);

                //detalleProyecto.frmparent = frmparent;
                FrmParent.frmparent.lanzarNuevoElemento(detallePersonal);

                detallePersonal.setModo("LECTURA");
            }
            catch (Exception)
            {
                MessageBox.Show("Error en el evento Double click ", "Error en el evento Double click ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmPersonal_Load(object sender, EventArgs e)
        {

        }
       
    }
    
}
