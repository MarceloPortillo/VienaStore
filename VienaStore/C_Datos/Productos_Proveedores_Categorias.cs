﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VienaStore.C_Datos
{
    internal class Productos_Proveedores_Categorias
    {
        public int codProducto { get; set; }

        public string nombreProducto { get; set; }

        public string descripcionProducto { get; set; }

        public int stockMin { get; set; }

        public int stock { get; set; }

        public float precioCosto { get; set; }

        public float precioVenta { get; set; }       

        public int id_proveedor { get; set; }

        public int id_Categoria { get; set; }
       

        public string nombreCategoria { get; set; }        

        public string nombreProveedor { get; set; }

        public string estado { get; set; }
    }
}

