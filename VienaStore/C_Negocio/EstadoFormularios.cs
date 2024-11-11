using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VienaStore.C_Negocio
{
    internal class EstadoFormularios
    {
        public static void formularioAgregarStockActivo( TextBox TxtAgregarStock, System.Windows.Forms.Label LblAgregarStock, Button BtnGuardarStock,
          Button BtnCancelarAgregarStock,System.Windows.Forms.Label LblEditar, System.Windows.Forms.Label LblEditarProducto
)
        {
            TxtAgregarStock.Visible = true;
            TxtAgregarStock.Enabled = true;
            LblAgregarStock.Visible = true;
            LblAgregarStock.Enabled = true;
            BtnGuardarStock.Visible = true;
            BtnGuardarStock.Enabled = true;
            BtnCancelarAgregarStock.Enabled = true;
            BtnCancelarAgregarStock.Visible = true;
            LblEditar.Text = "AGREGAR\n\nSTOCK";
            LblEditarProducto.Visible = false;
        }

        public static void formularioAgregarStockInactivo(
            TextBox TxtAgregarStock,
            System.Windows.Forms.Label LblAgregarStock,
            Button BtnGuardarStock,
            Button BtnCancelarAgregarStock,
            System.Windows.Forms.Label LblEditar,
            System.Windows.Forms.Label LblEditarProducto
)
        {
            TxtAgregarStock.Visible = false;
            TxtAgregarStock.Enabled = false;
            LblAgregarStock.Visible = false;
            LblAgregarStock.Enabled = false;
            BtnGuardarStock.Visible = false;
            BtnGuardarStock.Enabled = false;
            BtnCancelarAgregarStock.Enabled = false;
            BtnCancelarAgregarStock.Visible = false;
            LblEditar.Text = "EDITAR";
            LblEditarProducto.Visible = true;
            LblEditarProducto.Text = "PRODUCTO";

        }



        public static void formularioEditarInactivo(
                TextBox TxtStockMIn,
                TextBox TBDescripcion,
                TextBox TBNombre,
                TextBox TBPrecioCompra,
                TextBox TBPrecioVenta,
                TextBox TBStock,
                ComboBox ComboProveedor,
                ComboBox ComboCategoria,
                System.Windows.Forms.Label LblCategoria,
                System.Windows.Forms.Label LblDescripcion,
                System.Windows.Forms.Label LblNombre,
                System.Windows.Forms.Label LblPrecioCompra,
                System.Windows.Forms.Label LblPrecioVenta,
                System.Windows.Forms.Label LblStokMin,
                System.Windows.Forms.Label LblProveedor,
                System.Windows.Forms.Label label2,
                Button BtnCancelar,
                Button button1,
                Button BtnEditar
)
        {
                TxtStockMIn.Visible = false;
                TBDescripcion.Visible = false;
                TBNombre.Visible = false;
                TBPrecioCompra.Visible = false;
                TBPrecioVenta.Visible = false;
                TBStock.Visible = false;
                ComboProveedor.Visible = false;
                ComboCategoria.Visible = false;
                LblCategoria.Visible = false;
                LblDescripcion.Visible = false;
                LblNombre.Visible = false;
                LblPrecioCompra.Visible = false;
                LblPrecioVenta.Visible = false;
                LblStokMin.Visible = false;
                LblProveedor.Visible = false;
                label2.Visible = false;
                BtnCancelar.Visible = false;
                BtnCancelar.Enabled = false;
                button1.Enabled = false;
                button1.Visible = false;
                BtnEditar.Visible = false;
                BtnEditar.Enabled = false;
        }

        public static void formularioEditarActivo(
            TextBox TxtStockMIn,
            TextBox TBDescripcion,
            TextBox TBNombre,
            TextBox TBPrecioCompra,
            TextBox TBPrecioVenta,
            TextBox TBStock,
            ComboBox ComboProveedor,
            ComboBox ComboCategoria,
            System.Windows.Forms.Label LblCategoria,
            System.Windows.Forms.Label LblDescripcion,
            System.Windows.Forms.Label LblNombre,
            System.Windows.Forms.Label LblPrecioCompra,
            System.Windows.Forms.Label LblPrecioVenta,
            System.Windows.Forms.Label LblStokMin,
            System.Windows.Forms.Label LblProveedor,
            System.Windows.Forms.Label label2,
            Button BtnCancelar,
            Button button1,
            Button BtnEditar
)
        {
            TxtStockMIn.Visible = true;
            TxtStockMIn.Enabled = true;
            TBDescripcion.Visible = true;
            TBDescripcion.Enabled = true;
            TBNombre.Visible = true;
            TBNombre.Enabled = true;
            TBPrecioCompra.Visible = true;
            TBPrecioCompra.Enabled = true;
            TBPrecioVenta.Visible = true;
            TBPrecioVenta.Enabled = true;
            TBStock.Visible = true;
            TBStock.Enabled = true;
            ComboProveedor.Visible = true;
            ComboProveedor.Enabled = true;
            ComboCategoria.Visible = true;
            ComboCategoria.Enabled = true;
            LblCategoria.Visible = true;
            LblDescripcion.Visible = true;
            LblNombre.Visible = true;
            LblPrecioCompra.Visible = true;
            LblPrecioVenta.Visible = true;
            LblStokMin.Visible = true;
            LblProveedor.Visible = true;
            label2.Visible = true;
            BtnCancelar.Visible = true;
            BtnCancelar.Enabled = true;
            button1.Visible = true;
            button1.Enabled = true;
            BtnEditar.Visible = true;
            BtnEditar.Enabled = true;
        }

    }
}
