using System.Collections.Generic;
using VienaStore.C_Datos;

namespace VienaStore.C_Negocio
{
    public class BusinessFormaPago
    {
        private DataAccessFormaPago dataAccessFormaPago;

        public BusinessFormaPago()
        {
            dataAccessFormaPago = new DataAccessFormaPago();
        }

        // Método para obtener los tipos de pago
        public List<FormaPago> ObtenerTiposPago()
        {
            return dataAccessFormaPago.ObtenerTiposPago();
        }
    }
}
