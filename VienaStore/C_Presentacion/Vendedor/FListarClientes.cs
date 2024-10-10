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
    public partial class FListarClientes : Form
    {
        private BusinessCliente businessCliente;

        private static FListarClientes instancia = null;
        public static FListarClientes Ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new FListarClientes();
                return instancia;
            }
            return instancia;
        }
        public FListarClientes()
        {
            InitializeComponent();
            businessCliente = new BusinessCliente();

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

        private void FListarClientes_Load(object sender, EventArgs e)
        {
            ListarContactos();
        }

        private void ListarContactos()
        {
            List<Clientes> clientes = businessCliente.GetClientes();
            dataGridView1.DataSource = clientes;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value.ToString() == "Editar")
            {
                FNuevoCliente fNuevoCliente = new FNuevoCliente();
                fNuevoCliente.CargarClientes(new Clientes   
                {
                    id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    dni = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()), 
                    nombre = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    apellido = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    direccion = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    email = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString(),
                    telefono = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString(),
                });
                fNuevoCliente.ShowDialog(this);
            }
        }
    }
}
    