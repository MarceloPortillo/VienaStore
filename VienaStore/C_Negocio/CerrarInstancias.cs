using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VienaStore.C_Presentacion;
using VienaStore.C_Presentacion.Administrador;
using VienaStore.C_Presentacion.Encargado;
using VienaStore.C_Presentacion.Vendedor;

namespace VienaStore.C_Negocio
{
    internal class CerrarInstancias
    {
        public static void InstanciasNull()
        {
            /*Pasan el estado de las instancias a null*/
            FGestionCategorias.limpiar();
            FBuscarProductoVendedor.limpiar();
            FAnularVenta.limpiar();
            FDataTracker.limpiar();
            FBuscarProductos.limpiar();
            FRegistrarVenta.limpiar();
            FBackUp.limpiar();
            FAgregarProducto.Limpiar();
            FBuscarUsuario.limpiar();
            FListarProductos.limpiar();
            CrearUsuarioNuevo.limpiar();
            reportes.limpiar();
            Proveedores.limpiar();
            FEditarCLiente.limpiar();
            FListarClientes.limpiar();
            FBuscarClientes.limpiar();
            FNuevoCliente.limpiar();
        }
    }
}
