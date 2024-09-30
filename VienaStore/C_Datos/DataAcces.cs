using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VienaStore.C_Datos;
using VienaStore.C_Presentacion;
using VienaStore.C_Negocio;
using System.Windows.Forms;

namespace VienaStore.C_Datos
{
    internal class DataAcces
    {
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=VienaStore;Data Source=MARCELO\\SQLEXPRESS\r\n");

        public void InsertCliente(Clientes cliente)
        {
            try
            {
                conn.Open();
                string query = @"
                        INSERT INTO Clientes (dni, nombre, apellido, direccion, email, telefono)
                        VALUES (@dni, @nombre, @apellido, @direccion, @email, @telefono)";

                SqlCommand cmd = new SqlCommand(query, conn);

                // Agregar los parámetros correctamente
                cmd.Parameters.AddWithValue("@dni", cliente.dni);
                cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.apellido);
                cmd.Parameters.AddWithValue("@direccion", cliente.direccion);
                cmd.Parameters.AddWithValue("@email", cliente.email);
                cmd.Parameters.AddWithValue("@telefono", cliente.telefono);

                // Ejecutar la consulta
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el cliente: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}


