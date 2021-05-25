using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capapresentacion;

namespace capadatos
{
    public static class DInformacionTiempo
    {
        public static DataGridView dataLisTiempos;
        public static int index;
        public static FrmDetalleTiempos detalleTiempos;

        public static void sumaIndex()
        {
            if (!(dataLisTiempos.Rows.Count <= DInformacionTiempo.index + 1))
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
            if (!(0 > DInformacionTiempo.index - 1))
            {
                index -= 1;
            }
            else{
                MessageBox.Show("Primer registro alcanzado", "Detalle de Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }      
        }
        public static void primerIndex()
        {
                index = 0;
        }

        public static void finalIndex()
        {
            index = dataLisTiempos.Rows.Count-1;
        }       
        public static string  getFinalCount()
        {
            return dataLisTiempos.Rows.Count+"";
        }


    }
}
