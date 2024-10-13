using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using VienaStore.C_Datos;

namespace VienaStore.C_Negocio
{
    public class BusinessCategoria
    {
        private DataAccessCategoria _dataAccessCategoria;

        public BusinessCategoria()
        {
            _dataAccessCategoria = new DataAccessCategoria();
        }
        public void guardar(Categorias categoria)
        {
            try
            {
                if (categoria.id_Categoria == 0)
                {

                    _dataAccessCategoria.InsertarCategoria(categoria);
                }
                else
                {
                    // _dataAccessCategoria.UpdateCategoria()

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
