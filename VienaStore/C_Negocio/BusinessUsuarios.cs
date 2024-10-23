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
                    //     _dataAccessUsuarios.UpdateUsuario(usuario);
                }
                
            }
            catch (Exception)
            {

                // Lanzar la excepción con más contexto si es necesario
                //throw new Exception("Error al guardar el usuario: " + ex.Message);
            }
        }


        public List<Usuarios> GetUsuarios(string searchText = null)
        {
            return _dataAccessUsuarios.GetUsuarios(searchText);
        }
    }
}
