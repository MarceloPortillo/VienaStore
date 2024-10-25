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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace VienaStore.C_Presentacion.Administrador
{
    public partial class FBuscarUsuario : Form
    {
        private BusinessUsuarios _businessUsuario;
        private static FBuscarUsuario instancia = null;
        public static FBuscarUsuario Ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new FBuscarUsuario();
                return instancia;
            }
            return instancia;
        }
        public FBuscarUsuario()
        {
            InitializeComponent();
            _businessUsuario = new BusinessUsuarios();
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

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
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

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (CampoVacios.CamposUsuario(TxtApellido, TxtDNI, TxtNombre, TxtDireccion, TxtTelefono, TxtEmail, TxtUsuario))
            {
                DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas Modificar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                 
                if (confirmacion == DialogResult.Yes)
                {
                    SaveUsuario();
                    ListarUsuarios();
                    Limpiar.LimpiarUsuariosEditados(TxtNombre, TxtApellido, TxtDNI, TxtDireccion, FechaNacimiento, TxtEmail, TxtTelefono, TxtUsuario, CboRol);
                    MessageBox.Show("Modificación Exitosa", "¡Felicitaciones!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No puede guardar sin haber modificado antes", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FBuscarUsuario_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }

        public void ListarUsuarios()
        {
            try
            {
                List<Usuario_Rol> usuario = _businessUsuario.GetUsuarios();
                DtaUsuario.DataSource = usuario;
                DtaUsuario.Columns[11].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar usuarios: " + ex.Message);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DtaUsuario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow fila = DtaUsuario.SelectedRows[0];
            string estado = Convert.ToString(fila.Cells["BtnActivarDesactivar"].Value);

            if (estado.Trim() == "Inactivo")
            {
                MessageBox.Show("No puedes modificar un usuario inactivo", "Inactivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar.LimpiarUsuariosEditados(TxtNombre, TxtApellido, TxtDNI, TxtDireccion, FechaNacimiento, TxtEmail, TxtTelefono, TxtUsuario, CboRol);
                return;
            }

            TxtNombre.Text = Convert.ToString(fila.Cells["nombre"].Value);
            TxtApellido.Text = Convert.ToString(fila.Cells["apellido"].Value);
            TxtDNI.Text = Convert.ToString(fila.Cells["dni"].Value);
            TxtDireccion.Text = Convert.ToString(fila.Cells["direccion"].Value);
            TxtEmail.Text = Convert.ToString(fila.Cells["email"].Value);
            TxtTelefono.Text = Convert.ToString(fila.Cells["telefono"].Value);
            TxtUsuario.Text = Convert.ToString(fila.Cells["usuario"].Value);
            FechaNacimiento.Value = Convert.ToDateTime(fila.Cells["fechaNacimiento"].Value).Date;
            CboRol.Text = Convert.ToString(fila.Cells["descripcion"].Value);
        }


        private void DtaUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DtaUsuario.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                int id = int.Parse(DtaUsuario.Rows[e.RowIndex].Cells["id_usuario"].Value.ToString());
                string estado = DtaUsuario.Rows[e.RowIndex].Cells["estadoDataGridViewTexBoxColumn"].Value.ToString();
                if (estado == "Activo")
                {
                    DialogResult preg = MessageBox.Show("¿Esta seguro que quiere eliminar este Usuario?", "Confimar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (preg == DialogResult.Yes)
                    {
                        DtaUsuario.Rows[e.RowIndex].Cells["estadoDataGridViewTexBoxColumn"].Value = "Inactivo";
                        EliminarUsuario(id);
                        MessageBox.Show("Se ha eliminado correctamente", "Elminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        return;
                    }
                }
                else if (estado == "Inactivo")
                {
                    DialogResult preg = MessageBox.Show("¿Esta seguro que quiere Activar esta Categoría?", "Confimar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (preg == DialogResult.Yes)
                    {
                        DtaUsuario.Rows[e.RowIndex].Cells["estadoDataGridViewTexBoxColumn"].Value = "Activo";
                        EliminarUsuario(id);
                        MessageBox.Show("Se ha Activado correctamente", "Reestablecido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private void EliminarUsuario(int id)
        {
            _businessUsuario.DeleteUsuario(id);
        }

        private void GuardarUsuario()
        {
            if (CampoVacios.CamposUsuario(TxtApellido, TxtDNI, TxtNombre, TxtDireccion, TxtTelefono, TxtEmail, TxtUsuario))
            { 
            Usuarios usuario = new Usuarios();
                usuario.id_usuario = Convert.ToInt32(DtaUsuario.CurrentRow.Cells["id_usuario"].Value);
                usuario.nombre = TxtNombre.Text;
                usuario.apellido = TxtApellido.Text;
                usuario.dni = Convert.ToInt32(DtaUsuario.CurrentRow.Cells["dni"].Value);
                usuario.direccion = TxtDireccion.Text;
                usuario.email = TxtEmail.Text;
                usuario.telefono = TxtTelefono.Text;
                usuario.usuario = TxtUsuario.Text;
                usuario.fechaNacimiento = FechaNacimiento.Value;
                usuario.id_rol = CboRol.TabIndex;

                _businessUsuario.GuardarUsuario(usuario);
            }
        }

        public void SaveUsuario()
        {
            GuardarUsuario();
        }


    }
}
