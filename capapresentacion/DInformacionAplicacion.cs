using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capapresentacion
{
    public static class DInformacionAplicacion
    {
        public static DataGridView datalistAplicaciones;
        public static int index;
        public static FrmDetalleAplicacion detalleAplicacion;
        public static void sumaIndex()
        {
            if (!(datalistAplicaciones.Rows.Count <= index + 1))
            {
                index += 1;
            }
            else
            {
                MessageBox.Show("Ultimo registro alcanzado", "Detalle de Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static void restaIndex()
        {
            if (!(0 > index - 1))
            {
                index -= 1;
            }
            else
            {
                MessageBox.Show("Primer registro alcanzado", "Detalle de Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static void primerIndex()
        {
            index = 0;
        }

        public static void finalIndex()
        {
            index = datalistAplicaciones.Rows.Count - 1;
        }
    }
}
