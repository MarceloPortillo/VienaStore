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
    public partial class Menu_Vendedor : Form
    {
        public Menu_Vendedor()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fecha_Tick(object sender, EventArgs e)
        {
            TxtFecha.Text = DateTime.Now.ToString("dddd dd MMMM yyy");
        }

        private void BtnRegistrarCliente_Click(object sender, EventArgs e)
        {
            Form1 nuevo = new Form1();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void BtnModificarCliente_Click(object sender, EventArgs e)
        {
            Form1 nuevo = new Form1();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            Form1 nuevo = new Form1();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void BtnListarCliente_Click(object sender, EventArgs e)
        {
            Form1 nuevo = new Form1();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void BtnBuscarProd_Click(object sender, EventArgs e)
        {
            Form1 nuevo = new Form1();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void BtnListarProd_Click(object sender, EventArgs e)
        {
            Form1 nuevo = new Form1();
            nuevo.MdiParent = this;
            nuevo.Show();
        }
    }
}
