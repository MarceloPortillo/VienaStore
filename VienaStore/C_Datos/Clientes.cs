﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VienaStore.C_Datos
{
    internal class Clientes
    {
        public int id { get; set; }

        public decimal dni { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public string direccion  { get; set; }

        public string email { get; set; }

        public string telefono { get; set; }
    }
}