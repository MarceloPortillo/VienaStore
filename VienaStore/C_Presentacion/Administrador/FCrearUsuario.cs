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

namespace VienaStore.C_Presentacion.Administrador
{
    public partial class FCrearUsuario : VienaStore.C_Presentacion.Vendedor.FNuevoCliente
    {
        public FCrearUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.TxtApellido.Clear();
            this.TxtNombre.Clear();
            this.TxtDNI.Clear();
            this.TxtDireccion.Clear();
            this.TxtEmail.Clear();
            this.TxtTelefono.Clear();
            this.TxtContraseña.Clear();
            this.TxtUsuario.Clear();
        }
    }
}
