using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VienaStore.C_Datos;

namespace VienaStore.C_Negocio
{
    internal class BusinessProductos
    {
        private DataAccessProductos _dataAccessProducto;

        public BusinessProductos() 
        {

            _dataAccessProducto = new DataAccessProductos();
        }

        public void GuardarProducto(Productos producto)
        {
            try
            {
                if (producto.codProducto == 0)
                {
                    _dataAccessProducto.InsertarProducto(producto);
                    
                }
                else 
                {
                    _dataAccessProducto.UpdateProductos(producto);
                }
                
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Productos_Proveedores_Categorias> GetProductos(string searchText = null)
        {
            return _dataAccessProducto.GetProductos(searchText);
        }

        public void DeleteProducto(int idProducto)
        {
            _dataAccessProducto.DeleteProducto(idProducto);
        }

    }
}
