using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VienaStore.C_Datos;

    namespace VienaStore.C_Negocio
    {

        public class BusinessRol
        {
            private DataAccessRol _dataAccessRol;

            // Constructor para inicializar la capa de datos
            public BusinessRol()
            {
                _dataAccessRol = new DataAccessRol();
            }

            // Método para obtener la lista de roles, con o sin búsqueda
            public List<Rol> GetRoles(string buscarText = null)
            {
                return _dataAccessRol.GetRoles(buscarText);
            }
        }
    }
