﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VienaStore.C_Presentacion.Vendedor;
using VienaStore.C_Presentacion.Administrador;
using VienaStore.C_Negocio;


namespace VienaStore.C_Presentacion.Vendedor
{
    public partial class Menu_Vendedor : Form
    {
        public Menu_Vendedor()
        {
            InitializeComponent();
            CerrarInstancias.InstanciasNull();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fecha_Tick(object sender, EventArgs e)
        {
            LblFecha.Text = DateTime.Now.ToString("dddd dd MMMM yyy");
        }

        private void BtnRegistrarCliente_Click(object sender, EventArgs e)
        {
            CerrarOtrosFormularios();

            FNuevoCliente nuevo = FNuevoCliente.Ventana_unica();
            nuevo.TopLevel = false;

            CerrarInstancias.InstanciasNull();
            //this.panel3.Controls.Clear();
            this.panel3.Controls.Add(nuevo);
            //nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void BtnModificarCliente_Click(object sender, EventArgs e)
        {
            /*FModificarCliente nuevo = new FModificarCliente();
            nuevo.MdiParent = this;
            nuevo.Show();*/
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            CerrarOtrosFormularios();

            FBuscarClientes nuevo = FBuscarClientes.Ventana_unica();
            nuevo.TopLevel = false;
            CerrarInstancias.InstanciasNull();
           // this.panel3.Controls.Clear();
            this.panel3.Controls.Add(nuevo);
            //nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void BtnListarCliente_Click(object sender, EventArgs e)
        {
            CerrarOtrosFormularios();

            FListarClientes nuevo = FListarClientes.Ventana_unica();
            nuevo.TopLevel = false;            
            CerrarInstancias.InstanciasNull();
            //this.panel3.Controls.Clear();
            this.panel3.Controls.Add(nuevo);
            //nuevo.MdiParent = this;
            nuevo.Show();
        }

        public virtual void BtnBuscarProd_Click(object sender, EventArgs e)
        {
            CerrarOtrosFormularios();

            FBuscarProductoVendedor nuevo = FBuscarProductoVendedor.Ventana_unica();
            nuevo.TopLevel = false;
            CerrarInstancias.InstanciasNull();
            //this.panel3.Controls.Clear();
            this.panel3.Controls.Add(nuevo);
            //nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void BtnListarProd_Click(object sender, EventArgs e)
        {
            CerrarOtrosFormularios();

            FListarProductos nuevo = FListarProductos.Ventana_unica();
            nuevo.TopLevel = false;
            CerrarInstancias.InstanciasNull();
           // this.panel3.Controls.Clear();
            this.panel3.Controls.Add(nuevo);
            //nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.THora.Stop();
            this.fecha.Stop();
            FLogin sesion = new FLogin();
            sesion.Show();
            this.Close();
        }

        private void BtnRegistrarVenta_Click(object sender, EventArgs e)
        {
            CerrarOtrosFormularios();

            FRegistrarVenta nuevo = FRegistrarVenta.Ventana_unica();
            nuevo.TopLevel = false;
            CerrarInstancias.InstanciasNull();
            // this.panel3.Controls.Clear();
            this.panel3.Controls.Add(nuevo);
            //nuevo.MdiParent = this;
            nuevo.Show();
        }

        public void CerrarOtrosFormularios()
        {
            foreach (Form formHijo in this.MdiChildren)
            {
                formHijo.Close();
            }

            // Limpiar el panel3 y agregar los labels de fecha y hora
            this.panel3.Controls.Clear();

            // Volver a agregar los controles de hora y fecha
            this.panel3.Controls.Add(LblFecha);
            this.panel3.Controls.Add(LblHora);
            this.panel3.Controls.Add(LblEstrellas);
            this.panel3.Controls.Add(PBoxLogotipo);
        }

        private void THora_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void Menu_Vendedor_Load(object sender, EventArgs e)
        {

        }

        private void BtnMisVentas_Click(object sender, EventArgs e)
        {
            CerrarOtrosFormularios();

            FMisVentas nuevo = FMisVentas.Ventana_unica();
            nuevo.TopLevel = false;
            CerrarInstancias.InstanciasNull();
            // this.panel3.Controls.Clear();
            this.panel3.Controls.Add(nuevo);
            //nuevo.MdiParent = this;
            nuevo.Show();

        }
    }
}
