using System;
using System.CodeDom;
using System.Collections.Generic;
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
				INSERT INTO Categorias(nombre, descripcion) VALUES (@nombre, @descripcion)";

				SqlCommand cmd = new SqlCommand(query, DataAccess.DatabaseConnection.GetConnection());
				
				cmd.Parameters.AddWithValue("@nombre",categoria.nombre);
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
    }
}
