using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VienaStore.C_Datos;
using VienaStore.C_Negocio;

namespace VienaStore.C_Negocio
{
    internal class Validaciones
    {
        private DataAccesClientes dataAcces;
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
                MessageBox.Show("Error: Ingrese solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public static bool ValidarEmail(string email)
        {
            string expresion = @"^[\w\.-]+@[a-zA-Z\d\.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, expresion);
        }


        public static void numerosDecimales(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Error: Ingrese solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool ValidarLength(string nombre, int numero)
        {                     
            if (nombre.Length < numero)
            {
                MessageBox.Show("El nombre debe tener al menos 3 caracteres.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                return true;
            }
            return false;
        }

    }
}
