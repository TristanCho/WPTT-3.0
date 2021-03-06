using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capadatos;
using capanegocio;
using WPTT_1._0;

namespace capapresentacion
{
    public partial class FrmProyecto : Form
    {
        public FrmPrincipal frmparent;

        public FrmProyecto()
        {
            InitializeComponent();
            mostrarproyectos();
            tamañoColumnas();
            quitarBordes();
        }

        private void tamañoColumnas()
        {
            this.dataListProyectos.Columns[1].Width = 30;
        }

        private void mensajeok(string mensaje)
        {
            MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }




        public void mostrarproyectos()
        {
            this.dataListProyectos.DataSource = NProyecto.mostrarproyectos();
            ocultarcolumnas();
            //this.btnEliminarProyecto.Visible = true;
            this.lblTotal.Text = "Número de proyectos: " + Convert.ToString(dataListProyectos.Rows.Count);

        }

        private void ocultarcolumnas()
        {
            this.dataListProyectos.Columns[0].Visible = false;
            this.dataListProyectos.Columns[2].Visible = false;
        }

        public void nuevoProyecto()
        {
            FrmDetalleProyecto detalleproyecto = new FrmDetalleProyecto();
            guardaDataList(detalleproyecto);
            FrmParent.frmparent.lanzarNuevoElemento(detalleproyecto);
            detalleproyecto.crearProyecto();
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
            this.dataListProyectos.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            this.dataListProyectos.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            this.dataListProyectos.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            this.dataListProyectos.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
        }
        /*Utilizado para mover el panel atraves de la pantalla*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        /*fin del drag*/



        private void dataListProyectos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListProyectos.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)dataListProyectos.Rows[e.RowIndex].Cells["Eliminar"];
                chkeliminar.Value = !Convert.ToBoolean(chkeliminar.Value);
            }
        }
        private void guardaDataList(FrmDetalleProyecto detalleProyecto)
        {
            DInformacionProyecto.dataListProyectos = dataListProyectos;
            if (DInformacionProyecto.dataListProyectos.RowCount != 0)
                DInformacionProyecto.index = this.dataListProyectos.CurrentRow.Index;
            DInformacionProyecto.detalleProyecto = detalleProyecto;
        }
        private void dataListProyectos_CellDoubleClick(object sender, EventArgs e)
        {
            try
            {
                FrmDetalleProyecto detalleProyecto = new FrmDetalleProyecto();

                guardaDataList(detalleProyecto);

                detalleProyecto.visualizaDatos(
                     Convert.ToString(this.dataListProyectos.CurrentRow.Cells["id"].Value),
                     Convert.ToString(this.dataListProyectos.CurrentRow.Cells["codigo_proyecto"].Value),
                     Convert.ToString(this.dataListProyectos.CurrentRow.Cells["titulo"].Value),
                     Convert.ToString(this.dataListProyectos.CurrentRow.Cells["observaciones"].Value),
                     Convert.ToString(this.dataListProyectos.CurrentRow.Cells["fecha"].Value)
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

        public void editarProyecto()
        {

            foreach (DataGridViewRow row in dataListProyectos.Rows)
            {
                if (Convert.ToBoolean(row.Selected))
                {
                    FrmDetalleProyecto detalleProyecto = new FrmDetalleProyecto();

                    guardaDataList(detalleProyecto);

                    detalleProyecto.visualizaDatos(
                         Convert.ToString(this.dataListProyectos.CurrentRow.Cells["id"].Value),
                         Convert.ToString(this.dataListProyectos.CurrentRow.Cells["codigo_proyecto"].Value),
                         Convert.ToString(this.dataListProyectos.CurrentRow.Cells["titulo"].Value),
                         Convert.ToString(this.dataListProyectos.CurrentRow.Cells["observaciones"].Value),
                         Convert.ToString(this.dataListProyectos.CurrentRow.Cells["fecha"].Value)
                         );


                    FrmParent.frmparent.lanzarNuevoElemento(detalleProyecto); 
                    StaticBarraHorizontal.horizontalParent.visualizaBotonesCambiarFormulario(false);
                    StaticBarraHorizontal.horizontalParent.visualizaBotonGuardar(true);
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
                    foreach (DataGridViewRow row in dataListProyectos.Rows)
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
       


        private void buscarProyecto(string texto)
        {
            this.dataListProyectos.DataSource = NProyecto.buscarproyecto(texto);
            this.ocultarcolumnas();
        }

        private void txtBuscarProyecto_TextChanged(object sender, EventArgs e)
        {
            this.buscarProyecto(this.txtBuscarProyecto.Text);
        }

        private void FrmProyecto_Load(object sender, EventArgs e)
        {

        }

    }
}
