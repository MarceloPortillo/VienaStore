using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VienaStore.C_Presentacion.Administrador;
using VienaStore.C_Presentacion.Vendedor;

namespace VienaStore.C_Negocio
{
    internal class CerrarInstancias
    {
        public static void InstanciasNull()
        {
            /*Pasan el estado de las instancias a null*/
            FBuscarUsuario.limpiar();
            FListarProductos.limpiar();
            FCrearUsuario.Limpiar();
            reportes.limpiar();
            Proveedores.limpiar();
            FEditarCLiente.limpiar();
            FListarClientes.limpiar();
            FBuscarClientes.limpiar();
            FNuevoCliente.limpiar();
        }
    }
}
