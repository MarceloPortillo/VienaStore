using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VienaStore.C_Datos
{
	internal class DataAccessProductos
	{
		public void InsertarProducto(Productos producto)
		{
			try
			{
				DataAccess.DatabaseConnection.GetConnection();
				string query = @"INSERT INTO Productos(nombreProducto, descripcionProducto, stockMin, stock, precioCosto, precioVenta, id_proveedor, id_Categoria) VALUES 
													(@nombreProducto, @descripcionProducto, @stockMin, @stock, @precioCosto, @precioVenta, @id_proveedor, @id_Categoria)";

				SqlCommand cmd = new SqlCommand(query, DataAccess.DatabaseConnection.GetConnection());

				cmd.Parameters.AddWithValue("nombreProducto", producto.nombreProducto);
				cmd.Parameters.AddWithValue("@descripcionProducto", producto.descripcionProducto);
				cmd.Parameters.AddWithValue("@stockMin", producto.stockMin);
				cmd.Parameters.AddWithValue("@stock", producto.stock);
				cmd.Parameters.AddWithValue("@precioCosto", producto.precioCosto);
				cmd.Parameters.AddWithValue("@precioVenta", producto.precioVenta);
				cmd.Parameters.AddWithValue("@id_proveedor", producto.id_proveedor);
				cmd.Parameters.AddWithValue("@id_Categoria", producto.id_Categoria);

				cmd.ExecuteNonQuery();

			}
			catch (SqlException ex)
			{
				if (ex.Message.Contains("CK_Productos_precioCosto"))
				{
                    throw new Exception("El precio de costo no puede tener un valor de $0",ex);
				}				
				else if (ex.Message.Contains("CK_Productos_precioVenta_Mayor_precioCosto"))
				{
                    throw new Exception("El precio de venta debe ser Mayor al precio de costo", ex);
				}
                else if (ex.Message.Contains("CK_Productos_StockMin_Menor_Stock"))
                {
                    throw new Exception("El stock Minimo debe ser menor al stock", ex);
                }
				else
				{
                    throw new Exception("Error vuelva a intentarlo", ex);
                }
            }
			finally
			{
				DataAccess.DatabaseConnection.GetConnection().Close();
			}
		}

		public List<Productos_Proveedores_Categorias> GetProductos(string buscar = null)
		{
			List<Productos_Proveedores_Categorias> producto_p = new List<Productos_Proveedores_Categorias>();

			try
			{
				DataAccess.DatabaseConnection.GetConnection();

				string query = @"
									SELECT P.codProducto, P.nombreProducto, P.descripcionProducto, C.nombreCategoria, P.stockMin, P.stock, P.precioCosto, P.precioVenta, A.nombreProveedor, P.estado
									FROM Productos P 
									JOIN Categorias C ON P.id_Categoria = C.id_Categoria
									JOIN Proveedores A ON P.id_proveedor = A.id_proveedor";
				SqlCommand cmd = new SqlCommand();

                if (!string.IsNullOrEmpty(buscar))
				{
                    query += @" WHERE codProducto LIKE @buscar OR nombreProducto LIKE @buscar OR descripcionProducto LIKE @buscar OR nombreCategoria LIKE @buscar OR nombreProveedor LIKE @buscar OR P.estado LIKE @buscar";
                    cmd.Parameters.Add(new SqlParameter("@buscar", $"%{buscar}%"));
                }
				cmd.CommandText = query;
				cmd.Connection = DataAccess.DatabaseConnection.GetConnection() ;

				SqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					producto_p.Add(new Productos_Proveedores_Categorias
					{

						codProducto = int.Parse(reader["codProducto"].ToString()),
						nombreProducto = reader["nombreProducto"].ToString(),
						descripcionProducto = reader["descripcionProducto"].ToString(),
						nombreCategoria = reader["nombreCategoria"].ToString(),
						stockMin = int.Parse(reader["stockMin"].ToString()),
						stock = int.Parse(reader["stock"].ToString()),
						precioCosto = Convert.ToSingle(reader["precioCosto"]),
						precioVenta = Convert.ToSingle(reader["precioVenta"]),
						nombreProveedor = reader["nombreProveedor"].ToString(),
						estado = reader["estado"].ToString()

					});
				}
            }
			catch (Exception ex)
			{
                throw new Exception("Error al obtener clientes: " + ex.Message);                
			}
			return producto_p;
		}

        public void UpdateProductos(Productos Producto)
        {
            try
            {
                DataAccess.DatabaseConnection.GetConnection();
                string query = @"
                                UPDATE Productos SET
                                                        nombreProducto = @nombreProducto,
                                                        descripcionProducto = @descripcionProducto,
                                                        id_Categoria = @id_Categoria,
                                                        stockMin = @stockMin,
                                                        stock = @stock,
														precioCosto = @precioCosto,
														precioVenta = @precioVenta,
														id_proveedor = @id_proveedor
                                WHERE codProducto = @codProducto";

                SqlParameter codProducto = new SqlParameter("@codProducto", Producto.codProducto);
                SqlParameter nombreProducto = new SqlParameter("@nombreProducto", Producto.nombreProducto);
                SqlParameter descripcionProducto = new SqlParameter("@descripcionProducto", Producto.descripcionProducto);
                SqlParameter id_Categoria = new SqlParameter("@id_Categoria", Producto.id_Categoria);
                SqlParameter stockMin = new SqlParameter("@stockMin", Producto.stockMin);
                SqlParameter stock = new SqlParameter("@stock", Producto.stock);
                SqlParameter precioCosto = new SqlParameter("@precioCosto", Producto.precioCosto);
                SqlParameter precioVenta = new SqlParameter("@precioVenta", Producto.precioVenta);
                SqlParameter id_proveedor = new SqlParameter("@id_proveedor", Producto.id_proveedor);



                SqlCommand command = new SqlCommand(query, DataAccess.DatabaseConnection.GetConnection());
                command.Parameters.Add(codProducto);
                command.Parameters.Add(nombreProducto);
                command.Parameters.Add(descripcionProducto);
                command.Parameters.Add(id_Categoria);
                command.Parameters.Add(stockMin);
                command.Parameters.Add(stock);
                command.Parameters.Add(precioCosto);
                command.Parameters.Add(precioVenta);
                command.Parameters.Add(id_proveedor);

                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("CK_Productos_precioCosto"))
                {
                    throw new Exception("El precio de costo no puede tener un valor de $0", ex);
                }
                else if (ex.Message.Contains("CK_Productos_precioVenta_Mayor_precioCosto"))
                {
                    throw new Exception("El precio de venta debe ser Mayor al precio de costo", ex);
                }
                else if (ex.Message.Contains("CK_Productos_StockMin_Menor_Stock"))
                {
                    throw new Exception("El stock Minimo debe ser menor al stock", ex);
                }
                else
                {
                    throw new Exception("Error vuelva a intentarlo", ex);
                }
            }
            finally { DataAccess.DatabaseConnection.GetConnection().Close(); }
        }

        public void DeleteProducto(int cod_producto)
        {
            try
            {
                DataAccess.DatabaseConnection.GetConnection();

                string query = @"
                                                UPDATE Productos
                                                            SET estado = 
                                                                    CASE 
                                                                      WHEN estado = 'ACTIVO' THEN 'ELIMINADO'
                                                                      ELSE 'ACTIVO'
                                                                        END
                                                        WHERE codProducto = @codProducto";

                SqlParameter codProducto = new SqlParameter("@codProducto", cod_producto);

                SqlCommand command = new SqlCommand(query, DataAccess.DatabaseConnection.GetConnection());
                command.Parameters.Add(codProducto);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el producto", ex.Message);

            }
            finally
            {
                DataAccess.DatabaseConnection.GetConnection().Close();
            }
        }

        
        }
    }
    

