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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

namespace VienaStore.C_Datos
{
    internal class DataAccesClientes
    {
        public void InsertCliente(Clientes cliente)
        {
            try
            {
                DataAccess.DatabaseConnection.GetConnection();                
                string query = @"
                        INSERT INTO Clientes (dni, nombre, apellido, direccion, email, telefono)
                        VALUES (@dni, @nombre, @apellido, @direccion, @email, @telefono)";

                SqlCommand cmd = new SqlCommand(query, DataAccess.DatabaseConnection.GetConnection());

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
                DataAccess.DatabaseConnection.GetConnection().Close();
            }
        }

        public List<Clientes> GetClientes()
        {
            List<Clientes> clientes = new List<Clientes>(); 

            try
            {
                DataAccess.DatabaseConnection.GetConnection();
                string query = @"SELECT id_cliente, dni, nombre, apellido, direccion, email, telefono
                                 FROM Clientes";

                SqlCommand command = new SqlCommand(query, DataAccess.DatabaseConnection.GetConnection());   

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    clientes.Add(new Clientes
                    {
                        id = int.Parse(reader["id_cliente"].ToString()),
                        dni = int.Parse(reader["dni"].ToString()),
                        nombre = reader["nombre"].ToString(),
                        apellido = reader["apellido"].ToString(),
                        direccion = reader["direccion"].ToString(),
                        email = reader["email"].ToString(),
                        telefono = reader["telefono"].ToString()
                    });
                }
            }
            catch (Exception)
            {   

                throw;
            }
            finally { DataAccess.DatabaseConnection.GetConnection().Close(); }
            return clientes;

        }



    }
}


