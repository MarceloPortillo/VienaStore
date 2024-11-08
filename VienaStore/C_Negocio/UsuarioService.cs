using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VienaStore.C_Datos;

namespace VienaStore.C_Negocio
{
    internal class UsuarioService
    {

        private DataAccessUsuarios dataAccess = new DataAccessUsuarios();

        public Usuario_Rol Login(string usuario, string contrasenia)
        {
            // No encriptar la contraseña, pasarla directamente
            Usuario_Rol usuarioRol = dataAccess.ObtenerUsuarioPorCredenciales(usuario, contrasenia);

            if (usuarioRol == null)
            {
            //    MessageBox.Show("Usuario o contraseña incorrectos.");

            }

            return usuarioRol;
        }

    }
}

