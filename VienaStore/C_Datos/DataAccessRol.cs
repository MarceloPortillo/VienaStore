using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VienaStore.C_Datos
{
    internal class DataAccessRol
    {
        public List<Rol> GetRoles(string buscar = null)
        {
            List<Rol> roles = new List<Rol>();

            try
            {
                // Obtener la conexión a la base de datos
                SqlConnection connection = DataAccess.DatabaseConnection.GetConnection();

                // Consulta SQL para seleccionar los roles
                string query = @"SELECT id_rol, descripcion FROM Rol";

                SqlCommand command = new SqlCommand();

                // Si se pasa un valor para buscar, añadir un filtro a la consulta
                if (!string.IsNullOrEmpty(buscar))
                {
                    query += @" WHERE id_rol LIKE @buscar OR descripcion LIKE @buscar";
                    command.Parameters.Add(new SqlParameter("@buscar", $"%{buscar}%"));
                }

                command.CommandText = query;
                command.Connection = connection;

                // Ejecutar la consulta
                SqlDataReader reader = command.ExecuteReader();

                // Leer los resultados y añadirlos a la lista de roles
                while (reader.Read())
                {
                    roles.Add(new Rol
                    {
                        Id_Rol = int.Parse(reader["id_rol"].ToString()),
                        Descripcion = reader["descripcion"].ToString()
                    });
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                // Cerrar la conexión
                DataAccess.DatabaseConnection.GetConnection().Close();
            }

            return roles;  // Devolver la lista de roles
        }

    }
}
