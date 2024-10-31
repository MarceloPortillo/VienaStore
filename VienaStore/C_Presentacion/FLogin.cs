using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VienaStore.C_Presentacion.Administrador;
using VienaStore.C_Presentacion.Encargado;
using VienaStore.C_Presentacion.Vendedor;
using VienaStore.C_Negocio;
using VienaStore.C_Datos;

namespace VienaStore.C_Presentacion
{
    public partial class FLogin : Form
    {

        
        public FLogin()
        {
            InitializeComponent();
        }

        // Evento click del botón Ingresar
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            IngresarAlSistema();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            Hora.saludo(LblBuenDia);
        }

        private void IngresarAlSistema()
        {
            try
            {
                // Crear una instancia de UsuarioService
                UsuarioService usuarioService = new UsuarioService();

                // Obtener el usuario y la contraseña desde los campos de texto
                string usuario = TBUsuario.Text.Trim(); // Asegúrate de que no haya espacios en blanco
                string contrasenia = TBContrasenia.Text.Trim();

                // Llamar al método Login para validar las credenciales
                Usuario_Rol usuarioValidado = usuarioService.Login(usuario, contrasenia);

                // Si el usuario fue autenticado correctamente
                if (usuarioValidado != null)
                {
                    this.Hide(); // Oculta el formulario actual

                    // Redirige al formulario correspondiente según el rol del usuario
                    switch (usuarioValidado.id_rol)
                    {
                        case 1: // Rol Administrador
                            var menuAdmin = new menu_administrador();
                            menuAdmin.FormClosed += (s, args) => this.Close();
                            menuAdmin.Show();
                            break;

                        case 2: // Rol Encargado
                            var menuVendedor = new Menu_Vendedor();
                            menuVendedor.FormClosed += (s, args) => this.Close();
                            menuVendedor.Show();
                            break;

                        case 3: // Rol Vendedor
                            var menuEncargado = new menu_encargado();
                            menuEncargado.FormClosed += (s, args) => this.Close();
                            menuEncargado.Show();
                            break;

                        default:
                            MessageBox.Show("Rol no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Show();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no existe o contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







        private void TBUsuario_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TBContrasenia_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
