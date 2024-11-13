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
using VienaStore.C_Presentacion.Administrador;

namespace VienaStore.C_Presentacion.Vendedor
{
    public partial class FMisVentas : Form
    {
        private static FMisVentas instancia = null;
        private BusinessVentas _businessVentas;
        public FMisVentas()
        {
            InitializeComponent();
            _businessVentas = new BusinessVentas();
        }
        public static FMisVentas Ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new FMisVentas();
                return instancia;
            }

            return instancia;
        }
        public static void limpiar()
        {
            instancia = null;
        }

        private void FMisVentas_Load(object sender, EventArgs e)
        {

            if (UsuarioLogeado.Usuario != null)
            {
                TxtEmpleado.Text = UsuarioLogeado.Usuario.NombreCompleto;

                ListarMisVentas();
            }
            else
            {
                TxtEmpleado.Text = "No hay usuario logeado";
            }
        }

        private void ListarMisVentas(string searchText = null)
        {
            try
            {
                int idUsuarioLogeado = UsuarioLogeado.IdUsuario;

                List<DataAccessVentaDTO> ventas = _businessVentas.GetMisVentas(idUsuarioLogeado, searchText);

                dataGridViewMisVentas.DataSource = ventas;

                dataGridViewMisVentas.BackgroundColor = Color.LightSalmon;
                dataGridViewMisVentas.Columns["idVenta"].Visible = false;
                dataGridViewMisVentas.Columns["total"].Width = 70;
                dataGridViewMisVentas.Columns["fecha"].Width = 90;
                dataGridViewMisVentas.Columns["estadoFactura"].Width = 50;
                dataGridViewMisVentas.Columns["nombreCliente"].Width = 70;
                dataGridViewMisVentas.Columns["descripcionFactura"].Width = 60;
                dataGridViewMisVentas.Columns["tipoPago"].Width = 140;                

                dataGridViewMisVentas.AutoGenerateColumns = false;
                dataGridViewMisVentas.Columns["total"].DefaultCellStyle.Format = "'$' #,0.00";
                //dataGridViewMisVentas.Columns["btnVerFactura"].Visible = false;

               /* if (!dataGridViewMisVentas.Columns.Contains("btnVerFactura"))
                {
                    DataGridViewButtonColumn btnVerFactura = new DataGridViewButtonColumn();
                    btnVerFactura.Name = "btnVerFactura";
                    btnVerFactura.HeaderText = "Acciones";
                    btnVerFactura.Text = "Ver Factura";
                    btnVerFactura.UseColumnTextForButtonValue = true;
                    dataGridViewMisVentas.Columns.Add(btnVerFactura);

                    btnVerFactura.DisplayIndex = dataGridViewMisVentas.Columns.Count - 1;
                    btnVerFactura.Width = 100;
                    btnVerFactura.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }*/

                foreach (DataGridViewColumn column in dataGridViewMisVentas.Columns)
                {
                    column.HeaderText = column.HeaderText.ToUpper();
                }

                dataGridViewMisVentas.ClearSelection();

                dataGridViewMisVentas.Columns["fecha"].HeaderText = "FECHA";
                dataGridViewMisVentas.Columns["estadoFactura"].HeaderText = "ESTADO";
                dataGridViewMisVentas.Columns["nombreCliente"].HeaderText = "CLIENTE";
                dataGridViewMisVentas.Columns["descripcionFactura"].HeaderText = "FACTURA";
                dataGridViewMisVentas.Columns["tipoPago"].HeaderText = "TIPO PAGO";
                dataGridViewMisVentas.Columns["total"].HeaderText = "TOTAL";

                dataGridViewMisVentas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las ventas: " + ex.Message + "\n" + ex.StackTrace);
            }
        }

    }
}
