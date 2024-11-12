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

namespace VienaStore.C_Presentacion.Vendedor
{
    public partial class FVentas : Form
    {
        // Instancia de la capa de negocio
        private BusinessVentas _businessVentas;

        public FVentas()
        {
            InitializeComponent();
            _businessVentas = new BusinessVentas();
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

                if (!dataGridViewVentas.Columns.Contains("btnVerFactura"))
                {
                    DataGridViewButtonColumn btnVerFactura = new DataGridViewButtonColumn();
                    btnVerFactura.Name = "btnVerFactura";
                    btnVerFactura.HeaderText = "Acciones";
                    btnVerFactura.Text = "Ver Factura";
                    btnVerFactura.UseColumnTextForButtonValue = true;
                    dataGridViewVentas.Columns.Add(btnVerFactura);

                    btnVerFactura.DisplayIndex = dataGridViewVentas.Columns.Count - 1;

                    btnVerFactura.Width = 100; 
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
            this.Close();
        }

        private void TxtBuscarFactura_TextChanged(object sender, EventArgs e)
        {
            string buscaText = TxtBuscarFactura.Text;

            ListarVentas(buscaText);

        }      
    }
}

