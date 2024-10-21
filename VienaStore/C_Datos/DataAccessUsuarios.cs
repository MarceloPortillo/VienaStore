using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace VienaStore.C_Datos
{
    internal class DataAccessUsuarios
    {

        public void InsertUsuario(Usuarios usuario)
        {
            try
            {
                DataAccess.DatabaseConnection.GetConnection();
                string query = @"
                INSERT INTO Usuarios (nombre, apellido, dni, direccion, email, telefono, usuario, fechaNacimiento, contrasenia, estado, id_rol)
                VALUES (@nombre, @apellido, @dni, @direccion, @email, @telefono, @usuario, @fechaNacimiento, @contrasenia, @estado, @id_rol)";


                SqlCommand cmd = new SqlCommand(query, DataAccess.DatabaseConnection.GetConnection());

                cmd.Parameters.AddWithValue("@nombre", usuario.nombre);
                cmd.Parameters.AddWithValue("@apellido", usuario.apellido);
                cmd.Parameters.AddWithValue("@dni", usuario.dni);
                cmd.Parameters.AddWithValue("@direccion", usuario.direccion);
                cmd.Parameters.AddWithValue("@email", usuario.email);
                cmd.Parameters.AddWithValue("@telefono", usuario.telefono);
                cmd.Parameters.AddWithValue("@usuario", usuario.usuario);
                cmd.Parameters.AddWithValue("@fechaNacimiento", usuario.fechaNacimiento);
                cmd.Parameters.AddWithValue("@contrasenia", usuario.contrasenia);
                cmd.Parameters.AddWithValue("@estado", usuario.estado ?? "Activo");
                cmd.Parameters.AddWithValue("@id_rol", usuario.id_rol);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("El DNI o el email ingresado ya existen en el sistema.\n Por favor, ingrese un DNI o email diferente.", ex);
            }

            finally 
            {
                DataAccess.DatabaseConnection.GetConnection().Close();
            }
        }

        public List<Usuarios> GetUsuarios(string search = null)
        {
            List<Usuarios> usuarios = new List<Usuarios>();

            try
            {
                // Obtén la conexión de la clase DatabaseConnection
                using (SqlConnection connection = DataAccess.DatabaseConnection.GetConnection())
                {
                    // Abre la conexión si no está abierta
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open(); // Abre la conexión solo si está cerrada
                    }

                    string query = @"SELECT id_usuario, dni, nombre, apellido, direccion, email, telefono, usuario, fechaNacimiento, contrasenia, estado, id_rol
                 FROM Usuarios";

                    if (!string.IsNullOrEmpty(search))
                    {
                        query += @" WHERE dni LIKE @Buscar OR nombre LIKE @Buscar OR apellido LIKE @Buscar 
               OR direccion LIKE @Buscar OR email LIKE @Buscar 
               OR telefono LIKE @Buscar OR usuario LIKE @Buscar";
                    }


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Si hay un término de búsqueda, añade el parámetro con el comodín para búsqueda dinámica
                        if (!string.IsNullOrEmpty(search))
                        {
                            // Usa el comodín '%' para buscar coincidencias parciales
                            command.Parameters.Add(new SqlParameter("@Buscar", "%" + search + "%"));
                        }

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                usuarios.Add(new Usuarios
                                {
                                    id_usuario = int.Parse(reader["id_usuario"].ToString()),
                                    dni = int.Parse(reader["dni"].ToString()),
                                    nombre = reader["nombre"].ToString(),
                                    apellido = reader["apellido"].ToString(),
                                    direccion = reader["direccion"].ToString(),
                                    email = reader["email"].ToString(),
                                    telefono = reader["telefono"].ToString(),
                                    usuario = reader["usuario"].ToString(),
                                    fechaNacimiento = DateTime.Parse(reader["fechaNacimiento"].ToString()),
                                    estado = reader["estado"].ToString(),
                                    id_rol = int.Parse(reader["id_rol"].ToString())
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores personalizado
                throw new Exception("Error al obtener clientes: " + ex.Message);
            }

            return usuarios;
        }
    }
}
