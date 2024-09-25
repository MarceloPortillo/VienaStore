using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VienaStore.C_Presentacion.Vendedor;

namespace VienaStore.C_Presentacion.Administrador
{
    public partial class FCrearUsuario : VienaStore.C_Presentacion.Vendedor.FNuevoCliente
    {
        public FCrearUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.TxtApellido.Clear();
            this.TxtNombre.Clear();
            this.TxtDNI.Clear();
            this.TxtDireccion.Clear();
            this.TxtEmail.Clear();
            this.TxtTelefono.Clear();
            this.TxtContraseña.Clear();
            this.TxtUsuario.Clear();
        }

        public override void BtnGuardar_Click(object sender, EventArgs e)
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

            // Cambiar mensaje de confirmación e inserción para "Proveedor"
            DialogResult ask = MessageBox.Show("¿Seguro que desea insertar un nuevo Usuario?", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ask == DialogResult.Yes)
            {
                MessageBox.Show("El Usuario: " + this.TxtUsuario.Text + " " + "DNI" + " " +  this.TxtDNI.Text + " " + "Se inserto Correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos igual que en la clase padre
                this.TxtApellido.Clear();
                this.TxtNombre.Clear();
                this.TxtDNI.Clear();
                this.TxtDireccion.Clear();
                this.TxtEmail.Clear();
                this.TxtTelefono.Clear();
                return;
            }
            else
            {
                // Limpiar los campos igual que en la clase padre
                this.TxtApellido.Clear();
                this.TxtNombre.Clear();
                this.TxtDNI.Clear();
                this.TxtDireccion.Clear();
                this.TxtEmail.Clear();
                this.TxtTelefono.Clear();
            }
        }

    }
}
