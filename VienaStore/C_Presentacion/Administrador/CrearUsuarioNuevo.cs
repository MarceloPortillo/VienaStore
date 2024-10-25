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
using VienaStore.C_Negocio;
using System.Runtime.Remoting.Contexts;
using VienaStore.C_Datos;

namespace VienaStore.C_Presentacion.Administrador
{
    public partial class CrearUsuarioNuevo : Form
    {
        private BusinessUsuarios _businessUsuarios;
        private Usuarios _usuario;
        private BusinessRol _businessRol;
        private Rol _rol;
        private static CrearUsuarioNuevo instancia = null;
        public static CrearUsuarioNuevo Ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new CrearUsuarioNuevo();
                return instancia;
            }
            return instancia;
        }
        public CrearUsuarioNuevo()
        {
            InitializeComponent();
            _businessUsuarios = new BusinessUsuarios();
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
            GuardarNuevoUsuario();
            ListarUsuarios();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
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

        private void GuardarNuevoUsuario()
        {
            if (!CampoVacios.CamposUsuario(TxtNombre, TxtApellido, TxtDNI, TxtDireccion, TxtEmail, TxtTelefono, TxtUsuario, TxtContraseña) || Validaciones.ValidarLength(TxtNombre.Text, 3))
            {

                return;
            }

            Usuarios usuario = new Usuarios();

            usuario.nombre = TxtNombre.Text;
            usuario.apellido = TxtApellido.Text;

            decimal DNI = 0;
            if (decimal.TryParse(TxtDNI.Text, out DNI))
            {
               usuario.dni = DNI;
            }
            usuario.direccion = TxtDireccion.Text;
            usuario.email = TxtEmail.Text;
            usuario.telefono = TxtTelefono.Text;
            usuario.usuario = TxtUsuario.Text;
            usuario.contrasenia = TxtContraseña.Text;
            usuario.fechaNacimiento = dateTimePicker1.Value;
            usuario.id_rol = Convert.ToInt32(CboRol.SelectedValue);

            try
            {
                DialogResult ask = MessageBox.Show("¿Seguro que desea insertar un nuevo Usuario?", "Confirmar inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    _businessUsuarios.GuardarUsuario(usuario);
                     Dialogos.DialogoUsuario(TxtUsuario.Text);
                     Limpiar.LimpiarUsuarios(TxtNombre, TxtApellido, TxtDNI, TxtDireccion, dateTimePicker1, TxtEmail, TxtTelefono, TxtUsuario, TxtContraseña, CboRol);
                }
            }
            catch (Exception)
            {
               // MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ListarRoles(string buscarText = null)
        {
            List<Rol> listaRoles = _businessRol.GetRoles(buscarText);
            CboRol.DataSource = listaRoles;
            CboRol.DisplayMember = "descripcion";  
            CboRol.ValueMember = "id_rol"; 
        }

        private void CrearUsuarioNuevo_Load(object sender, EventArgs e)
        {
            ListarRoles();
            ListarUsuarios();
        }

        private void RecuperarInformacion()
        {
            Usuarios usuario = new Usuarios();

            usuario.nombre = TxtNombre.Text;
            usuario.apellido = TxtApellido.Text;

            int DNI = 0;
            if (int.TryParse(TxtDNI.Text, out DNI))
            {
                usuario.dni = DNI;
            }

            usuario.direccion = TxtDireccion.Text;
            usuario.email = TxtEmail.Text;
            usuario.telefono = TxtTelefono.Text;
            usuario.usuario = TxtUsuario.Text;
            usuario.contrasenia = TxtContraseña.Text;
            usuario.id_rol = Convert.ToInt32(CboRol.SelectedValue);
            usuario.fechaNacimiento = dateTimePicker1.Value;

            MessageBox.Show(usuario.nombre);
            MessageBox.Show(usuario.apellido);
            MessageBox.Show(usuario.dni.ToString());
            MessageBox.Show(usuario.direccion);
            MessageBox.Show(usuario.email);
            MessageBox.Show(usuario.telefono);
            MessageBox.Show(usuario.usuario);
            MessageBox.Show(usuario.contrasenia);
            MessageBox.Show(usuario.id_rol.ToString());
            MessageBox.Show(usuario.fechaNacimiento.ToString("dd/MM/yyyy"));
        }

        public void ListarUsuarios()
        {
            try
            {
                List<Usuario_Rol> usuario = _businessUsuarios.GetUsuarios();
                DtaUsuario.DataSource = usuario;
                DtaUsuario.Columns[11].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar usuarios: " + ex.Message);
            }
        }
    }
}
