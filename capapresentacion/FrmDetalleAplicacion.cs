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
    public partial class FrmDetalleAplicacion : Form
    {
        bool esnuevo = false;
        public FrmDetalleAplicacion()
        {
            InitializeComponent();
        }

        public void visualizaDatos(string id, string titulo, string panel)
        {
            txtIdAplicacion.Text = id;
            txtTituloAplicacion.Text = titulo;
            panelDescripcion.Text = panel;
        }

        public void guardar()
        {
            string rpta = "";
            
            if (esnuevo)
            {
                //Console.WriteLine(comboboxTareaPersonal.SelectedItem.ToString()+"console");
                rpta = NAplicacion.insertarAplicacion(txtTituloAplicacion.Text,panelDescripcion.Text);
            }
            else
            {
                rpta = NAplicacion.editarAplicacion(Convert.ToInt32(txtIdAplicacion.Text), txtTituloAplicacion.Text, panelDescripcion.Text);
            }

            if (rpta.Equals("OK"))
            {
                if (esnuevo)
                {
                    this.mensajeok("Se ha creado el Registro de Aplicacion satisfactoriamente");
                }
                else
                {
                    this.mensajeok("Se ha editado el Registro de Aplicacion satisfactoriamente");
                }

            }
            else
            {
                this.mensajeerror(rpta);
            }
            this.Close();
            StaticBarraHorizontal.horizontalParent.botonesPrincipal();
            FrmParent.frmparent.AbrirFormulario(new FrmAplicaciones());
        }
        private void mensajeok(string mensaje)
        {
            MessageBox.Show(mensaje, "Detalle de Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Detalle de Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void crearNuevo()
        {
            esnuevo = true;
           // botonesVisible(true);
          //  setModo("CREACIÓN");
          //  botones();
          //  limpiar();
        }

        public void desbloquear(bool valor)
        {
            txtTituloAplicacion.ReadOnly = !valor;
            panelDescripcion.ReadOnly = !valor;
        }

        public void cancelar()
        {
            desbloquear(false);
            llamaVisualizaDatos();
        }

        public void nuevaAplicacion()
        {
            desbloquear(true);
            txtTituloAplicacion.Text = string.Empty;
            txtIdAplicacion.Text = string.Empty;
            panelDescripcion.Text = string.Empty;
        }
        public void setModo(String modo)
        {
            lEdicion.Text = "[MODO " + modo + "]";
        }
        public void botonEditar()
        {
            this.esnuevo = false;
            desbloquear(true);
            setModo("EDICIÓN");
            StaticBarraHorizontal.horizontalParent.visualizaBotonesCambiarFormulario(false);
            StaticBarraHorizontal.horizontalParent.visualizaBotonGuardar(true);
        }
        public void llamaVisualizaDatos()
        {

            visualizaDatos(
                Convert.ToString(DInformacionAplicacion.datalistAplicaciones.Rows[DInformacionAplicacion.index].Cells["id"].Value),
                Convert.ToString(DInformacionAplicacion.datalistAplicaciones.Rows[DInformacionAplicacion.index].Cells["titulo"].Value),
                Convert.ToString(DInformacionAplicacion.datalistAplicaciones.Rows[DInformacionAplicacion.index].Cells["descripcion"].Value));

        }
        public void botonPrimero()
        {
            DInformacionAplicacion.primerIndex();
            llamaVisualizaDatos();
        }

        public void botonAtras()
        {
            DInformacionAplicacion.restaIndex();
            llamaVisualizaDatos();
        }

        public void botonSiguiente()
        {
            DInformacionAplicacion.sumaIndex();
            llamaVisualizaDatos();
        }

        public void botonFinal()
        {
            DInformacionAplicacion.finalIndex();
            llamaVisualizaDatos();
        }

        public void esNuevo()
        {
            esnuevo = true;
        }

        public void botonEliminar()
        {
          
                if (!txtIdAplicacion.Text.Equals(""))
                {
                    try
                    {
                        DialogResult opcion;
                        opcion = MessageBox.Show("¿Desea continuar?", "Eliminar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (opcion == DialogResult.OK)
                        {

                            string rpta = "";

                            rpta = NAplicacion.eliminaraplicacion(Convert.ToInt32(txtIdAplicacion.Text));

                            if (rpta.Equals("OK"))
                            {
                                this.mensajeok("Registro eliminado");
                                this.Close();
                                FrmParent.frmparent.AbrirFormulario(new FrmAplicaciones());
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

        public void volver()
        {
            this.Close();
            FrmParent.frmparent.AbrirFormulario(new FrmAplicaciones());
        }
    }
}
