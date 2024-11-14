using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VienaStore.C_Datos;

namespace VienaStore.C_Negocio
{
    internal class UsuarioLogeado
    {
        public static Usuario_Rol Usuario { get; set; }

        public static int IdUsuario
        {
            get
            {
                return Usuario != null ? Usuario.id_usuario : 0;
            }
        }

    }


}
