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

        private DataAccessUsuarios _dataAccesUsuarios;

        public BusinessUsuarios()
        {
            _dataAccesUsuarios = new DataAccessUsuarios();  
        }
        public void GuardarUsuario(Usuarios usuario)
        {
            try
            {
                if (usuario.id_usuario == 0)
                {
                    _dataAccesUsuarios.InsertUsuario(usuario);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Usuarios> GetUsuarios(string searchText = null)
        {
            return _dataAccesUsuarios.GetUsuarios(searchText);
        }
    }
}
