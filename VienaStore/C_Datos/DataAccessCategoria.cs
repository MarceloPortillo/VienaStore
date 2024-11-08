using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VienaStore.C_Datos
{
    internal class DataAccessCategoria
    {
        public void InsertarCategoria(Categorias categoria)
        {
			try
			{
				DataAccess.DatabaseConnection.GetConnection();
				string query = @"
				INSERT INTO Categorias(nombreCategoria, descripcion) VALUES (@nombre, @descripcion)";
                Console.WriteLine("Hola");
                SqlCommand cmd = new SqlCommand(query, DataAccess.DatabaseConnection.GetConnection());
				
				cmd.Parameters.AddWithValue("@nombreCategoria",categoria.nombreCategoria);
				cmd.Parameters.AddWithValue("@descripcion", categoria.descripcion);
                cmd.ExecuteNonQuery();

            }
			catch (Exception ex) 
			{
                throw new Exception("El nombre de la categoría ya existe, \n Por Favor Ingrese otro Nombre", ex);
                //MessageBox.Show("EL Nombre de la Categoria ya existe", "Error al Insertar", MessageBoxButtons.OK, MessageBoxIcon.Error);                 
			}
				finally
			{
				DataAccess.DatabaseConnection.GetConnection().Close();
			}
			}
        public List<Categorias> GetCategorias(string buscar = null)
        {
            List<Categorias> categoria = new List<Categorias>();

            try
            {
                DataAccess.DatabaseConnection.GetConnection();
                string query = @"SELECT id_Categoria, nombreCategoria, descripcion, estado FROM Categorias";

                SqlCommand command = new SqlCommand();

                if (!string.IsNullOrEmpty(buscar))
                {
                    query += @" WHERE id_Categoria LIKE @buscar OR nombreCategoria LIKE @buscar OR descripcion LIKE @buscar OR estado LIKE @buscar"; 
                    command.Parameters.Add(new SqlParameter("@buscar", $"%{buscar}%"));
                }
                command.CommandText = query;
                command.Connection = DataAccess.DatabaseConnection.GetConnection() ;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    categoria.Add(new Categorias
                    {   
                        id_Categoria = int.Parse(reader["id_Categoria"].ToString()),
                        nombreCategoria = reader["nombreCategoria"].ToString(),
                        descripcion = reader["descripcion"].ToString(),
                        estado = reader["estado"].ToString()

                    });
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally { DataAccess.DatabaseConnection.GetConnection().Close(); }
            return categoria;
        }

        public  void UpdateCategoria(Categorias categoria)
        {   
            
            try
            {
                DataAccess.DatabaseConnection.GetConnection();

                string query = @"UPDATE categorias SET 
                                                       nombreCategoria  = @nombreCategoria,
                                                       descripcion = @descripcion                                                      
                                                       WHERE id_Categoria = @id_Categoria";                

                SqlParameter id_Categoria = new SqlParameter("@id_Categoria", categoria.id_Categoria);
                SqlParameter nombreCategoria = new SqlParameter("@nombreCategoria", categoria.nombreCategoria);
                SqlParameter descripcion = new SqlParameter("@descripcion", categoria.descripcion);

                SqlCommand command = new SqlCommand(query, DataAccess.DatabaseConnection.GetConnection());
                command.Parameters.Add(id_Categoria);
                command.Parameters.Add(nombreCategoria);
                command.Parameters.Add(descripcion);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally {DataAccess.DatabaseConnection.GetConnection().Close(); }
            
        }

        public void DeleteCategoria(int idCategoria)
        {
            try
            {
                DataAccess.DatabaseConnection.GetConnection();

                string query = @"
                                                UPDATE Categorias
                                                            SET estado = 
                                                                    CASE 
                                                                      WHEN estado = 'Activo' THEN 'Inactivo'
                                                                      ELSE 'Activo'
                                                                        END
                                                        WHERE id_Categoria = @id_categoria";

                SqlParameter id_categoria = new SqlParameter("@id_categoria", idCategoria);

                SqlCommand command = new SqlCommand(query, DataAccess.DatabaseConnection.GetConnection());
                command.Parameters.Add(id_categoria);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar la categoria", ex.Message);

            }
            finally
            {
                DataAccess.DatabaseConnection.GetConnection().Close();
            }
        }

        public DataTable CargarCombo()
        {
            DataAccess.DatabaseConnection.GetConnection();
            
            SqlDataAdapter adapter = new SqlDataAdapter("Cargar_Combo_Categoria", DataAccess.DatabaseConnection.GetConnection());
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;

        }

    }
}
    
	

