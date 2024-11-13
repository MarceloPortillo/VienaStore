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

            FGestionProveedores nuevo = FGestionProveedores.Ventana_unica();
            nuevo.TopLevel = false;            
            CerrarInstancias.InstanciasNull();
            //this.panel3.Controls.Clear();
            this.panel3.Controls.Add(nuevo);
            //nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void BtnModificarCliente_Click(object sender, EventArgs e)
        {
            CerrarOtrosFormularios();

            reportes nuevo = reportes.Ventana_unica();
            nuevo.TopLevel = false;
            CerrarInstancias.InstanciasNull();
            //this.panel3.Controls.Clear();
            this.panel3.Controls.Add(nuevo);
            //nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void BtnCrearUsuario_Click(object sender, EventArgs e)
        {
            CerrarOtrosFormularios();
            CrearUsuarioNuevo nuevo = CrearUsuarioNuevo.Ventana_unica();
            nuevo.TopLevel = false;
            CerrarInstancias.InstanciasNull();
            //this.panel3.Controls.Clear();
            this.panel3.Controls.Add(nuevo);
            //nuevo.MdiParent = this;
            nuevo.Show();

        }
        public override void BtnBuscarProd_Click(object sender, EventArgs e)
        {
            CerrarOtrosFormularios();

            FBuscarProductos nuevo = FBuscarProductos.Ventana_unica();
            nuevo.TopLevel = false;
            CerrarInstancias.InstanciasNull();
            //this.panel3.Controls.Clear();
            this.panel3.Controls.Add(nuevo);
            //nuevo.MdiParent = this;
            nuevo.Show();
        }



        private void BtnBuescarUsuario_Click(object sender, EventArgs e)
        {
            CerrarOtrosFormularios();
            FBuscarUsuario nuevo = FBuscarUsuario.Ventana_unica();
            nuevo.TopLevel = false;
            CerrarInstancias.InstanciasNull();
            //this.panel3.Controls.Clear();
            this.panel3.Controls.Add(nuevo);
            //nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            CerrarOtrosFormularios();
            FAgregarProducto nuevo = FAgregarProducto.Ventana_unica1();
            nuevo.TopLevel = false;
            CerrarInstancias.InstanciasNull();
            //this.panel3.Controls.Clear();
            this.panel3.Controls.Add(nuevo);
            //nuevo.MdiParent = this;
            nuevo.Show();

        }

        private void BtnRealizarBackUp_Click(object sender, EventArgs e)
        {
            CerrarOtrosFormularios();
            FBackUp nuevo = FBackUp.Ventana_unica();
            nuevo.TopLevel = false;
            CerrarInstancias.InstanciasNull();
            //this.panel3.Controls.Clear();
            this.panel3.Controls.Add(nuevo);
            //nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void BtnAgregarCat_Click(object sender, EventArgs e)
        {
            CerrarOtrosFormularios();
            FGestionCategorias nuevo = FGestionCategorias.Ventana_unica();
            nuevo.TopLevel = false;
            CerrarInstancias.InstanciasNull();
            //this.panel3.Controls.Clear();
            this.panel3.Controls.Add(nuevo);
            //nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnVentaVendedor_Click(object sender, EventArgs e)
        {
            CerrarOtrosFormularios();
            FVentas nuevo = FVentas.Ventana_unica();
            nuevo.TopLevel = false;
            CerrarInstancias.InstanciasNull();
            //this.panel3.Controls.Clear();
            this.panel3.Controls.Add(nuevo);
            //nuevo.MdiParent = this;
            nuevo.Show();

        }
    }
}
