using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VienaStore.C_Datos;
using VienaStore.C_Negocio;
using VienaStore.C_Presentacion;

namespace VienaStore.C_Presentacion.Vendedor
{    
    public partial class FRegistrarVenta : Form
    {
        private static FRegistrarVenta instancia = null;
        public static FRegistrarVenta Ventana_unica()
        {


            if (instancia == null)
            {
                instancia = new FRegistrarVenta();
                return instancia;
            }


            return instancia;
        }
        public FRegistrarVenta()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
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
