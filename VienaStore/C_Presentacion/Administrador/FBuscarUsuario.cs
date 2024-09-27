using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VienaStore.C_Presentacion.Administrador
{
    public partial class FBuscarUsuario : Form
    {
        private static FBuscarUsuario instancia = null;
        public static FBuscarUsuario Ventana_unica()
        {



            if (instancia == null)
            {
                instancia = new FBuscarUsuario();
                return instancia;
            }
            return instancia;
        }
        public FBuscarUsuario()
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
