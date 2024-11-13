using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VienaStore.C_Datos
{
    internal class usuarios_ventas
    {
        public int id_usuario { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public decimal dni { get; set; }

        public string direccion { get; set; }

        public string email { get; set; }

        public string telefono { get; set; }

        public string usuario { get; set; }

        public DateTime fechaNacimiento { get; set; }

        public string contrasenia { get; set; }

        public string estadoUsuario { get; set; }

        public int id_rol { get; set; }

        public int IdVenta { get; set; }
        public float Total { get; set; }
        public DateTime Fecha { get; set; }
        public byte Estado { get; set; }
        public int? IdPago { get; set; }
        public int IdUsuario { get; set; }
        public int? IdFactura { get; set; }
        public int IdCliente { get; set; }
        public List<VentaDetalle> DetallesVenta { get; set; }
    }
}
