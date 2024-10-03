using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VienaStore.C_Negocio;

namespace VienaStore.C_Presentacion.Vendedor
{    
    public partial class FBuscarClientes : Form
    {
        private static FBuscarClientes instancia = null;
        public static FBuscarClientes Ventana_unica()
        {



            if (instancia == null)
            {
                instancia = new FBuscarClientes();
                return instancia;
            }
            return instancia;
        }
        public FBuscarClientes()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
        }
        public static void limpiar()
        {
            instancia = null;
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void TxtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(TxtEmail.Text) && !C_Negocio.Validaciones.ValidarEmail(TxtEmail.Text))
            {
                MessageBox.Show("Dirección de correo electrónico no es válida. El correo debe tener el formato: nombre@dominio.com",
                                "Validación de correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtEmail.SelectAll();
                TxtEmail.Focus();
            }
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Negocio.Validaciones.SoloNumeros(e);
        }

        private void button1_Click(object sender, EventArgs e)
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

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.TxtApellido.Clear();
            this.TxtNombre.Clear();
            this.TxtDNI.Clear();
            this.TxtDireccion.Clear();
            this.TxtEmail.Clear();
            this.TxtTelefono.Clear();
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            CampoVacios.CamposVacios(TxtApellido, TxtDNI, TxtNombre, TxtDireccion, TxtTelefono, TxtEmail);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                // Confirmar si el usuario desea eliminar la fila
                DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar la fila seleccionada?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    // Eliminar la fila
                    dataGridView1.Rows.RemoveAt(rowIndex);

                    // O si tienes enlazado el DataGridView a una fuente de datos, puedes eliminar de la fuente también
                    // dataTable.Rows[rowIndex].Delete(); // En caso de que esté ligado a un DataTable
                }
            }
            else
            {
                // Mostrar un mensaje si no se ha seleccionado ninguna fila
                MessageBox.Show("Por favor, seleccione una fila para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

