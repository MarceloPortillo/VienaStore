using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VienaStore.C_Negocio;
using VienaStore.C_Presentacion.Vendedor;
using VienaStore.C_Presentacion.Administrador;

namespace VienaStore.C_Presentacion.Encargado
{
    public partial class menu_encargado : VienaStore.C_Presentacion.Administrador.menu_administrador
    {
        public menu_encargado()
        {
            InitializeComponent();
        }

        private void BtnInformes_Click(object sender, EventArgs e)
        {
            CerrarOtrosFormularios();

            FDataTracker nuevo = FDataTracker.Ventana_unica();
            nuevo.TopLevel = false;

            CerrarInstancias.InstanciasNull();
            //this.panel3.Controls.Clear();
            this.panel3.Controls.Add(nuevo);
            //nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CerrarOtrosFormularios();

            FAnularVenta nuevo = FAnularVenta.Ventana_unica();
            nuevo.TopLevel = false;
            CerrarInstancias.InstanciasNull();
            // this.panel3.Controls.Clear();
            this.panel3.Controls.Add(nuevo);
            //nuevo.MdiParent = this;
            nuevo.Show();
        }
    }
}
