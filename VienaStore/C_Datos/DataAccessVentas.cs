using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VienaStore.C_Datos
{
    internal class DataAccessVentas
    {
        public void InsertarVenta(Ventas venta)
        {
            try
            {
                // Obtener la conexión
                  DataAccess.DatabaseConnection.GetConnection();

                // Query de inserción modificado para incluir IdCliente
                string query = @"
        INSERT INTO Ventas (total, fecha, estado, id_usuario, id_factura, id_pago, id_cliente) 
        VALUES (@Total, @Fecha, @Estado, @IdUsuario, @IdFactura, @IdPago, @IdCliente);
        SELECT SCOPE_IDENTITY();";

                // Crear comando SQL
                SqlCommand cmd = new SqlCommand(query, DataAccess.DatabaseConnection.GetConnection());

                // Asignar parámetros, ahora incluyendo el IdCliente
                cmd.Parameters.AddWithValue("@Total", venta.Total);
                cmd.Parameters.AddWithValue("@Fecha", venta.Fecha);
                cmd.Parameters.AddWithValue("@Estado", venta.Estado);
                cmd.Parameters.AddWithValue("@IdUsuario", venta.IdUsuario);
                cmd.Parameters.AddWithValue("@IdFactura", venta.IdFactura.HasValue ? (object)venta.IdFactura.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@IdPago", venta.IdPago.HasValue ? (object)venta.IdPago.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@IdCliente", venta.IdCliente); // Aquí se agrega el IdCliente

                // Ejecutar la query y obtener el Id de la venta insertada
                venta.IdVenta = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                // Manejo de errores específicos (puedes personalizar esto)
                if (ex.Message.Contains("FK_ventas_user"))
                {
                    throw new Exception("El usuario especificado no existe.", ex);
                }
                else if (ex.Message.Contains("FK_Ventas_Factura"))
                {
                    throw new Exception("La factura especificada no es válida.", ex);
                }
                else if (ex.Message.Contains("FK_Ventas_FormaPago"))
                {
                    throw new Exception("La forma de pago especificada no es válida.", ex);
                }
                else if (ex.Message.Contains("FK_Ventas_Cliente"))
                {
                    throw new Exception("El cliente especificado no existe.", ex); // Puedes agregar una validación para el cliente
                }
                else
                {
                    throw new Exception("Error al guardar la venta, por favor inténtelo de nuevo.", ex);
                }
            }
            finally
            {
                // Cerrar la conexión
                DataAccess.DatabaseConnection.GetConnection().Close();
            }
        }


    }
}
