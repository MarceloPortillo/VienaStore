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
using VienaStore.C_Presentacion;
using VienaStore.C_Negocio;
using VienaStore.C_Datos;
using System.Collections;
using System.Reflection.Emit;

namespace VienaStore.C_Presentacion.Administrador
{
    public partial class FBuscarProductos : Form
    {
        private BusinessProductos _businessProductos;
        
        private BusinessProductos _bussinesProductos;

        private BusinessCategoria _categoriaProductos;

        private BusinessProveedores _proveedoresProductos;

        private static FBuscarProductos instancia = null;
        public static FBuscarProductos Ventana_unica()
        {


            if (instancia == null)
            {
                instancia = new FBuscarProductos();
                return instancia;
            }


            return instancia;
        }
        public FBuscarProductos()
        {
            InitializeComponent();
            _bussinesProductos = new BusinessProductos();
            _categoriaProductos = new BusinessCategoria();
            _proveedoresProductos = new BusinessProveedores();
            _businessProductos = new BusinessProductos();
            DtaProdcuto.CellFormatting += DtaProdcuto_CellFormatting;

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
        }
        public static void limpiar()
        {
            instancia = null;
        }

        private void LblProveedor_Click(object sender, EventArgs e)
        {

        }

        private void FBuscarProductos_Load(object sender, EventArgs e)
        {
            ListarProductos();
            this.BeginInvoke((MethodInvoker)delegate
            {
                DtaProdcuto.ClearSelection();
            });
        }

