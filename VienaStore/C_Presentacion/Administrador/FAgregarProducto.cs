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
               string.IsNullOrWhiteSpace(TBCodigoProducto.Text) ||
                CBCategoria.SelectedIndex == -1 || 
                string.IsNullOrWhiteSpace(TxtStockMin.Text) ||
                CboProveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult ask = MessageBox.Show("¿Seguro que desea insertar un nuevo Producto?", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ask == DialogResult.Yes)
            {
                MessageBox.Show("El Producto: " + this.TBNombreProducto.Text + " " + this.TBDescripcion.Text + " " + "Se inserto Correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                C_Negocio.Limpiar.limpiarAgregarProducto(TBNombreProducto, TBDescripcion, TBStock, TBPrecioCompra, TBPrecioVenta, TBCodigoProducto, TxtStockMin, CboProveedor, CBCategoria);
                return;
            }
            else
            {
                C_Negocio.Limpiar.limpiarAgregarProducto(TBNombreProducto, TBDescripcion, TBStock, TBPrecioCompra, TBPrecioVenta, TBCodigoProducto, TxtStockMin, CboProveedor, CBCategoria);
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

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            C_Negocio.Limpiar.limpiarAgregarProducto(TBNombreProducto, TBDescripcion, TBStock, TBPrecioCompra, TBPrecioVenta, TBCodigoProducto, TxtStockMin, CboProveedor, CBCategoria);
        }

        private void TxtStockMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void TBPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.numerosDecimales(e);
        }

        private void TBPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.numerosDecimales(e);
        }
    }
}

