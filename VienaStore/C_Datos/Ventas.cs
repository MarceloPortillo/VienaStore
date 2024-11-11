using System.Collections.Generic;
using System;

namespace VienaStore.C_Datos
{
    internal class Ventas
    {
        public int IdVenta { get; set; }
        public float Total { get; set; }
        public DateTime Fecha { get; set; }
        public byte Estado { get; set; }
        public int? IdPago { get; set; }
        public int IdUsuario { get; set; }
        public int? IdFactura { get; set; }
        public int IdCliente { get; set; }
        public List<VentaDetalle> DetallesVenta { get; set; }  // Relación con los detalles de la venta

        public Ventas()
        {
            DetallesVenta = new List<VentaDetalle>();  // Inicializa la lista de detalles
        }
    }
}


