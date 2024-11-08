using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VienaStore.C_Datos;

namespace VienaStore.C_Negocio
{
    internal class BusinessUsuarios
    {

        private DataAccessUsuarios _dataAccessUsuarios;

        public BusinessUsuarios()
        {
            _dataAccessUsuarios = new DataAccessUsuarios();  
        }
        public void GuardarUsuario(Usuarios usuario)
        {
            try
            {
                if (usuario.id_usuario == 0)
                {
                    _dataAccessUsuarios.InsertUsuario(usuario);
                    
                }
                else
                {
                    _dataAccessUsuarios.UpdateUsuario(usuario);
                }
                
            }
            catch (Exception ex)
            {

                // Lanzar la excepción con más contexto si es necesario
                throw new Exception(ex.Message);
            }
        }


        public List<Usuario_Rol> GetUsuarios(string searchText = null)
        {
            return _dataAccessUsuarios.GetUsuarios(searchText);
        }

        public void DeleteUsuario(int id)
        {
            _dataAccessUsuarios.DeleteUsuario(id);
        }

        public Usuario_Rol ValidarLogin(string usuario, string contrasenia)
        {
            // Encriptar la contraseña antes de enviarla a la capa de datos
            string contraseniaEncriptada = Encrypt.GetSHA256(contrasenia.Trim());
            // Llamar a la capa de datos para obtener el usuario validado
            return _dataAccessUsuarios.ObtenerUsuarioPorCredenciales(usuario, contraseniaEncriptada);
        }


    }
}
