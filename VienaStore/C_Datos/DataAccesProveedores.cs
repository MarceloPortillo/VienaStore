using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VienaStore.C_Presentacion;

namespace VienaStore.C_Datos
{
    internal class DataAccesProveedores
    {
        public void InsertarProveedor(Proveedores proveedor)
        {
            try
            {
                //Abrir conexion 
                DataAccess.DatabaseConnection.GetConnection();
                string query = @"
				INSERT INTO Proveedores(nombreProveedor, cuit, direccion, telefono, email) VALUES
								        (@nombreProveedor, @cuit, @direccion, @telefono, @email)";

                SqlCommand cmd = new SqlCommand(query, DataAccess.DatabaseConnection.GetConnection());

                cmd.Parameters.AddWithValue("@nombreProveedor", proveedor.nombreProveedor);
                cmd.Parameters.AddWithValue("@cuit", proveedor.cuit);
                cmd.Parameters.AddWithValue("@direccion", proveedor.direccion);
                cmd.Parameters.AddWithValue("@telefono", proveedor.telefono);
                cmd.Parameters.AddWithValue("@email", proveedor.email);

                //Devuelve la cantidad de filas afectdas.
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                if (ex.Message.Contains("IX_Proveedores_CUIT"))
                {
                    throw new Exception("CUIT ya existente, \n Por Favor Ingrese otro.", ex);
                }
                else if (ex.Message.Contains("IX_Proveedores_Email"))
                {
                    throw new Exception("Email ya existente, \n Por Favor Ingrese otro.", ex);
                }
                else
                {
                    throw new Exception("Error al insertar proveedor.", ex);
                }
            }
            finally
            {
                DataAccess.DatabaseConnection.GetConnection().Close();
            }
        }

        public List<Proveedores> GetProveedores()
        {
            List<Proveedores> proveedores = new List<Proveedores>();
            try
            {
                DataAccess.DatabaseConnection.GetConnection();

                string query = @"SELECT id_proveedor, nombreProveedor, cuit, direccion, telefono, email, estado
                                FROM proveedores";

                SqlCommand cmd = new SqlCommand(query, DataAccess.DatabaseConnection.GetConnection());

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    proveedores.Add(new Proveedores
                    {
                        id_proveedor = int.Parse(reader["id_proveedor"].ToString()),
                        nombreProveedor = reader["nombreProveedor"].ToString(),
                        cuit = reader["cuit"].ToString(),
                        direccion = reader["direccion"].ToString(),
                        telefono = reader["telefono"].ToString(),
                        email = reader["email"].ToString(),
                        estado = reader["estado"].ToString()
                    });
                }


            }
            catch (Exception)
            {
                throw;
            }
            finally { DataAccess.DatabaseConnection.GetConnection(); }
            return proveedores;
        }

        public void UpdateProveedor(Proveedores proveedor)
        {
            try
            {
                DataAccess.DatabaseConnection.GetConnection();
                string query = @"
                                UPDATE Proveedores SET
                                                        nombreProveedor = @nombreProveedor,
                                                        cuit = @cuit,
                                                        direccion = @direccion,
                                                        telefono = @telefono,
                                                        email = @email
                                WHERE id_proveedor = @id_proveedor";

                SqlParameter id_proveedor = new SqlParameter("@id_proveedor", proveedor.id_proveedor);
                SqlParameter nombreProveedor = new SqlParameter("@nombreProveedor", proveedor.nombreProveedor);
                SqlParameter cuit = new SqlParameter("@cuit", proveedor.cuit);
                SqlParameter direccion = new SqlParameter("@direccion", proveedor.direccion);
                SqlParameter telefono = new SqlParameter("@telefono", proveedor.telefono);
                SqlParameter email = new SqlParameter("@email", proveedor.email);

                SqlCommand command = new SqlCommand(query, DataAccess.DatabaseConnection.GetConnection());
                command.Parameters.Add(id_proveedor);
                command.Parameters.Add(nombreProveedor);
                command.Parameters.Add(cuit);
                command.Parameters.Add(direccion);
                command.Parameters.Add(telefono);
                command.Parameters.Add(email);
                command.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw;
            }
            finally { DataAccess.DatabaseConnection.GetConnection().Close(); }
        }

        public void DeleteProveedor(int idproveedor)
        {
            try
            {
                DataAccess.DatabaseConnection.GetConnection();

                string query = @"
                                                UPDATE Proveedores
                                                            SET estado = 
                                                                    CASE 
                                                                      WHEN estado = 'ACTIVO' THEN 'ELIMINADO'
                                                                      ELSE 'ACTIVO'
                                                                        END
                                                        WHERE id_proveedor = @id_proveedor";

                SqlParameter id_proveedor = new SqlParameter("@id_proveedor", idproveedor);

                SqlCommand command = new SqlCommand(query, DataAccess.DatabaseConnection.GetConnection());
                command.Parameters.Add(id_proveedor);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar al Proveedor", ex.Message);

            }
            finally
            {
                DataAccess.DatabaseConnection.GetConnection().Close();
            }
        }

        public List<Proveedores> BuscarProveedor(string buscar = null)
        {
            List<Proveedores> proveedor = new List<Proveedores>();

            try
            {
                DataAccess.DatabaseConnection.GetConnection();
                string query = @"SELECT id_proveedor, nombreProveedor, cuit, direccion, telefono, email, estado FROM Proveedores";

                SqlCommand command = new SqlCommand();

                if (!string.IsNullOrEmpty(buscar))
                {
                    query += @" WHERE id_proveedor LIKE @buscar OR nombreProveedor LIKE @buscar OR cuit LIKE @buscar OR direccion LIKE @buscar OR telefono LIKE @buscar OR email LIKE @buscar OR estado LIKE @buscar";
                    command.Parameters.Add(new SqlParameter("@buscar", $"%{buscar}%"));
                }
                command.CommandText = query;
                command.Connection = DataAccess.DatabaseConnection.GetConnection();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    proveedor.Add(new Proveedores
                    {
                        id_proveedor = int.Parse(reader["id_proveedor"].ToString()),
                        nombreProveedor = reader["nombreProveedor"].ToString(),
                        cuit = reader["cuit"].ToString(),
                        direccion = reader["direccion"].ToString(),
                        telefono = reader["telefono"].ToString(),
                        email = reader["email"].ToString(),
                        estado = reader["estado"].ToString()
                    });
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally { DataAccess.DatabaseConnection.GetConnection().Close(); }
            return proveedor;
        }

        public DataTable CargarComboProveedor()
        {
            DataAccess.DatabaseConnection.GetConnection();

            SqlDataAdapter adapter = new SqlDataAdapter("Cargar_Combo_Proveedor", DataAccess.DatabaseConnection.GetConnection());
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable proveedor = new DataTable();
            adapter.Fill(proveedor);
            return proveedor;
        }

    }
}
