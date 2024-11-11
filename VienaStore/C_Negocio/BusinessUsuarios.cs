using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            string contraseniaEncriptada = Encrypt.GetSHA256(contrasenia.Trim());

            return _dataAccessUsuarios.ObtenerUsuarioPorCredenciales(usuario, contraseniaEncriptada);
        }

        public string ObtenerNombreCompleto(string usuario)
        {
            return _dataAccessUsuarios.GetNombreCompleto(usuario);
        }
    }
}
