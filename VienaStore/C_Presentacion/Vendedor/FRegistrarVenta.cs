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
using VienaStore.C_Presentacion;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace VienaStore.C_Presentacion.Vendedor
{    
    public partial class FRegistrarVenta : Form
    {
        private static FRegistrarVenta instancia = null;

        private BusinessFactura businessFactura;
        private BusinessFormaPago businessFormaPago;

        public string IdClienteSeleccionado { get; private set; }

        public static FRegistrarVenta Ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new FRegistrarVenta();
                return instancia;
            }
            return instancia;
        }
        public FRegistrarVenta()
        {
            InitializeComponent();
            businessFactura = new BusinessFactura();
            businessFormaPago = new BusinessFormaPago();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
        }
        public static void limpiar()
        {
            instancia = null;
        }

        private void FRegistrarVenta_Load(object sender, EventArgs e)
        {
            BtnImprimir.Visible = false;
            if (UsuarioLogeado.Usuario != null)
            {
                TxtEmpleado.Text = UsuarioLogeado.Usuario.NombreCompleto;
            }

            var tiposFactura = businessFactura.ObtenerTiposFactura();

            CBFactura.DataSource = tiposFactura;
            CBFactura.DisplayMember = "Descripcion";
            CBFactura.ValueMember = "IdFactura";    

            var tiposPago = businessFormaPago.ObtenerTiposPago();

            CBFormaDePago.DataSource = tiposPago;
            CBFormaDePago.DisplayMember = "descripcion"; 
            CBFormaDePago.ValueMember = "id_pago";       
        }


        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            FBuscarClientes buscarClienteForm = new FBuscarClientes();

            if (buscarClienteForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Cliente seleccionado: " +
                                 buscarClienteForm.NombreClienteSeleccionado + " - " +
                                 buscarClienteForm.DniClienteSeleccionado + " - " +
                                 buscarClienteForm.DireccionClienteSeleccionado);

                TxtNombre.Text = buscarClienteForm.NombreClienteSeleccionado;
                TxtDNI.Text = buscarClienteForm.DniClienteSeleccionado;  
                TxtDireccion.Text = buscarClienteForm.DireccionClienteSeleccionado;
                IdClienteSeleccionado = buscarClienteForm.IdClienteSeleccionado;
            }
        }
        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            FListarProductos listarProductosForm = new FListarProductos();

            if (listarProductosForm.ShowDialog() == DialogResult.OK)
            {
                TxtNombreProducto.Text = listarProductosForm.NombreProductoSeleccionado;
                TxtDescripcionProducto.Text = listarProductosForm.DescripcionProductoSeleccionado;
                TxtCodProd.Text = listarProductosForm.CodigoProductoSeleccionado;
                TxtPrecioVenta.Text = listarProductosForm.PrecioVentaProductoSeleccionado.ToString();
                TxtStock.Text = listarProductosForm.StockProductoSeleccionado.ToString();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProductoAlDataGridView();
        }

        private void DtaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DtaProductos.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                DtaProductos.Rows.RemoveAt(e.RowIndex);
                ActualizarTotal();
            }
        }
        private void AgregarProductoAlDataGridView()
        {

            if (string.IsNullOrWhiteSpace(TxtCantidad.Text) || !int.TryParse(TxtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Debe ingresar una cantidad válida de producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtStock.Text) || !int.TryParse(TxtStock.Text, out int stock) || cantidad > stock)
            {
                MessageBox.Show("No hay suficiente stock disponible para la cantidad solicitada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtCodProd.Text) || !int.TryParse(TxtCodProd.Text, out int codProducto))
            {
                MessageBox.Show("Debe ingresar un código de producto válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtPrecioVenta.Text) || !decimal.TryParse(TxtPrecioVenta.Text, out decimal precioUnitario))
            {
                MessageBox.Show("Debe ingresar un precio de venta válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombreProducto = TxtNombreProducto.Text;
            string descripcionProducto = TxtDescripcionProducto.Text;
            decimal subtotal = cantidad * precioUnitario;

            bool productoExistente = false;

            foreach (DataGridViewRow row in DtaProductos.Rows)
            {
                if (row.Cells["NroProducto"].Value != null && int.TryParse(row.Cells["NroProducto"].Value.ToString(), out int nroProductoExistente) && nroProductoExistente == codProducto)
                {
                    if (row.Cells["cantidad"].Value != null && int.TryParse(row.Cells["cantidad"].Value.ToString(), out int cantidadActual))
                    {
                        if (cantidadActual + cantidad > stock)
                        {
                            MessageBox.Show("No hay suficiente stock disponible para la cantidad acumulada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        row.Cells["cantidad"].Value = cantidadActual + cantidad;
                        row.Cells["SubTotal"].Value = (cantidadActual + cantidad) * precioUnitario;
                        productoExistente = true;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Error al leer la cantidad existente del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            if (!productoExistente)
            {
                DtaProductos.Rows.Add(codProducto, nombreProducto, descripcionProducto, cantidad, precioUnitario, subtotal);
            }

            ActualizarTotal();

            TxtNombreProducto.Clear();
            TxtDescripcionProducto.Clear();
            TxtCodProd.Clear();
            TxtPrecioVenta.Clear();
            TxtCantidad.Clear();
            TxtStock.Clear();
        }

        private void ActualizarTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in DtaProductos.Rows)
            {
                total += Convert.ToDecimal(row.Cells["SubTotal"].Value);
            }

            TxtTotal.Text = total.ToString("0.00");
        }

        private void DtaProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DtaProductos.Columns[e.ColumnIndex].Name == "ELIMINAR" && e.RowIndex >= 0)
            {
                e.Value = "Eliminar";
            }
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }
        private void BtnConfirmarVenta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombre.Text) || string.IsNullOrWhiteSpace(TxtDNI.Text) ||
                CBFactura.SelectedIndex == -1 || CBFormaDePago.SelectedIndex == -1 || DtaProductos.Rows.Count == 0)
            {
                MessageBox.Show("Complete todos los campos necesarios y agregue productos a la venta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!float.TryParse(TxtTotal.Text, out float total))
            {
                MessageBox.Show("El total de la venta no tiene un formato válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtNombre.Text) || string.IsNullOrWhiteSpace(TxtDNI.Text))
            {
                MessageBox.Show("Debe seleccionar un cliente antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idFactura = Convert.ToInt32(CBFactura.SelectedValue);
            int idPago = Convert.ToInt32(CBFormaDePago.SelectedValue);

            Ventas venta = new Ventas
            {
                Fecha = DateTime.Now,
                IdUsuario = UsuarioLogeado.Usuario.id_usuario,
                IdCliente = Convert.ToInt32(IdClienteSeleccionado),
                IdFactura = idFactura,
                IdPago = idPago,
                Total = total,
                Estado = 1
            };

            foreach (DataGridViewRow row in DtaProductos.Rows)
            {
                if (row.IsNewRow) continue;

                if (!decimal.TryParse(row.Cells["SubTotal"].Value.ToString(), out decimal subtotal))
                {
                    MessageBox.Show("El valor del subtotal no tiene un formato válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                VentaDetalle detalle = new VentaDetalle
                {
                    IdProducto = Convert.ToInt32(row.Cells["CodProducto"].Value),
                    Cantidad = Convert.ToInt32(row.Cells["cantidad"].Value),
                    Subtotal = (float)subtotal,
                    Estado = 1
                };

                venta.DetallesVenta.Add(detalle);
            }

            MostrarDatosVenta(venta);

            DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea confirmar esta venta?", "Confirmar Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    BusinessVentas businessVentas = new BusinessVentas();
                    businessVentas.ConfirmarVenta(venta);

                    DialogResult resultado = MessageBox.Show("¡Felicitaciones! La venta se realizó exitosamente.",
                        "Venta Confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnImprimir.Visible = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al confirmar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MostrarDatosVenta(Ventas venta)
        {
            string mensaje = $"Fecha de Venta: {venta.Fecha}\n" +
                             $"Usuario ID: {venta.IdUsuario}\n" +
                             $"Cliente ID: {venta.IdCliente}\n" +
                             $"Tipo de Factura: {venta.IdFactura}\n" +
                             $"Forma de Pago: {venta.IdPago}\n" +
                             $"Total: {venta.Total}\n" +
                             $"Estado: {venta.Estado}\n\n" +
                             "Detalles de la Venta:\n";

            foreach (var detalle in venta.DetallesVenta)
            {
                mensaje += $"Producto ID: {detalle.IdProducto}, " +
                           $"Cantidad: {detalle.Cantidad}, " +
                           $"Subtotal: {detalle.Subtotal}\n";
            }

            MessageBox.Show(mensaje, "Datos de la Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";

            string paginahtml_texto = Properties.Resources.plantilla.ToString();

            // Obtener la descripción de la factura seleccionada desde el ComboBox
            string descripcionFactura = CBFactura.Text; // Esto obtiene el texto visible en el ComboBox (por ejemplo, "Factura A" o "Factura B")

            paginahtml_texto = paginahtml_texto.Replace("@CLIENTE", TxtNombre.Text);
            paginahtml_texto = paginahtml_texto.Replace("@DOCUMENTO", TxtDNI.Text);
            paginahtml_texto = paginahtml_texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
            paginahtml_texto = paginahtml_texto.Replace("@DIRECCION", TxtDireccion.Text);
            paginahtml_texto = paginahtml_texto.Replace("@NUMERO_FACTURA", descripcionFactura); // Reemplazo con la descripción de la factura

            string filas = string.Empty;
            decimal total = 0;
            foreach (DataGridViewRow row in DtaProductos.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Descripcion"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioUnitario"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
                total += decimal.Parse(row.Cells["Subtotal"].Value.ToString());
            }

            paginahtml_texto = paginahtml_texto.Replace("@FILA", filas);
            paginahtml_texto = paginahtml_texto.Replace("@TOTAL", total.ToString());

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    // Incluir logotipo
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.logotipo, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(150, 100);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);

                    using (StringReader sr = new StringReader(paginahtml_texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }
            }
            BtnImprimir.Visible = false;
        }


    }
}
