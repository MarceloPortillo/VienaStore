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
                SqlConnection connection = DataAccess.DatabaseConnection.GetConnection();

                string query = @"SELECT id_rol, descripcion FROM Rol";

                SqlCommand command = new SqlCommand();

                if (!string.IsNullOrEmpty(buscar))
                {
                    query += @" WHERE id_rol LIKE @buscar OR descripcion LIKE @buscar";
                    command.Parameters.Add(new SqlParameter("@buscar", $"%{buscar}%"));
                }

                command.CommandText = query;
                command.Connection = connection;

                SqlDataReader reader = command.ExecuteReader();

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
                DataAccess.DatabaseConnection.GetConnection().Close();
            }

            return roles;
        }

    }
}
