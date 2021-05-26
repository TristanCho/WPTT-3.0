using System;
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
    public partial class FrmTiempos : Form
    {
        public FrmPrincipal frmparent;
        public FrmTiempos()
        {
            InitializeComponent();
            mostrartiempos();
            quitarBordes();
            reducirColumnas();
        }

        private void reducirColumnas()
        {
            this.dataListTiempos.Columns[5].Width = 200;
            this.dataListTiempos.Columns[8].Width = 60;
            this.dataListTiempos.Columns[10].Width = 60;
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

        private void FrmTiempos_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarX);
        }


        public void mostrartiempos()
        {
            this.dataListTiempos.DataSource = NTiempo.mostrartiempos();
            this.ocultarcolumnas();
            this.lblTotal.Text = "Número de registros: " + Convert.ToString(dataListTiempos.Rows.Count);
        }

        private void ocultarcolumnas()
        {
            this.dataListTiempos.Columns[0].Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmDetalleTiempos frmTiempos = new FrmDetalleTiempos();
            frmTiempos.desbloqueaBotones();
            frmTiempos.botonNuevoClicado();
            FrmParent.frmparent.lanzarNuevoElemento(frmTiempos);
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
            this.dataListTiempos.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            this.dataListTiempos.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            this.dataListTiempos.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            this.dataListTiempos.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
        }
        /*Utilizado para mover el panel atraves de la pantalla*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        /*fin del drag*/

        private void guardaDataList(FrmDetalleTiempos detalleTiempos)
        {
            DInformacionTiempo.dataLisTiempos = dataListTiempos;
            DInformacionTiempo.index = this.dataListTiempos.CurrentRow.Index;
            DInformacionTiempo.detalleTiempos = detalleTiempos;
        }
        public void nuevoTiempo()
        {

            FrmDetalleTiempos detalleTiempos = new FrmDetalleTiempos();
            guardaDataList(detalleTiempos);

            FrmParent.frmparent.lanzarNuevoElemento(detalleTiempos);
            detalleTiempos.nuevoClicado();
        }

        private void dataListTiempos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListTiempos.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)dataListTiempos.Rows[e.RowIndex].Cells["Eliminar"];
                chkeliminar.Value = !Convert.ToBoolean(chkeliminar.Value);
            }
        }

        private void dataListTiempos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FrmDetalleTiempos detalleTiempos = new FrmDetalleTiempos();

                guardaDataList(detalleTiempos);

                FrmParent.frmparent.lanzarNuevoElemento(detalleTiempos);
                detalleTiempos.setModo("LECTURA");

                detalleTiempos.visualizaDatos(
                Convert.ToString(this.dataListTiempos.CurrentRow.Cells["fecha"].Value),
                Convert.ToString(this.dataListTiempos.CurrentRow.Cells["fechaInicio"].Value),
                Convert.ToString(this.dataListTiempos.CurrentRow.Cells["fechaFin"].Value),
                Convert.ToString(this.dataListTiempos.CurrentRow.Cells["tiempo"].Value),
                Convert.ToString(this.dataListTiempos.CurrentRow.Cells["Observaciones"].Value),
                Convert.ToString(this.dataListTiempos.CurrentRow.Cells["accion"].Value),
                Convert.ToString(this.dataListTiempos.CurrentRow.Cells["id"].Value),
                Convert.ToString(this.dataListTiempos.CurrentRow.Cells["id_tarea"].Value),
                Convert.ToString(this.dataListTiempos.CurrentRow.Cells["codigo_tarea"].Value),
                Convert.ToString(this.dataListTiempos.CurrentRow.Cells["imputable"].Value),
                Convert.ToString(this.dataListTiempos.CurrentRow.Cells["imputado"].Value)
                );
                StaticBarraHorizontal.horizontalParent.visualizaBotonesCambiarFormulario(true);
                StaticBarraHorizontal.horizontalParent.visualizaBotonGuardar(false);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el evento Double click ", "Error en el evento Double click ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void buscarTiempo(string texto)
        {
            this.dataListTiempos.DataSource = NTiempo.buscartiempo(texto);
            this.ocultarcolumnas();
        }
        private void txtBuscarTiempo_TextChanged(object sender, EventArgs e)
        {
            this.buscarTiempo(this.txtBuscarTiempo.Text);
        }

        public void botonEliminarTiempo()
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Desea continuar?", "Eliminar Tiempo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int aux = 0;
                    string rpta = "";
                    foreach (DataGridViewRow row in dataListTiempos.Rows)
                    {
                        if (Convert.ToBoolean(row.Selected))
                        {
                            aux = 1;
                            rpta = NTiempo.eliminartiempo(Convert.ToInt32(row.Cells[8].Value));
                        }
                    }
                    if (rpta.Equals("OK"))
                    {
                        this.mensajeok("Registro eliminado");
                    }
                    else
                    {
                        this.mensajeerror("¡Ups!, No se ha podido eliminar el Tiempo");
                        this.mensajeerror(rpta);
                    }
                    if (aux < 1)
                    {
                        MessageBox.Show("No haz seleccionado ningún Tiempo", "Eliminar Tiempo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                    this.mostrartiempos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public void editarTiempo()
        {
            foreach (DataGridViewRow row in dataListTiempos.Rows)
            {
                if (Convert.ToBoolean(row.Selected))
                {
                    FrmDetalleTiempos detalleTiempos = new FrmDetalleTiempos();

                    DInformacionTiempo.dataLisTiempos = dataListTiempos;
                    DInformacionTiempo.index = this.dataListTiempos.CurrentRow.Index;
                    DInformacionTiempo.detalleTiempos = detalleTiempos;

                    FrmParent.frmparent.lanzarNuevoElemento(detalleTiempos);
                    detalleTiempos.setModo("LECTURA");

                    detalleTiempos.visualizaDatos(
                    Convert.ToString(this.dataListTiempos.CurrentRow.Cells["fecha"].Value),
                    Convert.ToString(this.dataListTiempos.CurrentRow.Cells["fechaInicio"].Value),
                    Convert.ToString(this.dataListTiempos.CurrentRow.Cells["fechaFin"].Value),
                    Convert.ToString(this.dataListTiempos.CurrentRow.Cells["tiempo"].Value),
                    Convert.ToString(this.dataListTiempos.CurrentRow.Cells["Observaciones"].Value),
                    Convert.ToString(this.dataListTiempos.CurrentRow.Cells["accion"].Value),
                    Convert.ToString(this.dataListTiempos.CurrentRow.Cells["id"].Value),
                    Convert.ToString(this.dataListTiempos.CurrentRow.Cells["id_tarea"].Value),
                    Convert.ToString(this.dataListTiempos.CurrentRow.Cells["codigo_tarea"].Value),
                    Convert.ToString(this.dataListTiempos.CurrentRow.Cells["imputable"].Value),
                    Convert.ToString(this.dataListTiempos.CurrentRow.Cells["imputado"].Value)
                    );
                    detalleTiempos.botonEditar();

                    break;
                }
            }
        }
    }
}
