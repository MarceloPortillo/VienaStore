using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VienaStore.C_Presentacion;
using VienaStore.C_Datos;
using System.Windows.Forms;

namespace VienaStore.C_Negocio
{
    internal class BusinessCliente
    {
        private DataAccesClientes dataAcces;

        public void GuardarCliente(Clientes cliente)
        {
            if (cliente.id == 0)
            {
                dataAcces.InsertCliente(cliente);
            }
            else
            {
                MessageBox.Show("Error");
                //return dataAcces.UpdateCliente(cliente);
            }
        }

        public BusinessCliente()
        {
            dataAcces = new DataAccesClientes();
        }

        public List<Clientes> GetClientes()
        {
            return dataAcces.GetClientes();
        }
    }
}
