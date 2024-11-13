using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using VienaStore.C_Datos;
using VienaStore.C_Negocio;

namespace VienaStore.C_Presentacion.Administrador
{
    public partial class reportes : Form
    {
        private static reportes instancia = null;

        private BusinessReportes _businessReportes;


        public static reportes Ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new reportes();
                return instancia;
            }
            return instancia;
        }
        public reportes()
        {
            InitializeComponent();

            _businessReportes = new BusinessReportes();
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

        private void reportes_Load(object sender, EventArgs e)
        {
            ListarUsuariosVentas();
        }




        private void ListarUsuariosVentas()
        {
            try
            {
                DateTime fechaDesde = DateDesde.Value.Date;
                DateTime fechaHasta = DateHasta.Value.Date.AddDays(1).AddTicks(-1);
                List<usuarios_ventas> usuariosVentas = _businessReportes.GetreportesUsuarios(fechaDesde, fechaHasta);
                DtaReportes.DataSource = usuariosVentas;
                DtaReportes.BackgroundColor = Color.LightSalmon;

                DtaReportes.Columns["Total"].DefaultCellStyle.Format = "C";
                DtaReportes.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                DtaReportes.Columns["id_usuario"].Visible = false;
                DtaReportes.Columns["direccion"].Visible = false;
                DtaReportes.Columns["telefono"].Visible = false;
                DtaReportes.Columns["usuario"].Visible = false;
                DtaReportes.Columns["fechaNacimiento"].Visible = false;
                DtaReportes.Columns["contrasenia"].Visible = false;
                DtaReportes.Columns["estadoUsuario"].Visible = false;
                DtaReportes.Columns["id_rol"].Visible = false;
                DtaReportes.Columns["IdVenta"].Visible = false;
                DtaReportes.Columns["Fecha"].Visible = false;
                DtaReportes.Columns["Estado"].Visible = false;
                DtaReportes.Columns["IdPago"].Visible = false;
                DtaReportes.Columns["IdUsuario"].Visible = false;
                DtaReportes.Columns["IdFactura"].Visible = false;
                DtaReportes.Columns["IdCliente"].Visible = false;


                DtaReportes.Columns["apellido"].HeaderText = "APELLIDO";
                DtaReportes.Columns["nombre"].HeaderText = "NOMBRE";
                DtaReportes.Columns["email"].HeaderText = "E-MAIL";
                DtaReportes.Columns["dni"].HeaderText = "DNI";
                DtaReportes.Columns["Total"].HeaderText = "TOTAL VENTAS";



                DtaReportes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                DtaReportes.ClearSelection();

                CargarDatosEnGrafico(usuariosVentas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al listar los usuarios por ventas: " + ex.Message);
            }
        }



        private void BtnGererar_Click(object sender, EventArgs e)
        {
            ListarUsuariosVentas();

        }

        private void CargarDatosEnGrafico(List<usuarios_ventas> usuariosVentas)
        {
            // Limpia las series anteriores
            chartVentas.Series.Clear();

            // Crea una nueva serie
            var series = new Series("Ventas Totales")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Double
            };

            // Agrega datos a la serie
            foreach (var usuario in usuariosVentas)
            {
                series.Points.AddXY(usuario.apellido, usuario.Total);
            }

            // Agrega la serie al gráfico
            chartVentas.Series.Add(series);

            // Configura el estilo del gráfico
            chartVentas.ChartAreas[0].AxisX.Title = "Apellido";
            chartVentas.ChartAreas[0].AxisY.Title = "Total Ventas";
            chartVentas.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chartVentas.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartVentas.ChartAreas[0].AxisY.LabelStyle.Format = "C"; 
        }
    }

}
