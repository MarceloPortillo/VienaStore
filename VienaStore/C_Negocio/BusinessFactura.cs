using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VienaStore.C_Datos;

namespace VienaStore.C_Negocio
{
    public class BusinessFactura
    {
        private DataAccessFactura dataAccess;

        public BusinessFactura()
        {
            dataAccess = new DataAccessFactura();
        }

        public List<Factura> ObtenerTiposFactura()
        {
            return dataAccess.ObtenerTiposFactura();
        }


        public int ObtenerIdFacturaPorDescripcion(string descripcionFactura)
        {
            // Llamamos a la capa de datos para obtener el ID
            DataAccessFactura dataAccessFactura = new DataAccessFactura();
            return dataAccessFactura.ObtenerIdFacturaPorDescripcion(descripcionFactura);
        }
    }
}

