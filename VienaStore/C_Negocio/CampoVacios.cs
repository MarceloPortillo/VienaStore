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

        public static bool CamposUsuario(TextBox nombre, TextBox apellido, TextBox dni, TextBox direccion, TextBox email, MaskedTextBox telefono, TextBox usuario, TextBox contrasenia)
        {
            if (string.IsNullOrWhiteSpace(nombre.Text) ||
                string.IsNullOrWhiteSpace(apellido.Text) ||
                string.IsNullOrWhiteSpace(dni.Text) ||
                string.IsNullOrWhiteSpace(direccion.Text) ||
                string.IsNullOrWhiteSpace(email.Text) ||
                string.IsNullOrWhiteSpace(telefono.Text) ||
                string.IsNullOrWhiteSpace(usuario.Text) ||
                string.IsNullOrWhiteSpace(contrasenia.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
            }

        
        public static bool camposProveedor(TextBox nombre, TextBox cuit, TextBox direccion, TextBox telefono, TextBox email)
        {
            if (string.IsNullOrWhiteSpace(nombre.Text) || string.IsNullOrWhiteSpace(cuit.Text) || string.IsNullOrWhiteSpace(direccion.Text) || string.IsNullOrWhiteSpace(telefono.Text) || string.IsNullOrWhiteSpace(email.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool CamposVaciosProducto(TextBox descripcion, TextBox precioCompra, TextBox precioVenta, TextBox codProducto, TextBox stockMin, TextBox stock, ComboBox comCategoria, ComboBox comProveedor)
        {
            if (  string.IsNullOrWhiteSpace(descripcion.Text) ||
                  string.IsNullOrWhiteSpace(stock.Text) ||
                  string.IsNullOrWhiteSpace(precioCompra.Text) ||
                  string.IsNullOrWhiteSpace(precioVenta.Text) ||
                  string.IsNullOrWhiteSpace(codProducto.Text) ||
                   comCategoria.SelectedIndex == -1 ||
                   string.IsNullOrWhiteSpace(stockMin.Text) ||
                   comProveedor.SelectedIndex == -1)
                   
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool CampoVacioAgregarStock(TextBox stock)
        {
           if (string.IsNullOrWhiteSpace(stock.Text))
            {
                MessageBox.Show("Debe agregar el stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
}
}
