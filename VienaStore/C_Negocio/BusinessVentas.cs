using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using VienaStore.C_Datos;

namespace VienaStore.C_Negocio
{
    internal class BusinessVentas
    {
        private DataAccessVentas _dataAccessVentas;
        private DataAccessVentaDetalle _dataAccessVentaDetalle;

        public BusinessVentas()
        {
            _dataAccessVentas = new DataAccessVentas();
            _dataAccessVentaDetalle = new DataAccessVentaDetalle();
        }

        public void ConfirmarVenta(Ventas venta)
        {
            try
            {
                if (venta.IdCliente == 0)
                {
                    throw new Exception("El cliente no está asignado.");
                }

                _dataAccessVentas.InsertarVenta(venta);

                DataAccessProductos dataAccessProductos = new DataAccessProductos();

                foreach (var detalle in venta.DetallesVenta)
                {
                    detalle.IdVenta = venta.IdVenta;

                    _dataAccessVentaDetalle.InsertarVentaDetalle(detalle);

                    dataAccessProductos.ActualizarStock(detalle.IdProducto, detalle.Cantidad);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al confirmar la venta: " + ex.Message);
            }
        }
    }
}
