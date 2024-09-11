using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                MessageBox.Show("Error: Ingrese solo números enteros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SoloLetras(KeyPressEventArgs f)
        {
            if (char.IsLetter(f.KeyChar))
            {
                f.Handled = false;
            }
            else if (char.IsControl(f.KeyChar))
            {
                f.Handled = false;
            }
            else if (f.KeyChar == ' ')
            {
                f.Handled = false;
            }
            else
            {
                f.Handled |= true;
                MessageBox.Show("Ingrese solo letras.", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

     
    }
    
   
}
