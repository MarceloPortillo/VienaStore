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
    public partial class menu_administrador : VienaStore.C_Presentacion.Vendedor.Menu_Vendedor
    {
        public menu_administrador()
        {
            InitializeComponent();
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            CerrarOtrosFormularios();

            Proveedores nuevo = Proveedores.Ventana_unica();
            nuevo.TopLevel = false;

            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(nuevo);
            //nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void BtnModificarCliente_Click(object sender, EventArgs e)
        {
            CerrarOtrosFormularios();

            reportes nuevo = reportes.Ventana_unica();
            nuevo.TopLevel = false;

            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(nuevo);
            //nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void BtnCrearUsuario_Click(object sender, EventArgs e)
        {
            FCrearUsuario nuevo = FCrearUsuario.Ventana_unica1();
            nuevo.TopLevel = false;

            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(nuevo);
            //nuevo.MdiParent = this;
            nuevo.Show();

        }
    }
}
