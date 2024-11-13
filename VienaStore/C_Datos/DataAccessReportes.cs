using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VienaStore.C_Datos
{
    internal class DataAccessReportes
    {
        public List<usuarios_ventas> reportesUsuarioVentas(DateTime fechaDesde, DateTime fechaHasta)
        {
			List<usuarios_ventas> usuarios = new List<usuarios_ventas>();
			try
			{
				DataAccess.DatabaseConnection.GetConnection();
                string query = @"
                                SELECT u.id_usuario, u.apellido, u.email, u.nombre, u.dni, u.estado AS estadoUsuario, SUM(v.total) AS Total
                                FROM usuarios u
                                JOIN ventas v ON u.id_usuario = v.id_usuario
                                WHERE v.fecha >= @fechaDesde AND v.fecha <= @fechaHasta
                                GROUP BY u.id_usuario, u.apellido, u.email, u.nombre, u.dni, u.estado";


                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta);
                cmd.CommandText = query;
                cmd.Connection = DataAccess.DatabaseConnection.GetConnection();
                SqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
                    usuarios.Add(new usuarios_ventas
                    {
                        id_usuario = int.Parse(reader["id_usuario"].ToString()),
                        nombre = reader["nombre"].ToString(),
                        apellido = reader["apellido"].ToString(),
                        email = reader["email"].ToString(),
                        dni = int.Parse(reader["dni"].ToString()),
                        Total =Convert.ToSingle(reader["Total"])
                    });
                }

			}
			catch (SqlException ex)
			{

				MessageBox.Show(ex.Message);
            }
           return usuarios;
        }    

    }
}
    

