using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VienaStore.C_Negocio
{
    internal class Producto
    {
        public static void ValidarStock(int stockMin, int stockMax)
        {
            
            if (stockMin > stockMax)
            {
                MessageBox.Show("El stock Minimo debe ser menor al stock Mayorista");
                return;
            }else
            {
                return;
            }
        }
    }
}
