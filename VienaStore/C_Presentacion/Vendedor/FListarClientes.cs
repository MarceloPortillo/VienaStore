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
    public partial class FListarClientes : Form
    {
        private static FListarClientes instancia = null;
        public static FListarClientes Ventana_unica()
        {



            if (instancia == null)
            {
                instancia = new FListarClientes();
                return instancia;
            }
            return instancia;
        }
        public FListarClientes()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            instancia = null;
            this.Close();
        }
    }
}
