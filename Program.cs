using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using capapresentacion;

namespace WPTT_1._0
{
    public static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrincipal());
           // Application.Run(new Login());


        }   
        /*
        public static void setPosicionInicial()
            {
            
                //string initLocation = string.Join(",", x, y);
               // Properties.Settings.Default.WidgetInitialLotacion = StaticPosicion.posicion;
               // Properties.Settings.Default.Save();
            
        }
        public static string getPosicionInicial()
        {
            return Properties.Settings.Default.WidgetInitialLotacion;
        }*/
    }
}
