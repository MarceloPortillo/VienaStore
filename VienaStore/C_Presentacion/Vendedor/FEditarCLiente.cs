using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VienaStore.C_Datos;
using VienaStore.C_Negocio;

namespace VienaStore.C_Presentacion.Vendedor
{
    public partial class FEditarCLiente : VienaStore.C_Presentacion.Vendedor.FNuevoCliente
    {
        private BusinessCliente businessCliente;
        private Clientes _cliente;
        public FEditarCLiente()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            // Verificar si los campos están vacíos
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

            Clientes cliente = new Clientes();

            if (!decimal.TryParse(TxtDNI.Text, out decimal dni))
            {
                MessageBox.Show("El DNI ingresado no tiene un formato numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cliente.dni = dni;
            cliente.nombre = TxtNombre.Text;
            cliente.apellido = TxtApellido.Text;
            cliente.direccion = TxtDireccion.Text;
            cliente.email = TxtEmail.Text;
            cliente.telefono = TxtTelefono.Text;
            cliente.id = _cliente != null ? _cliente.id : 0;

            DialogResult ask = MessageBox.Show("¿Seguro que desea modificar un nuevo Cliente?", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ask == DialogResult.Yes)
            {
                businessCliente.GuardarCliente(cliente);
                MessageBox.Show("El Cliente: " + this.TxtApellido.Text + " " + this.TxtDNI.Text + " se modificó Correctamente",
                                "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.TxtApellido.Clear();
                this.TxtNombre.Clear();
                this.TxtDNI.Clear();
                this.TxtDireccion.Clear();
                this.TxtEmail.Clear();
                this.TxtTelefono.Clear();
            }
            else
            {
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
