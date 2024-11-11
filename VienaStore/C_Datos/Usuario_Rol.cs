using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VienaStore.C_Datos
{
    internal class Usuario_Rol
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

        public int id_rol { get; set; }

        public string descripcion { get; set; }

        public string estado { get; set; }

        public string NombreCompleto
        {
            get { return $"{nombre} {apellido}"; }
        }

    }
}
