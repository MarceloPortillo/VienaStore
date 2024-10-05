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
            List<Clientes> clientes =  businessCliente.GetClientes();
            dataGridView1.DataSource = clientes;    
        }
 
    }
}
    