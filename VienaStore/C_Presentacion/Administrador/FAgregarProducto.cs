using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VienaStore.C_Datos;
using VienaStore.C_Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VienaStore.C_Presentacion.Administrador
{
    public partial class FAgregarProducto : Form
    {
        private static FAgregarProducto instancia = null;

        private BusinessCategoria _businnesCategoria;

        private BusinessProductos _businessProducto;

        private BusinessProveedores _businnesProveedor;
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
            _businnesCategoria = new BusinessCategoria();
            _businnesProveedor = new BusinessProveedores();
            _businessProducto = new BusinessProductos();
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

            if (!CampoVacios.CamposVaciosProducto(TBDescripcion, TBNombreProducto, TBPrecioCompra, TBPrecioVenta, TBStock, TxtStockMin, CboProveedor, CBCategoria))
            {
                return;
            }
            

                Productos producto = new Productos();
            producto.descripcionProducto = TBDescripcion.Text.ToUpper();
            producto.nombreProducto = TBNombreProducto.Text.ToUpper();
            producto.stockMin = Convert.ToInt32(TxtStockMin.Text);
            producto.stock = Convert.ToInt32(TBStock.Text);
            producto.precioCosto = Convert.ToSingle(TBPrecioCompra.Text);
            producto.precioVenta = Convert.ToSingle(TBPrecioVenta.Text);
            producto.id_Categoria = Convert.ToInt32(CBCategoria.SelectedValue.ToString());
            producto.id_proveedor = Convert.ToInt32(CboProveedor.SelectedValue.ToString());

            try
            {
                DialogResult ask = MessageBox.Show("¿Seguro que desea insertar un nuevo Producto?", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    _businessProducto.GuardarProducto(producto);
                    
                    MessageBox.Show("El Producto: " + this.TBNombreProducto.Text + " " + this.TBDescripcion.Text + " " + "Se inserto Correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    C_Negocio.Limpiar.limpiarAgregarProducto(TBNombreProducto, TBDescripcion, TBStock, TBPrecioCompra, TBPrecioVenta, TxtStockMin, CboProveedor, CBCategoria);
                    CargarCombo();
                    ListarProductos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            C_Negocio.Limpiar.limpiarAgregarProducto(TBNombreProducto, TBDescripcion, TBStock, TBPrecioCompra, TBPrecioVenta, TxtStockMin, CboProveedor, CBCategoria);
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

        private void FAgregarProducto_Load(object sender, EventArgs e)
        {
            CargarCombo();
            ListarProductos();
        }

        private void CargarCombo()
        {
            CBCategoria.DataSource = _businnesCategoria.CargarComboCategorias();
            CBCategoria.DisplayMember = "nombreCategoria";
            CBCategoria.ValueMember = "id_Categoria";

            CboProveedor.DataSource = _businnesProveedor.CargarComboProveedor();
            CboProveedor.DisplayMember = "nombreProveedor";
            CboProveedor.ValueMember = "id_proveedor";
        }

        private void ListarProductos()
        {
            try
            {
                List<Productos_Proveedores_Categorias> producto = _businessProducto.GetProductos();
                DataProducto.DataSource = producto;
                DataProducto.BackgroundColor = Color.LightSalmon;
                DataProducto.Columns["id_proveedor"].Visible = false;
                DataProducto.Columns["id_Categoria"].Visible = false;
                foreach (DataGridViewColumn column in DataProducto.Columns)
                {
                    DataProducto.ClearSelection();
                    column.HeaderText = column.HeaderText.ToUpper();
                    DataProducto.Columns["codProducto"].HeaderText = "COD.PRODUCTO";
                    DataProducto.Columns["nombreProducto"].HeaderText = "PRODUCTO";
                    DataProducto.Columns["descripcionProducto"].HeaderText = "DESCRIPCION";
                    DataProducto.Columns["nombreCategoria"].HeaderText = "CATEGORIA";
                    DataProducto.Columns["stockMin"].HeaderText = "STOCK MIN";
                    DataProducto.Columns["stock"].HeaderText = "STOCK";
                    DataProducto.Columns["precioCosto"].HeaderText = "P. COSTO";
                    DataProducto.Columns["precioVenta"].HeaderText = "P.VENTA";
                    DataProducto.Columns["nombreProveedor"].HeaderText = "P.VENTA";
                    DataProducto.Columns["estado"].HeaderText = "ESTADO";

                    DataProducto.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

