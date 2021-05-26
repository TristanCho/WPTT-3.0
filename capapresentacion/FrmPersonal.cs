using System;
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
    public partial class FrmPersonal : Form
    {
        public FrmPrincipal frmparent;
       // FrmDetallePersonal detallePersonal = new FrmDetallePersonal();
        public FrmPersonal()
        {
            InitializeComponent();
            mostrarpersonales();
            ocultarcolumnas();
            quitabordes();
            tamañoColumnas();
        }
        private void tamañoColumnas()
        {
            this.dataListPersonal.Columns[1].Width = 35;
            this.dataListPersonal.Columns[2].Width = 120;
            this.dataListPersonal.Columns[3].Width = 120;
            this.dataListPersonal.Columns[4].Width = 35;
            this.dataListPersonal.Columns[5].Width = 70;
            this.dataListPersonal.Columns[6].Width = 200;
            this.dataListPersonal.Columns[7].Width = 35;
            this.dataListPersonal.Columns[8].Width = 35;
            this.dataListPersonal.Columns[9].Width = 35;
            this.dataListPersonal.Columns[11].Width = 50;
            // this.dataListPersonal.Columns[6].Width = 150;
            //this.dataListPersonal.Columns[7].Width = 50;
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

        public void mostrarpersonales()
        {
            this.dataListPersonal.DataSource = NPersonal.mostrarpersonales();
            this.ocultarcolumnas();
            this.btnEliminarTarea.Visible = true;
            this.lblTotal.Text = "Número de TPersonales: " + Convert.ToString(dataListPersonal.Rows.Count);
            this.cbEliminar.Checked = false;
        }

        public void nuevoProyecto()
        {
            FrmDetallePersonal detallepersonal = new FrmDetallePersonal();
            FrmParent.frmparent.lanzarNuevoElemento(detallepersonal);
            detallepersonal.visualizaBotonesCambiarFormulario(false);
            detallepersonal.crearPersonal();
            detallepersonal.setBotonEliminar(false);
        }

      

        private void ocultarcolumnas()
        {
            btnEliminarTarea.Visible = false;
            this.dataListPersonal.Columns[0].Visible = false;
            //this.dataListPersonal.Columns[2].Visible = false;
            //this.dataListPersonal.Columns[3].Visible = false;
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
        private void dataListPersonales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {/*
            if (e.ColumnIndex == dataListPersonal.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)dataListPersonal.Rows[e.RowIndex].Cells["Eliminar"];
                chkeliminar.Value = !Convert.ToBoolean(chkeliminar.Value);
            }*/
        }

        //private void btnEliminarTarea_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DialogResult opcion;
        //        opcion = MessageBox.Show("¿Desea continuar?", "Eliminar Tarea", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //        if (opcion == DialogResult.OK)
        //        {
        //            int aux = 0;
        //            int id;
        //            string rpta = "";
        //            foreach (DataGridViewRow row in dataListPersonal.Rows)
        //            {
        //                if (Convert.ToBoolean(row.Cells[0].Value))
        //                {
        //                    aux = 1;

        //                    id = Convert.ToInt32(row.Cells[1].Value);
        //                    //rpta = NTarea.eliminarTarea(Convert.ToInt32(id));

        //                    if (rpta.Equals("OK"))
        //                    {
        //                        this.mensajeok("Registro eliminado");
        //                    }
        //                    else
        //                    {
        //                        this.mensajeerror("¡Ups!, No se ha podido eliminar la tarea");
        //                        this.mensajeerror(rpta);
        //                    }
        //                }
        //            }
        //            if (aux < 1)
        //            {
        //                MessageBox.Show("No haz seleccionado ningúna Tarea", "Eliminar Tarea", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        //            }
        //            this.mostrartareas();
        //        }
        //        else
        //        {
        //            this.btnEliminarTarea.Enabled = false;
        //            this.cbEliminar.Checked = false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message + ex.StackTrace);
        //    }
        //}

        public void botonEliminarPersonal()
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Desea continuar?", "Eliminar Tarea Personal", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int aux = 0;
                    string id;
                    string rpta = "";
                    foreach (DataGridViewRow row in dataListPersonal.Rows)
                    {
                        if (Convert.ToBoolean(row.Selected))
                        {
                            aux = 1;

                            id = Convert.ToString(row.Cells[1].Value);
                            //rpta = NProyecto.eliminarproyecto(id);
                            rpta = NPersonal.eliminarPersonal(id);


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
                    this.mostrarpersonales();
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
    
        private void FrmPersonal_Load(object sender, EventArgs e)
        {

        }
        private void cargaDataList(FrmDetallePersonal detallePersonal)
        {
            InformacionPersonal.dataListPersonal = dataListPersonal;
            InformacionPersonal.index = this.dataListPersonal.CurrentRow.Index;
            InformacionPersonal.detallePersonal = detallePersonal;
        }
        private void dataListPersonal_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FrmDetallePersonal detallePersonal = new FrmDetallePersonal();

                cargaDataList(detallePersonal);

                detallePersonal.visualizaDatos(
                Convert.ToString(this.dataListPersonal.CurrentRow.Cells["idTarea"].Value),
                Convert.ToString(this.dataListPersonal.CurrentRow.Cells["prioridad"].Value),
                Convert.ToString(this.dataListPersonal.CurrentRow.Cells["idProyecto"].Value),
                Convert.ToString(this.dataListPersonal.CurrentRow.Cells["id_aplicacion"].Value),
                Convert.ToString(this.dataListPersonal.CurrentRow.Cells["idTareaProyecto"].Value),
                Convert.ToString(this.dataListPersonal.CurrentRow.Cells["EstadoTProy"].Value),
                Convert.ToString(this.dataListPersonal.CurrentRow.Cells["titulo"].Value),
                Convert.ToString(this.dataListPersonal.CurrentRow.Cells["id_empleado"].Value),
                Convert.ToString(this.dataListPersonal.CurrentRow.Cells["id_empleadoReAsign"].Value),
                Convert.ToString(this.dataListPersonal.CurrentRow.Cells["estado"].Value),
                Convert.ToString(this.dataListPersonal.CurrentRow.Cells["fcreacion"].Value),
                Convert.ToString(this.dataListPersonal.CurrentRow.Cells["fcierre"].Value),
                Convert.ToString(this.dataListPersonal.CurrentRow.Cells["idTareaGrupo"].Value),
                Convert.ToString(this.dataListPersonal.CurrentRow.Cells["idTareaOrigen"].Value),
                Convert.ToString(this.dataListPersonal.CurrentRow.Cells["idTareaDestino"].Value),
                Convert.ToString(this.dataListPersonal.CurrentRow.Cells["descripcion"].Value),
                Convert.ToString(this.dataListPersonal.CurrentRow.Cells["ObsTiempos"].Value)
                );
                FrmParent.frmparent.lanzarNuevoElemento(detallePersonal);
                detallePersonal.desbloqueaBotones(false);
                detallePersonal.setModo("LECTURA");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en el evento Double click ", "Error en el evento Double click ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }



        ////////////////////////////CRISTHIAN/////////////////////////////////////////////     

        public void nuevaPersonal()
        {
            FrmDetallePersonal detallePersonal = new FrmDetallePersonal();

            FrmParent.frmparent.lanzarNuevoElemento(detallePersonal);
            detallePersonal.visualizaBotonesCambiarFormulario(false);
            detallePersonal.crearPersonal();
        }




        ////////////////////////////CRISTHIAN/////////////////////////////////////////////
    }
}
