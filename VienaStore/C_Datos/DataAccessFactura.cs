using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VienaStore.C_Datos
{
    internal class DataAccessFactura
    {
        public List<Factura> ObtenerTiposFactura(string buscar = null)
        {
            List<Factura> tiposFactura = new List<Factura>();

            try
            {
                using (SqlConnection connection = DataAccess.DatabaseConnection.GetConnection())
                {
                    string query = @"SELECT id_factura, descripcion FROM Factura";
                    SqlCommand command = new SqlCommand();

                    if (!string.IsNullOrEmpty(buscar))
                    {
                        query += @" WHERE id_factura LIKE @buscar OR descripcion LIKE @buscar";
                        command.Parameters.Add(new SqlParameter("@buscar", $"%{buscar}%"));
                    }

                    command.CommandText = query;
                    command.Connection = connection;

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        tiposFactura.Add(new Factura
                        {
                            IdFactura = int.Parse(reader["id_factura"].ToString()),
                            Descripcion = reader["descripcion"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener tipos de factura", ex);
            }

            return tiposFactura;
        }


        public int ObtenerIdFacturaPorDescripcion(string descripcion)
        {
            int idFactura = 0;

            try
            {
                SqlConnection connection = DataAccess.DatabaseConnection.GetConnection();

                string query = @"SELECT id_factura FROM Factura WHERE descripcion = @descripcion";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@descripcion", descripcion));

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    idFactura = Convert.ToInt32(reader["id_factura"]); 
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener ID de factura por descripción", ex);
            }
            finally
            {
                DataAccess.DatabaseConnection.GetConnection().Close();
            }

            return idFactura; 
        }
    }
}
