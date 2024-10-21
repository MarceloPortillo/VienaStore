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
            if (string.IsNullOrWhiteSpace(TxtApellido.Text) ||
                string.IsNullOrWhiteSpace(TxtDNI.Text) ||
                string.IsNullOrWhiteSpace(TxtNombre.Text) ||
                string.IsNullOrWhiteSpace(TxtDireccion.Text) ||
                string.IsNullOrWhiteSpace(TxtTelefono.Text) || !TxtTelefono.MaskFull ||
                string.IsNullOrWhiteSpace(TxtEmail.Text) ||
                string.IsNullOrWhiteSpace(TxtUsuario.Text) ||
                string.IsNullOrWhiteSpace(TxtContraseña.Text) ||
                CboRol.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult ask = MessageBox.Show("¿Seguro que desea editar el usuario" + " " + TxtNombre.Text + "?", "Confirmar modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ask == DialogResult.Yes)
            {
                MessageBox.Show("El Usuario: " + this.TxtNombre.Text + " " + this.TxtDNI.Text + " " + "Se modificó Correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TxtApellido.Clear();
                this.TxtNombre.Clear();
                this.TxtDNI.Clear();
                this.TxtDireccion.Clear();
                this.TxtEmail.Clear();
                this.TxtTelefono.Clear();
                this.TxtContraseña.Clear();
                this.TxtUsuario.Clear();
                return;
            }
            else
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
        }

        private void FBuscarUsuario_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }

        public void ListarUsuarios()
        {
            try
            {
                List<Usuarios> usuario = _businessUsuario.GetUsuarios();
                DtaUsuario.DataSource = usuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar usuarios: " + ex.Message);
            }
        }
    }
}
