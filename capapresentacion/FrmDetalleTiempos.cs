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
  
            txtObservaciones.Enabled = estado;

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

        public void desbloqueaBotones()
        {
            esnuevo = true;
            txtObservaciones.Enabled = true;
            botonesVisible(true);
            setModo("CREACIÓN");
            botones();
            limpiar();
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

        public void nuevoClicado()
        {
            esnuevo = true;
            txtObservaciones.Enabled = true;
            desbloqueaBotones();
            botonesVisible(true);
            setModo("CREACIÓN");
            botones();
            limpiar();
            botonNuevoClicado();

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }
        private string getTareaPersonal()
        {
            if (comboboxTareaPersonal.SelectedValue == null)
            {
                 return "";
             }
            return comboboxTareaPersonal.SelectedValue.ToString();
        }


        public void guardar()
        {
            string rpta = "";
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
            FrmParent.frmparent.AbrirFormulario(new FrmTiempos());
        }
        public void botonEditar()
        {
            this.eseditar = true;
            this.botones();
            setModo("EDICIÓN");
            botonesVisible(true);
            StaticBarraHorizontal.horizontalParent.visualizaBotonesCambiarFormulario(false);
            StaticBarraHorizontal.horizontalParent.visualizaBotonGuardar(true);
            mostrarTareaCombobox();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
          
                this.eseditar = true;
                this.botones();
                setModo("EDICIÓN");
                botonesVisible(true);
                mostrarTareaCombobox();
                
            
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

        public void cancelar()
        {
            dtFecha.Enabled = false;
            dtFechaInicio.Enabled = false;
            dtFechaFin.Enabled = false;
            dtFecha.Enabled = false;
            comboboxTareaPersonal.Enabled = false;
            comboboxTarea.Enabled = false;
            comboboxAccion.Enabled = false;
            checkImputado.Enabled = false;
            checkImputable.Enabled = false;
            txtObservaciones.ReadOnly = true;
            llamaVisualizaDatos();
        }

        public void mostrarTareaPersonalCombobox(string usuario, string tarea)
        {
            comboboxTareaPersonal.Items.AddRange(NTiempo.mostrarTareaPersonalCombobox(usuario, tarea).ToArray());
            //comboboxTareaPersonal.SelectedIndex = 0;

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

        public void botonEliminarTiempo()
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



        private void comboboxTarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("el usuario es :"+ DLoginStatico.usuario);
            
            mostrarTareaPersonalCombobox(DLoginStatico.usuario, comboboxTarea.SelectedItem.ToString());
        }

        public void llamaVisualizaDatos()
        {
            if (DInformacionTiempo.dataLisTiempos.RowCount != 0)
            {
                visualizaDatos(
                Convert.ToString(DInformacionTiempo.dataLisTiempos.Rows[DInformacionTiempo.index].Cells["fecha"].Value),
                Convert.ToString(DInformacionTiempo.dataLisTiempos.Rows[DInformacionTiempo.index].Cells["fechaInicio"].Value),
                Convert.ToString(DInformacionTiempo.dataLisTiempos.Rows[DInformacionTiempo.index].Cells["fechaFin"].Value),
                Convert.ToString(DInformacionTiempo.dataLisTiempos.Rows[DInformacionTiempo.index].Cells["tiempo"].Value),
                Convert.ToString(DInformacionTiempo.dataLisTiempos.Rows[DInformacionTiempo.index].Cells["Observaciones"].Value),
                Convert.ToString(DInformacionTiempo.dataLisTiempos.Rows[DInformacionTiempo.index].Cells["accion"].Value),
                Convert.ToString(DInformacionTiempo.dataLisTiempos.Rows[DInformacionTiempo.index].Cells["id"].Value),
                Convert.ToString(DInformacionTiempo.dataLisTiempos.Rows[DInformacionTiempo.index].Cells["id_tarea"].Value),
                Convert.ToString(DInformacionTiempo.dataLisTiempos.Rows[DInformacionTiempo.index].Cells["codigo_tarea"].Value),
                Convert.ToString(DInformacionTiempo.dataLisTiempos.Rows[DInformacionTiempo.index].Cells["imputable"].Value),
                Convert.ToString(DInformacionTiempo.dataLisTiempos.Rows[DInformacionTiempo.index].Cells["imputado"].Value));
            }

        }

        public void botonPrimero()
        {
                DInformacionTiempo.primerIndex();
                llamaVisualizaDatos();

        }

        public void botonAtras()
        {
            DInformacionTiempo.restaIndex();
            llamaVisualizaDatos();
        }

        public void botonSiguiente()
        {
            DInformacionTiempo.sumaIndex();
            llamaVisualizaDatos();
        }

        public void botonFinal()
        {
            DInformacionTiempo.finalIndex();
            llamaVisualizaDatos();
        }

        public void volver()
        {
            this.Close();
            FrmParent.frmparent.AbrirFormulario(new FrmTiempos());
        }
    }
}
