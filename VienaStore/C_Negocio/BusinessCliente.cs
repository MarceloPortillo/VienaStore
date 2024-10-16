﻿using System;
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
            try
            {
                if (cliente.id == 0)

                    dataAcces.InsertCliente(cliente);

                else

                    // MessageBox.Show("Error");
                    dataAcces.UpdateCliente(cliente);
                //return cliente;            

            }
            catch (Exception ex)
            {

                throw new Exception (ex.Message);
            }
           
        }

        public BusinessCliente()
        {
            dataAcces = new DataAccesClientes();
        }

        public List<Clientes> GetClientes(string searchText = null)
        {
            return dataAcces.GetClientes(searchText);
        }

        public void EliminarCliente(int idCliente)
        {
            dataAcces.EliminarCliente(idCliente);
        }

        public void CambiarEstadoCliente(int idCliente, string nuevoEstado)
        {
            dataAcces.CambiarEstadoCliente(idCliente, nuevoEstado);
        }
    }
}