using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capadatos;
using capanegocio;

namespace capapresentacion
{
    public partial class Login : Form
    {

        SqlConnection con = new SqlConnection("Data Source=PCCRISTHIAN\\SQLEXPRESS;Initial Catalog=ilernaV2;Integrated Security=False;User Id=winplus;Password=Pbjjajlp5h4m1");
        
        //SqlConnection con = new SqlConnection("Data Source=MSI\\SQLMSI;Initial Catalog=ilernaV2;Integrated Security=False;User Id=winplus;Password=Pbjjajlp5h4m1");
         
        //TODO ENCAPSULACIÓN EN CAPA DE DATOS Y NO DDUPLICAR LA CONEXIÓN
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NLogin login = new NLogin();
            if (login.logueo(usuario.Text, Dns.GetHostName()))
            {
                DLoginStatico.sacaTecnico(usuario.Text);
                FrmPrincipal principal = new FrmPrincipal();
                DLoginStatico.usuario = usuario.Text;
                principal.Show();
                this.Hide();
            };
            //sacamos el hostname
            //String hostName = ;
            //Console.WriteLine(hostName);
          
        }

        private void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Text = String.Empty;
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        /*Utilizado para mover el panel atraves de la pantalla*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
