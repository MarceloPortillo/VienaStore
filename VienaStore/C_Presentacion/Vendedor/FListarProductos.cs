using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VienaStore.C_Presentacion.Vendedor
{
    public partial class FListarProductos : Form
    {
        private static FListarProductos instancia = null;
        public static FListarProductos Ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new FListarProductos();
                return instancia;
            }
            return instancia;
        }
        public FListarProductos()
        {
            InitializeComponent();
        }

        private void FListarProductos_Load(object sender, EventArgs e)
        {
           /* base.OnLoad(e);*/
        }
        public static void limpiar()
        {
            instancia = null;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
        }
    }
}