        private void ListarProductos()
        {
            try
            {
                List<Productos_Proveedores_Categorias> producto = _bussinesProductos.GetProductos();
                DtaProdcuto.DataSource = producto;
                DtaProdcuto.BackgroundColor = Color.LightSalmon;
                DtaProdcuto.Columns["id_proveedor"].Visible = false;
                DtaProdcuto.Columns["id_Categoria"].Visible = false;
                DtaProdcuto.Columns["codProducto"].Width = 60;
                DtaProdcuto.Columns["precioCosto"].Width = 70;
                DtaProdcuto.Columns["precioVenta"].Width = 70;
                DtaProdcuto.Columns["stock"].Width = 60;
                DtaProdcuto.Columns["nombreCategoria"].Width = 100;
                DtaProdcuto.Columns["estado"].Width = 80;
                DtaProdcuto.AutoGenerateColumns = false;


                if (!DtaProdcuto.Columns.Contains("btnEstado"))
                {
                    DataGridViewButtonColumn btnEstadoColumn = new DataGridViewButtonColumn();
                    btnEstadoColumn.HeaderText = "ACCION";
                    btnEstadoColumn.Name = "btnEstado";
                    btnEstadoColumn.UseColumnTextForButtonValue = false;
                    btnEstadoColumn.Width = 80;
                    DtaProdcuto.Columns.Add(btnEstadoColumn);
                }

                foreach (DataGridViewRow row in DtaProdcuto.Rows)
                {
                    if (row.DataBoundItem is Productos_Proveedores_Categorias productoItem)
                    {
                        string estado = productoItem.estado;
                        row.Cells["btnEstado"].Value = estado == "ELIMINADO" ? "Activar" : "Eliminar";
                    }
                }

                foreach (DataGridViewColumn column in DtaProdcuto.Columns)
                {
                    DtaProdcuto.ClearSelection();

                    column.HeaderText = column.HeaderText.ToUpper();
                    DtaProdcuto.Columns["codProducto"].HeaderText = "CODIGO";
                    DtaProdcuto.Columns["nombreProducto"].HeaderText = "PRODUCTO";
                    DtaProdcuto.Columns["descripcionProducto"].HeaderText = "DESCRIPCION";
                    DtaProdcuto.Columns["nombreCategoria"].HeaderText = "CATEGORIA";
                    DtaProdcuto.Columns["stockMin"].HeaderText = "STK. MIN";
                    DtaProdcuto.Columns["stock"].HeaderText = "STOCK";
                    DtaProdcuto.Columns["precioCosto"].HeaderText = "P. COSTO";
                    DtaProdcuto.Columns["precioVenta"].HeaderText = "P.VENTA";
                    DtaProdcuto.Columns["nombreProveedor"].HeaderText = "PROVEEDOR";
                    DtaProdcuto.Columns["estado"].HeaderText = "ESTADO";


                    DtaProdcuto.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    
                }
                

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void edit()
        {
            if (DtaProdcuto.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = DtaProdcuto.SelectedRows[0];
                string estado = Convert.ToString(fila.Cells["estado"].Value);
                if (estado == "ELIMINADO")
                {
                    MessageBox.Show("El producto no existe", "Verificar!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    CargarCombo();
                    int codProducto = Convert.ToInt32(fila.Cells["codProducto"].Value);
                    TBNombre.Text = Convert.ToString(fila.Cells["nombreProducto"].Value);
                    TBDescripcion.Text = Convert.ToString(fila.Cells["descripcionProducto"].Value);
                    ComboCategoria.Text = Convert.ToString(fila.Cells["nombreCategoria"].Value);
                    TxtStockMIn.Text = Convert.ToString(fila.Cells["stock"].Value);
                    TBStock.Text = Convert.ToString(fila.Cells["stockMin"].Value);
                    TBPrecioCompra.Text = Convert.ToString(fila.Cells["precioVenta"].Value);
                    TBPrecioVenta.Text = Convert.ToString(fila.Cells["precioCosto"].Value);
                    ComboProveedor.Text = Convert.ToString(fila.Cells["nombreProveedor"].Value);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un producto para Modificar", "Seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void CargarCombo()
        {
            ComboCategoria.DataSource = _categoriaProductos.CargarComboCategorias();
            ComboCategoria.DisplayMember = "nombreCategoria";
            ComboCategoria.ValueMember = "id_Categoria";

            ComboProveedor.DataSource = _proveedoresProductos.CargarComboProveedor();
            ComboProveedor.DisplayMember = "nombreProveedor";
            ComboProveedor.ValueMember = "id_proveedor";
        }

        private void BotonGuardarProducto()
        {
            if (CampoVacios.CamposVaciosProducto(TBNombre, TBDescripcion, TxtStockMIn, TBStock, TBPrecioCompra, TBPrecioVenta, ComboCategoria, ComboProveedor))
            {
                try
                {
                    DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas Modificar los datos del Producto?", "Confirmar Modifición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmacion == DialogResult.Yes)
                    {

                        GuardarProducto();

                        Limpiar.limpiarAgregarProducto(TBNombre, TBDescripcion, TxtStockMIn, TBStock, TBPrecioCompra, TBPrecioVenta, ComboCategoria, ComboProveedor);
                        ListarProductos();
                        MessageBox.Show("Modificación Exitosa", "¡Felicitaciones!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {                    
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }

        private void GuardarProducto()
        {
            
                Productos producto = new Productos();

                producto.nombreProducto = TBNombre.Text.ToUpper();
                producto.descripcionProducto = TBDescripcion.Text;
                producto.id_Categoria = Convert.ToInt32(ComboCategoria.SelectedValue);
                producto.stockMin = Convert.ToInt32(TBStock.Text);
                producto.stock = Convert.ToInt32(TxtStockMIn.Text);
                producto.precioCosto = Convert.ToSingle(TBPrecioVenta.Text);
                producto.precioVenta = Convert.ToSingle(TBPrecioCompra.Text);
                producto.id_proveedor = Convert.ToInt32(ComboProveedor.SelectedValue);

                producto.codProducto = Convert.ToInt32(DtaProdcuto.CurrentRow.Cells["codProducto"].Value);
                _businessProductos.GuardarProducto(producto);  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BotonGuardarProducto();
        }
        private void DatagridEliminar(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DtaProdcuto.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                int id = int.Parse(DtaProdcuto.Rows[e.RowIndex].Cells["codProducto"].Value.ToString());
                string estado = DtaProdcuto.Rows[e.RowIndex].Cells["estado"].Value.ToString();
                if (estado == "ACTIVO")
                {
                    DialogResult preg = MessageBox.Show("¿Esta seguro que quiere eliminar este Producto?", "Confimar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (preg == DialogResult.Yes)
                    {
                        DtaProdcuto.Rows[e.RowIndex].Cells["estado"].Value = "ELIMINADO";
                        EliminarProveedor(id);
                        Limpiar.limpiarAgregarProducto(TBNombre, TBDescripcion, TxtStockMIn, TBStock, TBPrecioCompra, TBPrecioVenta, ComboCategoria, ComboProveedor);
                        MessageBox.Show("Se ha eliminado correctamente", "Elminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        return;
                    }
                }
                else if (estado == "ELIMINADO")
                {
                    DialogResult preg = MessageBox.Show("¿Esta seguro que quiere activar el Producto?", "Confimar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (preg == DialogResult.Yes)
                    {
                        DtaProdcuto.Rows[e.RowIndex].Cells["estado"].Value = "ACTIVO";

                        EliminarProveedor(id);
                        MessageBox.Show("El Producto ha sido dado de alta correctamente", "Reestablecido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        return;
                    }
                }
                foreach (DataGridViewRow row in DtaProdcuto.Rows)
                {
                    if (row.DataBoundItem is Productos_Proveedores_Categorias productoItem)
                    {
                        string estadoActual = productoItem.estado;
                        row.Cells["btnEstado"].Value = estadoActual == "ELIMINADO" ? "Activar" : "Eliminar";
                    }
                }
            }
        }
        private void EliminarProveedor(int id)
        {
            _businessProductos.DeleteProducto(id);
        }

        private void DtaProdcuto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DatagridEliminar(e);
        }

        private void TxtBuscar_Click(object sender, EventArgs e)
        {

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {   
            string buscaText = TxtBuscar.Text;
            List<Productos_Proveedores_Categorias> proveedoresEncontrados = _businessProductos.GetProductos(buscaText);
            DtaProdcuto.DataSource = proveedoresEncontrados;
            foreach (DataGridViewRow row in DtaProdcuto.Rows)
            {
                if (row.DataBoundItem is Productos_Proveedores_Categorias productoItem)
                {
                    string estadoActual = productoItem.estado;
                    row.Cells["btnEstado"].Value = estadoActual == "ELIMINADO" ? "Activar" : "Eliminar";
                }
            }
        }

        private void DtaProdcuto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DtaProdcuto.Columns[e.ColumnIndex].Name == "btnEstado" && e.RowIndex >= 0)
            {
                string estado = Convert.ToString(DtaProdcuto.Rows[e.RowIndex].Cells["estado"].Value);
                e.Value = estado == "ELIMINADO" ? "Activar" : "Eliminar";
            }
        }

        private void BtnAgregarStock_Click(object sender, EventArgs e)
        {

            if (DtaProdcuto.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = DtaProdcuto.SelectedRows[0];
                string estado = Convert.ToString(fila.Cells["estado"].Value);
                if (estado == "ELIMINADO")
                {
                    MessageBox.Show("El producto no existe", "Verificar!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }              
                    
            }
            else
            {
                MessageBox.Show("Por favor seleccione un producto para agregar stock", "Seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            EstadoFormularios.formularioEditarInactivo(TxtStockMIn, TBDescripcion, TBNombre, TBPrecioCompra, TBPrecioVenta, TBStock, ComboProveedor, ComboCategoria, LblCategoria, LblDescripcion, LblNombre, LblPrecioCompra, LblPrecioVenta, LblStokMin, LblProveedor, label2, BtnCancelar, button1, BtnEditar);
            
            EstadoFormularios.formularioAgregarStockActivo(TxtAgregarStock,LblAgregarStock, BtnGuardarStock,BtnCancelarAgregarStock,  LblEditar, LblEditarProducto);
            
        }

        private void BtnCancelarAgregarStock_Click(object sender, EventArgs e)
        {
            this.Close();
        }  
        private void BtnGuardarStock_Click(object sender, EventArgs e)
        {
            if (CampoVacios.CampoVacioAgregarStock(TxtAgregarStock))
            {
                DialogResult preg = MessageBox.Show("¿Esta seguro que quiere agregar el stock del Producto?", "Confimar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (preg == DialogResult.Yes)
                {
                    int stock = Convert.ToInt32(TxtAgregarStock.Text);
                    if (stock <= 0)
                    {
                        MessageBox.Show("Debe ingresar un número mayor a 0", "Error al agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.TxtAgregarStock.Clear();
                        return;
                    }
                    EstadoFormularios.formularioAgregarStockActivo(TxtAgregarStock, LblAgregarStock, BtnGuardarStock, BtnCancelarAgregarStock, LblEditar, LblEditarProducto);
                    ConfirmarAgregarStock();
                    ListarProductos();
                    MessageBox.Show("Stock Agregado correctamente", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    EstadoFormularios.formularioAgregarStockInactivo(TxtAgregarStock, LblAgregarStock, BtnGuardarStock, BtnCancelarAgregarStock, LblEditar, LblEditarProducto);
                    EstadoFormularios.formularioEditarActivo(TxtStockMIn, TBDescripcion, TBNombre, TBPrecioCompra, TBPrecioVenta, TBStock, ComboProveedor, ComboCategoria, LblCategoria, LblDescripcion, LblNombre, LblPrecioCompra, LblPrecioVenta, LblStokMin, LblProveedor, label2, BtnCancelar, button1, BtnEditar);
                }
                else
                {
                    return;
                }
            }
               
          
        }

        private void ConfirmarAgregarStock()
        {
            Productos stock = new Productos();
            stock.codProducto = Convert.ToInt32(DtaProdcuto.CurrentRow.Cells["codProducto"].Value);
            stock.stock = Convert.ToInt32(TxtAgregarStock.Text);
            _businessProductos.AgregarSotck(stock);
            this.TxtAgregarStock.Clear();
        }

        private void TxtAgregarStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }
    }
}
        
    
