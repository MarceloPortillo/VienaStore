using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VienaStore.C_Presentacion;

namespace VienaStore.C_Datos
{
    public class Clientes
    {
        public int id { get; set; }

        public decimal dni { get; set; }//cambiar a tipo Varchar

        public string nombre { get; set; }

        public string apellido { get; set; }

        public string direccion  { get; set; }

        public string email { get; set; }

        public string telefono { get; set; }

        public string estado { get; set; } 
    }
}
