using System;
using System.Collections.Generic;
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
        INSERT INTO Ventas (total, fecha, id_estado, id_usuario, id_factura, id_pago, id_cliente) 
        VALUES (@Total, @Fecha, @IdEstado, @IdUsuario, @IdFactura, @IdPago, @IdCliente);
        SELECT SCOPE_IDENTITY();";

                // Crear comando SQL
                SqlCommand cmd = new SqlCommand(query, DataAccess.DatabaseConnection.GetConnection());

                // Asignar parámetros, ahora incluyendo el IdCliente
                cmd.Parameters.AddWithValue("@Total", venta.Total);
                cmd.Parameters.AddWithValue("@Fecha", venta.Fecha);
                cmd.Parameters.AddWithValue("@IdEstado", venta.Estado);
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

        public List<DataAccessVentaDTO> GetVentas(string buscar = null)
        {
            List<DataAccessVentaDTO> ventas = new List<DataAccessVentaDTO>();

            try
            {
                DataAccess.DatabaseConnection.GetConnection();

                string query = @"
            SELECT V.id_venta, V.total, V.fecha, E.descripcion AS estadoFactura, 
                   U.nombre + ' ' + U.apellido AS nombreUsuario, 
                   F.descripcion AS descripcionFactura, 
                   C.nombre + ' ' + C.apellido AS nombreCliente, 
                   P.descripcion AS tipoPago
            FROM Ventas V
            JOIN Usuarios U ON V.id_usuario = U.id_usuario
            JOIN Clientes C ON V.id_cliente = C.id_cliente
            JOIN Factura F ON V.id_factura = F.id_factura
            JOIN FormaPago P ON V.id_pago = P.id_pago
            LEFT JOIN EstadoFactura E ON V.id_estado = E.id_estado"; 

                SqlCommand cmd = new SqlCommand();

                if (!string.IsNullOrEmpty(buscar))
                {
                    query += @" WHERE V.id_venta LIKE @buscar OR 
                        C.nombre LIKE @buscar OR 
                        C.apellido LIKE @buscar OR 
                        U.nombre LIKE @buscar OR 
                        F.descripcion LIKE @buscar OR 
                        P.descripcion LIKE @buscar";
                    cmd.Parameters.Add(new SqlParameter("@buscar", $"%{buscar}%"));
                }

                cmd.CommandText = query;
                cmd.Connection = DataAccess.DatabaseConnection.GetConnection();


                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ventas.Add(new DataAccessVentaDTO
                    {
                        idVenta = int.Parse(reader["id_venta"].ToString()),
                        total = Convert.ToSingle(reader["total"]),
                        fecha = Convert.ToDateTime(reader["fecha"]),
                        estadoFactura = reader["estadoFactura"] != DBNull.Value ? reader["estadoFactura"].ToString() : "Desconocido", // Verificar si es null
                        nombreUsuario = reader["nombreUsuario"] != DBNull.Value ? reader["nombreUsuario"].ToString() : "Desconocido",
                        descripcionFactura = reader["descripcionFactura"] != DBNull.Value ? reader["descripcionFactura"].ToString() : "Sin descripción",
                        nombreCliente = reader["nombreCliente"] != DBNull.Value ? reader["nombreCliente"].ToString() : "Desconocido", // Verificar nombre
                        tipoPago = reader["tipoPago"] != DBNull.Value ? reader["tipoPago"].ToString() : "Sin tipo de pago",
                    });
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener ventas: " + ex.Message);
            }

            return ventas;
        }

        public List<DataAccessVentaDTO> GetVentasPorUsuario(int idUsuario, string buscar = null)
        {
            List<DataAccessVentaDTO> ventas = new List<DataAccessVentaDTO>();

            try
            {
                DataAccess.DatabaseConnection.GetConnection();

                string query = @"
                    SELECT V.id_venta, V.total, V.fecha, E.descripcion AS estadoFactura, 
                        U.nombre + ' ' + U.apellido AS nombreUsuario, 
                        F.descripcion AS descripcionFactura, 
                        C.nombre + ' ' + C.apellido AS nombreCliente, 
                        P.descripcion AS tipoPago
                    FROM Ventas V
                    JOIN Usuarios U ON V.id_usuario = U.id_usuario
                    JOIN Clientes C ON V.id_cliente = C.id_cliente
                    JOIN Factura F ON V.id_factura = F.id_factura
                    JOIN FormaPago P ON V.id_pago = P.id_pago
                    LEFT JOIN EstadoFactura E ON V.id_estado = E.id_estado
                    WHERE V.id_usuario = @idUsuario";  

                if (!string.IsNullOrEmpty(buscar))
                {
                    query += @" AND (V.id_venta LIKE @buscar OR 
                                    C.nombre LIKE @buscar OR 
                                    C.apellido LIKE @buscar OR 
                                    F.descripcion LIKE @buscar OR 
                                    P.descripcion LIKE @buscar)";
                }

                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));
                if (!string.IsNullOrEmpty(buscar))
                {
                    cmd.Parameters.Add(new SqlParameter("@buscar", $"%{buscar}%"));
                }

                cmd.Connection = DataAccess.DatabaseConnection.GetConnection();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ventas.Add(new DataAccessVentaDTO
                    {
                        idVenta = int.Parse(reader["id_venta"].ToString()),
                        total = Convert.ToSingle(reader["total"]),
                        fecha = Convert.ToDateTime(reader["fecha"]),
                        estadoFactura = reader["estadoFactura"] != DBNull.Value ? reader["estadoFactura"].ToString() : "Desconocido",
                        nombreUsuario = reader["nombreUsuario"] != DBNull.Value ? reader["nombreUsuario"].ToString() : "Desconocido",
                        descripcionFactura = reader["descripcionFactura"] != DBNull.Value ? reader["descripcionFactura"].ToString() : "Sin descripción",
                        nombreCliente = reader["nombreCliente"] != DBNull.Value ? reader["nombreCliente"].ToString() : "Desconocido",
                        tipoPago = reader["tipoPago"] != DBNull.Value ? reader["tipoPago"].ToString() : "Sin tipo de pago",
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las ventas del usuario: " + ex.Message);
            }

            return ventas;
        }
    }
}
