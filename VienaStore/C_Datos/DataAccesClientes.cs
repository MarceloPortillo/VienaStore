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
using System.Data;

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
                        INSERT INTO Clientes (dni, nombre, apellido, direccion, email, telefono, estado)
                        VALUES (@dni, @nombre, @apellido, @direccion, @email, @telefono, estado)";

                SqlCommand cmd = new SqlCommand(query, DataAccess.DatabaseConnection.GetConnection());

                // Agregar los parámetros correctamente
                cmd.Parameters.AddWithValue("@dni", cliente.dni);
                cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.apellido);
                cmd.Parameters.AddWithValue("@direccion", cliente.direccion);
                cmd.Parameters.AddWithValue("@email", cliente.email);
                cmd.Parameters.AddWithValue("@telefono", cliente.telefono);
                cmd.Parameters.AddWithValue("@estado", cliente.estado);

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

        public List<Clientes> GetClientes(string search = null)
        {
            List<Clientes> clientes = new List<Clientes>();

            try
            {
                // Obtén la conexión de la clase DatabaseConnection
                using (SqlConnection connection = DataAccess.DatabaseConnection.GetConnection())
                {
                    // Abre la conexión si no está abierta
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open(); // Abre la conexión solo si está cerrada
                    }

                    // Consulta base para obtener los clientes
                    string query = @"SELECT id_cliente, dni, nombre, apellido, direccion, email, telefono, estado
                             FROM Clientes";

                    // Si hay un término de búsqueda, añade una cláusula WHERE
                    if (!string.IsNullOrEmpty(search))
                    {
                        query += @" WHERE id_cliente LIKE @Buscar OR dni LIKE @Buscar OR nombre LIKE @Buscar 
                            OR apellido LIKE @Buscar OR direccion LIKE @Buscar OR email LIKE @Buscar 
                            OR telefono LIKE @Buscar";
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Si hay un término de búsqueda, añade el parámetro con el comodín para búsqueda dinámica
                        if (!string.IsNullOrEmpty(search))
                        {
                            // Usa el comodín '%' para buscar coincidencias parciales
                            command.Parameters.Add(new SqlParameter("@Buscar", "%" + search + "%"));
                        }

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
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
                                    telefono = reader["telefono"].ToString(),
                                    estado = reader["estado"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores personalizado
                throw new Exception("Error al obtener clientes: " + ex.Message);
            }

            return clientes;
        }




        public void UpdateCliente(Clientes cliente)
        {
            try
            {
                DataAccess.DatabaseConnection.GetConnection();
                string query = @"UPDATE  Clientes
                         SET dni = @dni,
                             nombre = @nombre,
                             apellido = @apellido,
                             direccion = @direccion,
                             email = @email,
                             telefono = @telefono
                         WHERE id_cliente = @id";

                SqlParameter dni = new SqlParameter("@dni", cliente.dni);
                SqlParameter nombre = new SqlParameter("@nombre", cliente.nombre);
                SqlParameter apellido = new SqlParameter("@apellido", cliente.apellido);
                SqlParameter direccion = new SqlParameter("@direccion", cliente.direccion);
                SqlParameter email = new SqlParameter("@email", cliente.email);
                SqlParameter telefono = new SqlParameter("@telefono", cliente.telefono);
                SqlParameter id = new SqlParameter("@id", cliente.id);

                SqlCommand command = new SqlCommand(query, DataAccess.DatabaseConnection.GetConnection());
                command.Parameters.Add(dni);
                command.Parameters.Add(nombre);
                command.Parameters.Add(apellido);
                command.Parameters.Add(direccion);
                command.Parameters.Add(email);
                command.Parameters.Add(telefono);
                command.Parameters.Add(id);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                DataAccess.DatabaseConnection.GetConnection().Close();
            }
        }

        public void EliminarCliente(int idCliente)
        {
            try
            {
                DataAccess.DatabaseConnection.GetConnection();
                string query = @"UPDATE Clientes
                         SET estado = 'Inactivo'
                         WHERE id_cliente = @id";

                SqlParameter id = new SqlParameter("@id", idCliente);

                SqlCommand command = new SqlCommand(query, DataAccess.DatabaseConnection.GetConnection());
                command.Parameters.Add(id);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el cliente", ex);
            }
            finally
            {
                DataAccess.DatabaseConnection.GetConnection().Close();
            }
        }

        public void CambiarEstadoCliente(int idCliente, string nuevoEstado)
        {
            try
            {
                DataAccess.DatabaseConnection.GetConnection();
                string query = @"UPDATE Clientes
                         SET estado = @nuevoEstado
                         WHERE id_cliente = @id";

                SqlParameter estadoParam = new SqlParameter("@nuevoEstado", nuevoEstado);
                SqlParameter idParam = new SqlParameter("@id", idCliente);

                SqlCommand command = new SqlCommand(query, DataAccess.DatabaseConnection.GetConnection());
                command.Parameters.Add(estadoParam);
                command.Parameters.Add(idParam);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cambiar el estado del cliente", ex);
            }
            finally
            {
                DataAccess.DatabaseConnection.GetConnection().Close();
            }
        }



    }
}


