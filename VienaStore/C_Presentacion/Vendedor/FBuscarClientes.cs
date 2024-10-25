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

        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Negocio.Validaciones.SoloNumeros(e);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCliente();
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
            EditarCliente();
        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EliminarCLiente();
        }

        private void FBuscarClientes_Load(object sender, EventArgs e)
        {
            ListarContactos();
            dataGridView1.ClearSelection();
        }

        public void ListarContactos(string searchText = null)
        {
            List<Clientes> clientes = businessCliente.GetClientes(searchText);
            dataGridView1.DataSource = clientes;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si se ha hecho clic en la columna del botón de estado
            if (e.ColumnIndex == dataGridView1.Columns["Estado"].Index && e.RowIndex >= 0)
            {
                // Recupera el valor de la fila seleccionada
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                string estadoActual = dataGridView1.Rows[e.RowIndex].Cells["estado"].Value.ToString();

                // Determina la acción a tomar según el estado actual
                if (estadoActual == "Inactivo")
                {
                    DialogResult ask = MessageBox.Show("¿Desea activar este cliente?", "Activar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ask == DialogResult.Yes)
                    {
                        // Cambiar el estado a 'activo'
                        businessCliente.CambiarEstadoCliente(id, "Activo");
                        MessageBox.Show("El cliente ha sido activado.", "Activación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarContactos(); // Refresca la lista de clientes
                    }
                }
                else if (estadoActual == "Activo")
                {
                    DialogResult ask = MessageBox.Show("¿Desea eliminar este cliente?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ask == DialogResult.Yes)
                    {
                        // Cambiar el estado a 'inactivo'
                        businessCliente.CambiarEstadoCliente(id, "Inactivo");
                        MessageBox.Show("El cliente ha sido desactivado.", "Desactivación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarContactos(); // Refresca la lista de clientes
                    }
                }
            }
        }


        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ListarContactos(TxtBuscar.Text);
            TxtBuscar.Text = string.Empty;
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            // Obtener el texto actual del TextBox
            string terminoBusqueda = TxtBuscar.Text.Trim();

            // Llamar al método GetClientes con el término de búsqueda
            List<Clientes> clientesFiltrados = businessCliente.GetClientes(terminoBusqueda);

            // Actualizar la DataGridView con los clientes filtrados
            dataGridView1.DataSource = clientesFiltrados;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica que la columna que estás formateando sea la columna del botón 'Estado'
            if (dataGridView1.Columns[e.ColumnIndex].Name == "estado")
            {
                // Obtén el valor de la celda de estado (que es donde se encuentra el botón)
                string estado = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                // Verifica si la fila es 'Inactiva' o 'Activa' y aplica color solo al botón de esa columna
                if (estado == "Inactivo")
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red; // Color para inactivos
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
                }
                else if (estado == "Activo")
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightGreen; // Color para activos
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
                }
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Verifica que la columna que estás pintando sea la columna del botón 'Estado'
            if (e.ColumnIndex == dataGridView1.Columns["estado"].Index && e.RowIndex >= 0)
            {
                // Obtén el valor de la celda de estado
                string estado = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                // Pinta el botón manualmente según el estado
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                if (estado == "Inactivo")
                {
                    // Pinta el fondo del botón rojo
                    e.Graphics.FillRectangle(Brushes.Red, e.CellBounds);
                }
                else if (estado == "Activo")
                {
                    // Pinta el fondo del botón verde
                    e.Graphics.FillRectangle(Brushes.LightGreen, e.CellBounds);
                }

                // Dibuja el borde y el texto del botón
                e.Graphics.DrawRectangle(Pens.Black, e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width, e.CellBounds.Height);
                TextRenderer.DrawText(e.Graphics, estado, e.CellStyle.Font, e.CellBounds, Color.Black, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                // Evita que el sistema dibuje el botón por defecto
                e.Handled = true;
            }
        }

        private void GuardarCliente()
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
            cliente.nombre = TxtNombre.Text.ToUpper();
            cliente.apellido = TxtApellido.Text.ToUpper();
            cliente.direccion = TxtDireccion.Text.ToUpper();
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

        private void EditarCliente() 
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

                // Verifica si el cliente está inactivo
                if (estado.ToLower() == "inactivo")
                {
                    MessageBox.Show("No se puede editar un cliente inactivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Salir sin permitir la edición
                }

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
        }

        private void EliminarCLiente() 
        {
            if (dataGridView1.CurrentRow != null) // Verifica que haya una fila seleccionada
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                DialogResult ask = MessageBox.Show("¿Seguro que desea eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    businessCliente.EliminarCliente(id);
                    MessageBox.Show("El cliente ha sido eliminado exitosamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarContactos(); // Refrescar la lista de clientes
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtEmail.Text) && !C_Negocio.Validaciones.ValidarEmail(TxtEmail.Text))
            {
                MessageBox.Show("Dirección de correo electrónico no es válida. El correo debe tener el formato: nombre@dominio.com",
                                "Validación de correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtEmail.SelectAll();
                TxtEmail.Focus();
            }
        }
    }
}