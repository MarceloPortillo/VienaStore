using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VienaStore.C_Presentacion.Administrador;
using VienaStore.C_Presentacion.Encargado;
using VienaStore.C_Presentacion.Vendedor;
using VienaStore.C_Presentacion;
using VienaStore.C_Datos;


namespace VienaStore.C_Negocio
{
    internal class Login
    {
        public static void registro(string usuario, string contrasenia)
        {
            // Simulación de la verificación del rol del usuario
            // Definimos usuarios y contraseñas estáticos
            string usuarioAdministrador = "admin";
            string contraseñaAdministrador = "123";

            string usuarioEncargado = "encargado";
            string contraseñaEncargado = "encargado123";

            string usuarioVendedor = "vendedor";
            string contraseñaVendedor = "123";

            // Obtenemos los valores ingresados
            string usuarioIngresado = usuario;
            string contraseñaIngresada = contrasenia;

            // Verificación para usuario Administrador
            if (usuarioIngresado == usuarioAdministrador && contraseñaIngresada == contraseñaAdministrador)
            {
                // Abre el formulario de InicioAdministrador
                menu_administrador formAdmin = new menu_administrador();
                formAdmin.Show();
                return;

            }
            // Verificación para usuario Encargado
            else if (usuarioIngresado == usuarioEncargado && contraseñaIngresada == contraseñaEncargado)
            {
                // Abre el formulario de InicioEncargado
                menu_encargado formEncargado = new menu_encargado();
                formEncargado.Show();
                return;

            }
            // Verificación para usuario Vendedor
            else if (usuarioIngresado == usuarioVendedor && contraseñaIngresada == contraseñaVendedor)
            {
                // Abre el formulario de InicioVendedor
                Menu_Vendedor formVendedor = new Menu_Vendedor();
                formVendedor.Show();
                return;
            }
            else if (string.IsNullOrWhiteSpace(usuarioIngresado) ||
                     string.IsNullOrWhiteSpace(contraseñaIngresada))
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // Si los datos no coinciden, mostramos un mensaje de error
                FLogin otro = new FLogin();
                otro.Show();
                return;
            }
            MessageBox.Show("Usuario o contraseña incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            FLogin nuevo = new FLogin();
            nuevo.Show();
            return;
        }
    }
}