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
using VienaStore.C_Negocio;

namespace VienaStore.C_Presentacion.Encargado
{
    public partial class FAnularVenta : Form
    {
        private static FAnularVenta instancia = null;
        public static FAnularVenta Ventana_unica()
        {


            if (instancia == null)
            {
                instancia = new FAnularVenta();
                return instancia;
            }


            return instancia;
        }
        public FAnularVenta()
        {
            InitializeComponent();
        }

        private void BtnSalirAnularVenta_Click(object sender, EventArgs e)
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
