using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VienaStore.C_Datos
{
    internal class DataAccessVentaDetalle
    {

        public void InsertarVentaDetalle(VentaDetalle detalle)
        {
            try
            {
                // Obtener la conexión
               DataAccess.DatabaseConnection.GetConnection();


                // Query de inserción
                string query = @"
        INSERT INTO Venta_detalle (id_venta, id_producto, cantidad, subtotal, estado) 
        VALUES (@IdVenta, @IdProducto, @Cantidad, @Subtotal, @Estado)";

                // Crear comando SQL
                SqlCommand cmd = new SqlCommand(query, DataAccess.DatabaseConnection.GetConnection());

                // Asignar parámetros
                cmd.Parameters.AddWithValue("@IdVenta", detalle.IdVenta);
                cmd.Parameters.AddWithValue("@IdProducto", detalle.IdProducto);
                cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                cmd.Parameters.AddWithValue("@Subtotal", detalle.Subtotal);
                cmd.Parameters.AddWithValue("@Estado", detalle.Estado);

                // Ejecutar la query
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al insertar el detalle de la venta: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                DataAccess.DatabaseConnection.GetConnection().Close();
            }
        }


    }
}
