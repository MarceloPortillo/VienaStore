using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VienaStore.C_Negocio
{
    internal class Validaciones
    {
        public static void SoloNumeros(KeyPressEventArgs f)
        {
            if (char.IsNumber(f.KeyChar))
            {
                f.Handled = false;
            }
            else if (char.IsControl(f.KeyChar))
            {
                f.Handled = false;
            }
            else
            {
                f.Handled = true;
                MessageBox.Show("Error: Solo puede ingresar Números enteros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
