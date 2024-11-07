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
        private BusinessRol _businessRol;
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
            _businessRol = new BusinessRol();
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
            if (CampoVacios.CamposUsuario(TxtNombre, TxtApellido, TxtDNI, TxtNombre, TxtDireccion, TxtTelefono, TxtEmail, TxtUsuario))
            {
                DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas Modificar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                 
                if (confirmacion == DialogResult.Yes)
                {
                    SaveUsuario();
                    ListarUsuarios();
                    Limpiar.LimpiarUsuariosEditados(TxtNombre, TxtApellido, TxtDNI, TxtDireccion, FechaNacimiento, TxtEmail, TxtTelefono, TxtUsuario, textBox1, CboRol);
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
            ListarRoles();
        }

        public void ListarUsuarios()
        {
            try
            {
                List<Usuario_Rol> usuario = _businessUsuario.GetUsuarios();
                DtaUsuario.DataSource = usuario;
                DtaUsuario.Columns["fechaNacimiento"].Visible = false;
                DtaUsuario.Columns[0].Visible = false;
                DtaUsuario.Columns[9].Visible = false;
                DtaUsuario.Columns[4].Visible = false;
                DtaUsuario.Columns["id_rol"].Visible = false;
                DtaUsuario.AutoGenerateColumns = false;

                if (!DtaUsuario.Columns.Contains("BtnEstado"))
                {
                    DataGridViewButtonColumn btnEstadoColumn = new DataGridViewButtonColumn();
                    btnEstadoColumn.HeaderText = "ACCION";
                    btnEstadoColumn.Name = "BtnEstado";
                    btnEstadoColumn.UseColumnTextForButtonValue = false;
                    btnEstadoColumn.Width = 80;
                    DtaUsuario.Columns.Add(btnEstadoColumn);
                }
                foreach (DataGridViewRow row in DtaUsuario.Rows)
                {
                    if (row.DataBoundItem is Usuario_Rol usuarioItem)
                    {
                        string estado = usuarioItem.estado;
                        row.Cells["BtnEstado"].Value = estado == "Inactivo" ? "Activar" : "Eliminar";
                    }
                }

                foreach (DataGridViewColumn column in DtaUsuario.Columns)
                {
                    DtaUsuario.ClearSelection();
                    column.HeaderText = column.HeaderText.ToUpper();
                    DtaUsuario.Columns["descripcion"].HeaderText = "PERFIL";
                    DtaUsuario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

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
            string estado = Convert.ToString(fila.Cells["estado"].Value);

            if (estado.Trim() == "Inactivo")
            {
                MessageBox.Show("No puedes modificar un usuario inactivo", "Inactivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar.LimpiarUsuariosEditados(TxtNombre, TxtApellido, TxtDNI, TxtDireccion, FechaNacimiento, TxtEmail, TxtTelefono, TxtUsuario, textBox1, CboRol);
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
            textBox1.Text = fila.Cells["contrasenia"].Value != DBNull.Value
                              ? Convert.ToString(fila.Cells["contrasenia"].Value)
                               : string.Empty;
            CboRol.Text = Convert.ToString(fila.Cells["descripcion"].Value);
        }


        private void DtaUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DtaUsuario.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                int id = int.Parse(DtaUsuario.Rows[e.RowIndex].Cells["id_usuario"].Value.ToString());
                string estado = DtaUsuario.Rows[e.RowIndex].Cells["estado"].Value.ToString();
                if (estado == "Activo")
                {
                    DialogResult preg = MessageBox.Show("¿Esta seguro que quiere eliminar este Usuario?", "Confimar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (preg == DialogResult.Yes)
                    {
                        DtaUsuario.Rows[e.RowIndex].Cells["estado"].Value = "Inactivo";
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
                    DialogResult preg = MessageBox.Show("¿Esta seguro que quiere Activar este Usuario?", "Confimar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (preg == DialogResult.Yes)
                    {
                        DtaUsuario.Rows[e.RowIndex].Cells["estado"].Value = "Activo";
                        EliminarUsuario(id);
                        MessageBox.Show("Se ha Activado correctamente", "Reestablecido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        return;
                    }
                }
                foreach (DataGridViewRow row in DtaUsuario.Rows)
                {
                    if (row.DataBoundItem is Usuario_Rol usuarioItem)
                    {
                        string estadoActual = usuarioItem.estado;
                        row.Cells["btnEstado"].Value = estadoActual == "Inactivo" ? "Activar" : "Eliminar";
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
            if (CampoVacios.CamposUsuario(TxtApellido, TxtApellido, TxtDNI, TxtNombre, TxtDireccion, TxtTelefono, TxtEmail, TxtUsuario))
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
                usuario.contrasenia = textBox1.Text;
                usuario.id_rol = Convert.ToInt32(CboRol.SelectedValue);

                _businessUsuario.GuardarUsuario(usuario);
            }
            ListarRoles();
        }

        public void SaveUsuario()
        {
            GuardarUsuario();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            string buscarTex = TxtBuscar.Text;
            List<Usuario_Rol> UsuaruisEncontrados = _businessUsuario.GetUsuarios(buscarTex);
            DtaUsuario.DataSource = UsuaruisEncontrados;
            foreach (DataGridViewRow row in DtaUsuario.Rows)
            {
                if (row.DataBoundItem is Usuario_Rol usuarioItem)
                {
                    string estadoActual = usuarioItem.estado;
                    row.Cells["btnEstado"].Value = estadoActual == "Inactivo" ? "Activar" : "Eliminar";
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EliminarUsuario();
        }

        private void EliminarUsuario()
        {
            if (DtaUsuario.CurrentRow != null)
            {
                int id = int.Parse(DtaUsuario.CurrentRow.Cells[0].Value.ToString());
                DialogResult ask = MessageBox.Show("¿Seguro que desea eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    _businessUsuario.DeleteUsuario(id);
                    MessageBox.Show("El cliente ha sido eliminado exitosamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarUsuarios();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }        
        }

        public void ListarRoles(string buscarText = null)
        {
            List<Rol> listarRoles = _businessRol.GetRoles(buscarText);
            CboRol.DataSource = listarRoles;
            CboRol.DisplayMember = "descripcion";
            CboRol.ValueMember = "id_rol";

            CboRol.SelectedIndex = -1;
        }



    }
}
