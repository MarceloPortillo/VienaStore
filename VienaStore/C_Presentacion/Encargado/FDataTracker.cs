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

namespace VienaStore.C_Presentacion.Encargado
{
    public partial class FDataTracker : Form
    {
        private static FDataTracker instancia = null;
        public static FDataTracker Ventana_unica()
        {


            if (instancia == null)
            {
                instancia = new FDataTracker();
                return instancia;
            }


            return instancia;
        }
        public FDataTracker()
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
