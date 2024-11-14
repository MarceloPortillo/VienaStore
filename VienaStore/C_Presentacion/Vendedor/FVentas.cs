using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using VienaStore.C_Datos; 
using VienaStore.C_Negocio;
using VienaStore.C_Presentacion.Administrador;

namespace VienaStore.C_Presentacion.Vendedor
{
    public partial class FVentas : Form
    {
        private BusinessVentas _businessVentas;
        private static FVentas instancia = null;
        public static FVentas Ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new FVentas();
                return instancia;
            }

            return instancia;
        }

        public FVentas()
        {
            InitializeComponent();
            _businessVentas = new BusinessVentas();
        }

        public static void limpiar()
        {
            instancia = null;
        }
        private void ListarVentas(string searchText = null)
        {
            try
            {
                List<DataAccessVentaDTO> ventas = _businessVentas.GetVentas(searchText);

                dataGridViewVentas.DataSource = ventas;

                dataGridViewVentas.BackgroundColor = Color.LightSalmon;
                dataGridViewVentas.Columns["idVenta"].Visible = false;
                dataGridViewVentas.Columns["total"].Width = 50;
                dataGridViewVentas.Columns["fecha"].Width = 70;
                dataGridViewVentas.Columns["nombreUsuario"].Width = 80;
                dataGridViewVentas.Columns["estadoFactura"].Width = 50;
                dataGridViewVentas.Columns["nombreCliente"].Width = 70;
                dataGridViewVentas.Columns["descripcionFactura"].Width = 60;
                dataGridViewVentas.Columns["tipoPago"].Width = 120;
                dataGridViewVentas.AutoGenerateColumns = false;
                dataGridViewVentas.Columns["total"].DefaultCellStyle.Format = "'$' #,0.00";

                dataGridViewVentas.Columns["total"].DisplayIndex = dataGridViewVentas.Columns.Count - 2;


                if (!dataGridViewVentas.Columns.Contains("btnAnular"))
                {
                    DataGridViewButtonColumn btnAnular = new DataGridViewButtonColumn();
                    btnAnular.Name = "btnAnular";
                    btnAnular.HeaderText = "Acciones";
                    btnAnular.Text = "Anular";
                    btnAnular.UseColumnTextForButtonValue = true;
                    dataGridViewVentas.Columns.Add(btnAnular);

                    btnAnular.DisplayIndex = dataGridViewVentas.Columns.Count - 1;
                    btnAnular.Width = 100;
                    btnAnular.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }

                foreach (DataGridViewColumn column in dataGridViewVentas.Columns)
                {
                    column.HeaderText = column.HeaderText.ToUpper();
                }

                dataGridViewVentas.ClearSelection();

                dataGridViewVentas.Columns["fecha"].HeaderText = "FECHA";
                dataGridViewVentas.Columns["estadoFactura"].HeaderText = "ESTADO";
                dataGridViewVentas.Columns["nombreUsuario"].HeaderText = "USUARIO";
                dataGridViewVentas.Columns["nombreCliente"].HeaderText = "CLIENTE";
                dataGridViewVentas.Columns["descripcionFactura"].HeaderText = "FACTURA";
                dataGridViewVentas.Columns["tipoPago"].HeaderText = "TIPO PAGO";
                dataGridViewVentas.Columns["total"].HeaderText = "TOTAL";

                dataGridViewVentas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las ventas: " + ex.Message + "\n" + ex.StackTrace);
            }

        }
        private void FVentas_Load(object sender, EventArgs e)
        {
            ListarVentas();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
        }

        private void TxtBuscarFactura_TextChanged(object sender, EventArgs e)
        {
            string buscaText = TxtBuscarFactura.Text;

            ListarVentas(buscaText);

        }

        private void dataGridViewVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewVentas.Columns["btnAnular"].Index && e.RowIndex >= 0)
            {
                int idVenta = Convert.ToInt32(dataGridViewVentas.Rows[e.RowIndex].Cells["idVenta"].Value);

                var result = MessageBox.Show("¿Estás seguro de que quieres anular esta venta?", "Confirmar Anulación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    bool anulado = _businessVentas.AnularVenta(idVenta);

                    if (anulado)
                    {
                        MessageBox.Show("La venta ha sido anulada exitosamente.");
                        ListarVentas(); 
                    }
                    else
                    {
                        MessageBox.Show("No se pudo anular la venta.");
                    }
                }
            }
        }
    }
}

