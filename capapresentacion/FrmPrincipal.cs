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
using FontAwesome.Sharp;

using capanegocio;
using capadatos;
using WPTT_1._0;

namespace capapresentacion
{
    public partial class FrmPrincipal : Form
    {
        private IconButton botonActual;
        private Panel panelIzquierdo;
        private string nombreusuario;
        public Form formActivo;
        private bool barraAbierta = false;


       // private DLogin login;
        public string Nombreusuario { get => nombreusuario; set => nombreusuario = value; }
        //public DLogin Login { get => login; set => login = value; }



        public FrmPrincipal()
        {
            InitializeComponent();
            panelIzquierdo = new Panel();
            panelIzquierdo.Size = new Size(7, 60);
            panelMenu.Controls.Add(panelIzquierdo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Text = string.Empty;
            FrmParent.frmparent = this;
            /*
            StaticBarraHorizontal.horizontalParent= new FrmBarraHorizontal();
            barraHorizontal(StaticBarraHorizontal.horizontalParent);
            StaticBarraHorizontal.horizontalParent.visualizaBotonesCambiarFormulario(false);*/
        }
        public Form getFormularioActual()
        {
            Console.WriteLine(formActivo + " esto es el form devuelto");
            return formActivo;
        }

        public struct RGBColors
        {
            public static Color color1 = Color.White;
            public static Color color2 = Color.FromArgb(249, 118, 176);

        }
        public void lanzarNuevoElemento(Form formulario)
        {
            AbrirFormulario(formulario);
        }

        private void barraHorizontal(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBarraHorizontal.Controls.Add(childForm);
            panelBarraHorizontal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public void AbrirFormulario(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFormulario.Controls.Add(childForm);
            panelFormulario.Tag = childForm;
            formActivo = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        public void informacionLogin(string login,string bd)
        {
            Console.WriteLine(login);
            txtnombreusuario.Text = login;
        }

        public void cierraForm()
        {
            this.Hide();
        }
        public void ActivaBoton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                botonActual = (IconButton)senderBtn;
                botonActual.BackColor = Color.Chocolate;
                botonActual.ForeColor = color;
                botonActual.TextAlign = ContentAlignment.MiddleCenter;
                botonActual.IconColor = color;
                botonActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                botonActual.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                panelIzquierdo.BackColor = color;
                panelIzquierdo.Location = new Point(0, botonActual.Location.Y);
                panelIzquierdo.Visible = true;
                panelIzquierdo.BringToFront();
                //Current Child Form Icon
                iconoFormularioActual.IconChar = botonActual.IconChar;
                iconoFormularioActual.IconColor = color;
                textoInicio.Text = botonActual.Text;
            }
        }

        private void DisableButton()
        {
            if (botonActual != null)
            {
                botonActual.BackColor = Color.DarkOrange;
                botonActual.ForeColor = Color.Gainsboro;
                botonActual.TextAlign = ContentAlignment.MiddleLeft;
                botonActual.IconColor = Color.Gainsboro;
                botonActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                botonActual.ImageAlign = ContentAlignment.MiddleLeft;
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

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //mostrarproyectos();
            
            //this.FormClosed += new FormClosedEventHandler(cerrarX);
        }

        internal void enviaDatos(String texto)
        {
            
        }

     
/*Utilizado para mover el panel atraves de la pantalla*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        /*fin del drag*/


        private void Proyectos_Click(object sender, EventArgs e)
        {
            ActivaBoton(sender, RGBColors.color1);
            FrmProyecto proyecto = new FrmProyecto();
            //proyecto.frmparent = this;
           //--- FrmParent.frmparent = this;
            AbrirFormulario(proyecto);
            activaBarraHorizontal();
            StaticBarraHorizontal.horizontalParent.botonesPrincipal();
        }

        private void btnTareasPersonales_Click(object sender, EventArgs e)
        {
            ActivaBoton(sender, RGBColors.color1);
            FrmPersonal personales = new FrmPersonal();
            //--- tareas.frmparent = this;
            AbrirFormulario(personales);
            activaBarraHorizontal();
            StaticBarraHorizontal.horizontalParent.botonesPrincipal();
            //AbrirFormulario(new FrmTarea());
        }

        private void btnAplicaciones_Click(object sender, EventArgs e)
        {
            ActivaBoton(sender, RGBColors.color1);
            FrmAplicaciones aplicaciones = new FrmAplicaciones();
            //proyecto.frmparent = this;
            //--- FrmParent.frmparent = this;
            AbrirFormulario(aplicaciones);
            activaBarraHorizontal();
            StaticBarraHorizontal.horizontalParent.botonesPrincipal();
        }

       
        private void activaBarraHorizontal()
        {
            if (!barraAbierta) {
                Console.WriteLine("entrando a la barra");
            StaticBarraHorizontal.horizontalParent = new FrmBarraHorizontal();
            barraHorizontal(StaticBarraHorizontal.horizontalParent);
            StaticBarraHorizontal.horizontalParent.visualizaBotonesCambiarFormulario(false);
            barraAbierta = true;
            }
        }

        private void Tareas_Click(object sender, EventArgs e)
        {
            ActivaBoton(sender, RGBColors.color1);
            FrmTarea tareas = new FrmTarea();
           //--- tareas.frmparent = this;
            AbrirFormulario(tareas);
            activaBarraHorizontal();
            StaticBarraHorizontal.horizontalParent.botonesPrincipal();
            //AbrirFormulario(new FrmTarea());
        }


     

        private void Tiempos_Click(object sender, EventArgs e)
        {
            ActivaBoton(sender, RGBColors.color1);
            FrmTiempos tiempos = new FrmTiempos();
           //--- tiempos.frmparent = this;
            AbrirFormulario(tiempos);
            activaBarraHorizontal();
            StaticBarraHorizontal.horizontalParent.botonesPrincipal();
        }

        private void panelTitulo_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("Entrando en panelTitulo");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("Entrando en panel1");
        }


        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void detalleProyectos_Click_1(object sender, EventArgs e)
        {
            ActivaBoton(sender, RGBColors.color1);
            AbrirFormulario(new FrmDetalleProyecto());
        }

        private void miminizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void widgetBoton_Click(object sender, EventArgs e)
        {
            Widget widget = new Widget();
            widget.Show();
            this.cierraForm();
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }



    }
}
