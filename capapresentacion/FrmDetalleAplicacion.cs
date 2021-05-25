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
                rpta = NAplicacion.editarAplicacion();
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
            FrmParent.frmparent.AbrirFormulario(new FrmTiempos());
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
    }
}
