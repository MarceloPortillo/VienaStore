using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VienaStore.C_Datos;

namespace VienaStore.C_Negocio
{
    internal class BusinessProveedores
    {
        private DataAccesProveedores _dataAccesProveedores;

        public BusinessProveedores()
        {
            _dataAccesProveedores = new DataAccesProveedores();
        }
        public void GuardarProveedor(Proveedores proveedor)
        {
            if (proveedor.id_proveedor == 0) 
            {
                _dataAccesProveedores.InsertarProveedor(proveedor);
            }
            else
            {
               _dataAccesProveedores.UpdateProveedor(proveedor);
            }
        }

        public List<Proveedores> GetProveedores()
        {
            return _dataAccesProveedores.GetProveedores();
        }

        public void DeleteProveedor(int id)
        {
            _dataAccesProveedores.DeleteProveedor(id);
        }

        public List<Proveedores> GetProveedores(string buscarText = null)
        {
            return _dataAccesProveedores.BuscarProveedor(buscarText);
            
        }
    }
}
