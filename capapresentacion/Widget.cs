using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Timers;
using capadatos;
using capanegocio;
using static capapresentacion.WidgetPosition;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace capapresentacion
{
    public partial class Widget : Form
    {

        System.Timers.Timer temporizador;


        //SqlConnection con = new SqlConnection("Data Source=MSI\\SQLMSI;Initial Catalog=IlernaV2;Integrated Security=False;User Id=winplus;Password=Pbjjajlp5h4m1");
        SqlConnection con = new SqlConnection("data source=PCCRISTHIAN\\SQLEXPRESS; initial catalog=DesarrollosTime;user id=winplus;password=Pbjjajlp5h4m1");

        public Widget()
        {
            InitializeComponent();
            convertirWidget();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {   /*Cronometro*/
            temporizador = new System.Timers.Timer();
            temporizador.Interval = 1000;
            temporizador.Elapsed += OnTimeEvent;
            /*Cronometro*/
            
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("pruebaguardaje.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            MyObject obj = (MyObject)formatter.Deserialize(stream);
            stream.Close();
            this.Location = new Point(obj.x, obj.y);
            //Console.WriteLine("n1: {0}", obj.x);
            //Console.WriteLine("n2: {0}", obj.y);
            try
            {
                con.Open();
                SqlCommand query = new SqlCommand("SELECT* FROM Tareas where id_tecnico=@id order by fecha_creacion desc", con);
                query.Parameters.Add("@id", SqlDbType.VarChar).Value = DLoginStatico.id;
                Console.WriteLine(DLoginStatico.id + " este es el id");
                SqlDataReader reader;
                reader = query.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("titulo", typeof(string));

                dt.Load(reader);


                listaTareasPersonales.DisplayMember = "titulo";
                listaTareasPersonales.ValueMember = "titulo";

                listaTareasPersonales.DataSource = dt;

                con.Close();
            }
            catch (Exception)
            {

            }
            if (TiempoStatic.IsWorking)
            {

            }
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                lCronometro.Text = (DateTime.Now - TiempoStatic.StartDate).ToString(@"hh\:mm\:ss");//string.Format("{0}:{1}:{2}",hora.ToString().PadLeft(2, '0'), minuto.ToString().PadLeft(2, '0'),segundo.ToString().PadLeft(2, '0'));
            }));
        }


        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        MessageBox.Show("doble click derecho");
                    }
                    break;
            }
            this.Show();
            WindowState = FormWindowState.Normal;

        }

        private void convertirWidget()
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            TopMost = true;
            ShowInTaskbar = false;
            this.Text = String.Empty;
            this.ControlBox = false;
            moverVentanaAbajoDerecha();

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            this.Close();
            frmPrincipal.Show();
        }

        private void miminizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
        }

        private void moverVentanaAbajoDerecha()
        {

            Screen rightmost = Screen.AllScreens[0];
            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen.WorkingArea.Right > rightmost.WorkingArea.Right)
                    rightmost = screen;
            }

            this.Left = rightmost.WorkingArea.Right - this.Width;
            this.Top = rightmost.WorkingArea.Bottom - this.Height;
        }



        private void botonApagar_Click(object sender, EventArgs e)
        {
            pararCronometro();
            NWidget nw = new NWidget();
            nw.insertaTiempoTarea(listaTareasPersonales.SelectedValue.ToString(), TiempoStatic.StartDate, DateTime.Now);
            TiempoStatic.StartDate = DateTime.Now;
            TiempoStatic.IsWorking = false;
            botonStart.Visible = true;
            botonApagar.Visible = false;

        }

        private void botonStart_Click(object sender, EventArgs e)
        {
            iniciaCronometro();


            TiempoStatic.StartDate = DateTime.Now;
            TiempoStatic.IsWorking = true;
            botonStart.Visible = false;
            botonApagar.Visible = true;

        }

        private void iniciaCronometro()
        {
            temporizador.Start();

        }

        private void pararCronometro()
        {
            temporizador.Stop();
        }

        private void modoAplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            this.Close();
            frmPrincipal.Show();
        }

        /*Utilizado para mover el panel atraves de la pantalla*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iniciarCronometroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaCronometro();
            TiempoStatic.StartDate = DateTime.Now;
            TiempoStatic.IsWorking = true;
            botonStart.Visible = false;
            botonApagar.Visible = true;
        }

        private void Widget_FormClosing(object sender, FormClosingEventArgs e)
        {
            //temporizador.Stop();
            MyObject obj = new MyObject();
            obj.y = this.Top;
            obj.x = this.Left;


            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("pruebaguardaje.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, obj);
            stream.Close();

        }

        private void pararCronometroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pararCronometro();
            NWidget nw = new NWidget();
            nw.insertaTiempoTarea(listaTareasPersonales.SelectedValue.ToString(), TiempoStatic.StartDate, DateTime.Now);
            TiempoStatic.StartDate = DateTime.Now;
            TiempoStatic.IsWorking = false;
            botonStart.Visible = true;
            botonApagar.Visible = false;
        }

        private void tCronometro_TextChanged(object sender, EventArgs e)
        {

        }
        /*fin del drag*/
    }
}
