using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VienaStore.C_Negocio;

namespace VienaStore.C_Presentacion.Vendedor
{
    public partial class FBuscarProductoVendedor : VienaStore.C_Presentacion.Administrador.FBuscarProductos
    {
        private static FBuscarProductoVendedor instancia = null;
        public static FBuscarProductoVendedor Ventana_unica()
        {


            if (instancia == null)
            {
                instancia = new FBuscarProductoVendedor();
                return instancia;
            }


            return instancia;
        }
        public FBuscarProductoVendedor()
        {
            InitializeComponent();
        }

        public static void limpiar()
        {
            instancia = null;
        }
    }
}
