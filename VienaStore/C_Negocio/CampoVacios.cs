using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VienaStore.C_Datos;
using VienaStore.C_Presentacion.Administrador;

namespace VienaStore.C_Negocio
{
    public class CampoVacios
    {
        public TextBox nombre;
        public TextBox descripcion;
        public static bool ValidarCampoVacio(TextBox textBox, string nombreCampo)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show($"{nombreCampo} no puede estar vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static void CamposVacios(TextBox TxtApellido, TextBox TxtDNI, TextBox TxtNombre, TextBox TxtDireccion, MaskedTextBox TxtTelefono, TextBox TxtEmail)
        {
            if (string.IsNullOrWhiteSpace(TxtApellido.Text) ||
                string.IsNullOrWhiteSpace(TxtDNI.Text) ||
                string.IsNullOrWhiteSpace(TxtNombre.Text) ||
                string.IsNullOrWhiteSpace(TxtDireccion.Text) ||
                (string.IsNullOrWhiteSpace(TxtTelefono.Text) || !TxtTelefono.MaskFull) ||
                string.IsNullOrWhiteSpace(TxtEmail.Text))
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            return;
        }

        public static bool camposCategoria(TextBox nombre, TextBox descripcion)
        {
            if (string.IsNullOrWhiteSpace(nombre.Text) || string.IsNullOrWhiteSpace(descripcion.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
