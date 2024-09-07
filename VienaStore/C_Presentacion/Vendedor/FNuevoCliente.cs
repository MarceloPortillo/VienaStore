using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VienaStore.C_Presentacion.Vendedor
{
    public partial class FNuevoCliente : Form
    {
        public FNuevoCliente()
        {
            InitializeComponent();
        }

        private void TxtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Negocio.Validaciones.SoloNumeros(e);
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Negocio.Validaciones.SoloNumeros(e);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombre.Text) ||
                string.IsNullOrWhiteSpace(TxtApellido.Text) ||
                string.IsNullOrWhiteSpace(TxtDNI.Text) ||
                string.IsNullOrWhiteSpace(TxtDireccion.Text) ||
                string.IsNullOrWhiteSpace(TxTelefono.Text) ||
                string.IsNullOrWhiteSpace(TxtEmail.Text))
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult ask = MessageBox.Show("¿Seguro que desea insertar un nuevo Cliente?", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ask == DialogResult.Yes)
            {
                MessageBox.Show("El Cliente: " + this.TxtNombre.Text + " " + this.TxtApellido.Text + " " + "Se inserto Correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                this.TxtApellido.Clear();
                this.TxtNombre.Clear();
                this.TxtDNI.Clear();
            }


           
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Negocio.Validaciones.SoloLetras(e);
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Negocio.Validaciones.SoloLetras(e);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FNuevoCliente_Load(object sender, EventArgs e)
        {
            TxtNombre.Focus();
        }
    }
}
