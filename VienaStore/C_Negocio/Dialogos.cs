using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VienaStore.C_Negocio
{
    internal class Dialogos
    {
        public string respuesta;
        public static void DialogoCategoria(string respuesta)
        {
            MessageBox.Show(respuesta + " se agregó Correctamente",    "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
