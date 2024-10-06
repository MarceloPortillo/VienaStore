using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VienaStore.C_Presentacion;

namespace VienaStore.C_Negocio
{
    internal class Limpiar
    {
        public static void limpiarAgregarProducto(TextBox campo1, TextBox campo2, TextBox campo3, TextBox campo4, TextBox campo5, TextBox campo6, TextBox campo7, ComboBox campo8, ComboBox campo9)
        {
            campo1.Clear();
            campo2.Clear();
            campo3.Clear();
            campo4.Clear();
            campo5.Clear();
            campo6.Clear();
            campo7.Clear();
            campo8.ResetText();
            campo9.ResetText();
        }
    }
}
