using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VienaStore.C_Datos
{
    internal class Ventas_Categorias
    {
        public int id_Categoria { get; set; }
        public string nombreCategoria { get; set; }
        public string descripcion { get; set; }
        public string estadoCategoria { get; set; } // Renombrado para diferenciar

        public int codProducto { get; set; }
        public string nombreProducto { get; set; }
        public string descripcionProducto { get; set; }
        public int stockMin { get; set; }
        public int stock { get; set; }
        public float precioCosto { get; set; }
        public float precioVenta { get; set; }
        public int id_proveedor { get; set; }

        public int IdVentaDetalle { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public float Subtotal { get; set; }
        public byte estadoVentaDetalle { get; set; } // Renombrado para diferenciar

        public float Total { get; set; } // Agregado para almacenar el total en la consulta
    }

}
