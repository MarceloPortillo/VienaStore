using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VienaStore.C_Presentacion.Administrador;

namespace VienaStore.C_Presentacion
{
    public partial class FBackUp : Form
    {
        private static FBackUp instancia = null;
        public static FBackUp Ventana_unica()
        {

            if (instancia == null)
            {
                instancia = new FBackUp();
                return instancia;
            }
            return instancia;
        }
        public FBackUp()
        {
            InitializeComponent();
        }

        private void FBackUp_Load(object sender, EventArgs e)
        {

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
