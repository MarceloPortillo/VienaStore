using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VienaStore.C_Presentacion.Vendedor;
using VienaStore.C_Presentacion;

namespace VienaStore.C_Presentacion.Administrador
{
    public partial class FBuscarProductos : Form
    {
        private static FBuscarProductos instancia = null;
        public static FBuscarProductos Ventana_unica()
        {


            if (instancia == null)
            {
                instancia = new FBuscarProductos();
                return instancia;
            }


            return instancia;
        }
        public FBuscarProductos()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
        }
        public static void limpiar()
        {
            instancia = null;
        }
    }
}
