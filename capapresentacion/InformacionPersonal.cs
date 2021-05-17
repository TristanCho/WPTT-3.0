using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace capapresentacion
{

    class InformacionPersonal
    {
        public static DataGridView dataListPersonal;
        public static int index;
        public static FrmDetalleTarea detallePersonal;



        public static void sumaIndex()
        {
            if (!(dataListPersonal.Rows.Count <= InformacionPersonal.index + 1))
            {
                index += 1;
            }
            else
            {
                MessageBox.Show("Ultimo registro alcanzado", "Tareas Personales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public static void restaIndex()
        {
            if (!(0 > InformacionPersonal.index - 1))
            {
                index -= 1;
            }
            else
            {
                MessageBox.Show("Primer registro alcanzado", "Tareas Personalesa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        public static void finalIndex()
        {
            index = dataListPersonal.Rows.Count - 1;
        }

        public static void primerIndex()
        {
            index = 0; ;
        }
    }
}
