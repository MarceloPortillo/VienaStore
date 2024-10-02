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
            // Simulación de la verificación del rol del usuario
            // Definimos usuarios y contraseñas estáticos
            string usuarioAdministrador = "admin";
            string contraseñaAdministrador = "admin123";

            string usuarioEncargado = "encargado";
            string contraseñaEncargado = "encargado123";

            string usuarioVendedor = "vendedor";
            string contraseñaVendedor = "vendedor123";

            // Obtenemos los valores ingresados
            string usuarioIngresado = TBUsuario.Text;
            string contraseñaIngresada = TBContrasenia.Text;

            // Verificación para usuario Administrador
            if (usuarioIngresado == usuarioAdministrador && contraseñaIngresada == contraseñaAdministrador)
            {
                // Abre el formulario de InicioAdministrador
                menu_administrador formAdmin = new menu_administrador();
                formAdmin.Show();
                this.Hide(); // Oculta el formulario de login
            }
            // Verificación para usuario Encargado
            else if (usuarioIngresado == usuarioEncargado && contraseñaIngresada == contraseñaEncargado)
            {
                // Abre el formulario de InicioEncargado
                menu_encargado formEncargado = new menu_encargado();
                formEncargado.Show();
                this.Hide(); // Oculta el formulario de login
            }
            // Verificación para usuario Vendedor
            else if (usuarioIngresado == usuarioVendedor && contraseñaIngresada == contraseñaVendedor)
            {
                // Abre el formulario de InicioVendedor
                Menu_Vendedor formVendedor = new Menu_Vendedor();
                formVendedor.Show();
                this.Hide(); // Oculta el formulario de login
            }
            else
            {
                // Si los datos no coinciden, mostramos un mensaje de error
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
