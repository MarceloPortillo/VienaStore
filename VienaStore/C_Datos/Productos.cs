using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VienaStore.C_Datos
{
    internal class Productos
    {
        public int codProducto { get; set; }

        public string nombreProducto { get; set; } 

        public string descripcionProducto { get; set; }

        public int stockMin { get; set; }

        public int stock { get; set; }

        public float precioCosto { get; set; }

        public float precioVenta { get; set; }

        public string estado { get; set; }

        public int id_proveedor {  get; set; }

        public int id_Categoria {  get; set; }
    }
}
