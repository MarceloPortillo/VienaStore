using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace VienaStore.C_Datos
{
    public class DataAccessFormaPago
    {
        public List<FormaPago> ObtenerTiposPago()
        {
            List<FormaPago> tiposPago = new List<FormaPago>();

            try
            {
                SqlConnection connection = DataAccess.DatabaseConnection.GetConnection();

                string query = @"SELECT id_pago, descripcion FROM FormaPago";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    tiposPago.Add(new FormaPago
                    {
                        id_pago = Convert.ToInt32(reader["id_pago"]),
                        descripcion = reader["descripcion"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los tipos de pago", ex);
            }
            finally
            {
                DataAccess.DatabaseConnection.GetConnection().Close();
            }

            return tiposPago;
        }
    }
}
