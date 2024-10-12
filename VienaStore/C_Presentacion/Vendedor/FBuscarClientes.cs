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
using VienaStore.C_Presentacion;

namespace VienaStore.C_Presentacion.Vendedor
{    
    public partial class FBuscarClientes : Form
    {
        private BusinessCliente businessCliente;
        private Clientes _cliente;
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
            businessCliente = new BusinessCliente();
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

        private void BtnGuardar_Click(object sender, EventArgs e)
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

            Clientes cliente = _cliente != null ? _cliente : new Clientes();

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

            DialogResult ask = MessageBox.Show("¿Seguro que desea modificar el Cliente?", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                ListarContactos();
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
            if (dataGridView1.CurrentRow != null) // Verifica que haya una fila seleccionada
            {
                // Recupera los valores de la fila seleccionada
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                int dni = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                string nombre = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string apellido = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string direccion = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                string email = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                string telefono = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                string estado = dataGridView1.CurrentRow.Cells[7].Value.ToString();

                // Carga los datos en el formulario o en los campos
                TxtNombre.Text = nombre;
                TxtApellido.Text = apellido;
                TxtDNI.Text = dni.ToString();
                TxtDireccion.Text = direccion;
                TxtEmail.Text = email;
                TxtTelefono.Text = telefono;


                _cliente = new Clientes();
                _cliente.id = id; // Aquí guardas el id del cliente seleccionado
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //CampoVacios.CamposVacios(TxtApellido, TxtDNI, TxtNombre, TxtDireccion, TxtTelefono, TxtEmail);
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
                }
            }
            else
            {
                // Mostrar un mensaje si no se ha seleccionado ninguna fila
                MessageBox.Show("Por favor, seleccione una fila para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void LimpiarFormulario1()
        {
            TxtNombre.Text = string.Empty;
            TxtApellido.Text = string.Empty;
            TxtDNI.Text = string.Empty;
            TxtDireccion.Text = string.Empty;
            TxtEmail.Text = string.Empty;
            TxtTelefono.Text = string.Empty;
        }

        private void FBuscarClientes_Load(object sender, EventArgs e)
        {
            ListarContactos();
        }

        public void ListarContactos(string searchText = null)
        {
            List<Clientes> clientes = businessCliente.GetClientes(searchText);
            dataGridView1.DataSource = clientes;
        }

        private void LimpiarFormulario()
        {
            TxtNombre.Text = string.Empty;
            TxtApellido.Text = string.Empty;
            TxtDNI.Text = string.Empty;
            TxtDireccion.Text = string.Empty;
            TxtEmail.Text = string.Empty;
            TxtTelefono.Text = string.Empty;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ListarContactos(TxtBuscar.Text);
            TxtBuscar.Text = string.Empty;
        }
    }
}

