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
    public partial class FBuscarClientes : Form
    {
        private static FBuscarClientes instancia = null;
        public static FBuscarClientes Ventana_unica()
        {



            if (instancia == null)
            {
                instancia = new FBuscarClientes();
                return instancia;
            }
            return instancia;
        }
        public FBuscarClientes()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            instancia = null;
            this.Close();
        }
    }
}
