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
    public partial class FAgregarProducto : Form
    {
        private static FAgregarProducto instancia = null;
        public static FAgregarProducto Ventana_unica1()
        {
            if (instancia == null)
            {
                instancia = new FAgregarProducto();
                return instancia;
            }
            return instancia;
        }
        public FAgregarProducto()
        {
            InitializeComponent();
        }

        private void LblPrecioVenta_Click(object sender, EventArgs e)
        {

        }

        private void TBNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Negocio.Validaciones.SoloLetras(e);
        }

        private void TBStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Negocio.Validaciones.SoloNumeros(e);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBNombreProducto.Text) ||
               string.IsNullOrWhiteSpace(TBDescripcion.Text) ||
               string.IsNullOrWhiteSpace(TBStock.Text) ||
               string.IsNullOrWhiteSpace(TBPrecioCompra.Text) ||
               string.IsNullOrWhiteSpace(TBPrecioVenta.Text) ||
                CBCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult ask = MessageBox.Show("¿Seguro que desea insertar un nuevo Producto?", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ask == DialogResult.Yes)
            {
                MessageBox.Show("El Producto: " + this.TBNombreProducto.Text + " " + this.TBDescripcion.Text + " " + "Se inserto Correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TBNombreProducto.Clear();
                this.TBDescripcion.Clear();
                this.TBStock.Clear();
                this.TBPrecioCompra.Clear();
                this.TBPrecioVenta.Clear();
                return;
            }
            else
            {
                this.TBNombreProducto.Clear();
                this.TBDescripcion.Clear();
                this.TBStock.Clear();
                this.TBPrecioCompra.Clear();
                this.TBPrecioVenta.Clear();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.Close();
        }

        private void TBCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Negocio.Validaciones.SoloNumeros(e);
        }
        public static void Limpiar()
        {
            instancia = null;
        }
    }
}

