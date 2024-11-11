using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VienaStore.C_Datos;
using VienaStore.C_Negocio;

namespace VienaStore.C_Presentacion.Vendedor
{
    public partial class FListarProductos : Form
    {
        private static FListarProductos instancia = null;

        private BusinessProductos _businessProductos;
        public static FListarProductos Ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new FListarProductos();
                return instancia;
            }
            return instancia;
        }
        public FListarProductos()
        {
            InitializeComponent();
            _businessProductos = new BusinessProductos();

        }

        private void FListarProductos_Load(object sender, EventArgs e)
        {
            /* base.OnLoad(e);*/
            ListarProductos();
        }
        public static void limpiar()
        {
            instancia = null;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
        }

        private void ListarProductos()
        {
            try
            {
                List<Productos_Proveedores_Categorias> producto = _businessProductos.GetProductos();
                DtaProductos.DataSource = producto;
                DtaProductos.BackgroundColor = Color.LightSalmon;
                DtaProductos.Columns["id_proveedor"].Visible = false;
                DtaProductos.Columns["id_Categoria"].Visible = false;
                DtaProductos.Columns["codProducto"].Width = 60;
                DtaProductos.Columns["precioCosto"].Width = 70;
                DtaProductos.Columns["precioVenta"].Width = 70;
                DtaProductos.Columns["stock"].Width = 60;
                DtaProductos.Columns["nombreCategoria"].Width = 100;
                DtaProductos.Columns["estado"].Width = 80;
                DtaProductos.AutoGenerateColumns = false;
                               

                foreach (DataGridViewColumn column in DtaProductos.Columns)
                {
                    DtaProductos.ClearSelection();

                    column.HeaderText = column.HeaderText.ToUpper();
                    DtaProductos.Columns["codProducto"].HeaderText = "CODIGO";
                    DtaProductos.Columns["nombreProducto"].HeaderText = "PRODUCTO";
                    DtaProductos.Columns["descripcionProducto"].HeaderText = "DESCRIPCION";
                    DtaProductos.Columns["nombreCategoria"].HeaderText = "CATEGORIA";
                    DtaProductos.Columns["stockMin"].HeaderText = "STK. MIN";
                    DtaProductos.Columns["stock"].HeaderText = "STOCK";
                    DtaProductos.Columns["precioCosto"].HeaderText = "P. COSTO";
                    DtaProductos.Columns["precioVenta"].HeaderText = "P.VENTA";
                    DtaProductos.Columns["nombreProveedor"].HeaderText = "PROVEEDOR";
                    DtaProductos.Columns["estado"].HeaderText = "ESTADO";


                    DtaProductos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                }


            }
            catch (Exception)
            {

                throw;
            }
        }
        public string NombreProductoSeleccionado { get; private set; }
        public string DescripcionProductoSeleccionado { get; private set; }
        public string CodigoProductoSeleccionado { get; private set; }
        public decimal PrecioVentaProductoSeleccionado { get; private set; }
        public int StockProductoSeleccionado { get; private set; }



        private void DtaProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                NombreProductoSeleccionado = DtaProductos.Rows[e.RowIndex].Cells["nombreProducto"].Value.ToString();
                DescripcionProductoSeleccionado = DtaProductos.Rows[e.RowIndex].Cells["descripcionProducto"].Value.ToString();
                CodigoProductoSeleccionado = DtaProductos.Rows[e.RowIndex].Cells["codProducto"].Value.ToString();
                PrecioVentaProductoSeleccionado = Convert.ToDecimal(DtaProductos.Rows[e.RowIndex].Cells["precioVenta"].Value);
                StockProductoSeleccionado = Convert.ToInt32(DtaProductos.Rows[e.RowIndex].Cells["stock"].Value);


                // Establece el resultado como OK y cierra el formulario
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
