﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VienaStore.C_Negocio;
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
                string query = "INSERT INTO Usuarios (nombre, apellido, dni, direccion, email, telefono, usuario, fechaNacimiento, contrasenia, id_rol) VALUES " +
                                                    "(@nombre,@apellido,@dni,@direccion,@email,@telefono,@usuario,@fechaNacimiento,@contrasenia,@id_rol)";

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
                cmd.Parameters.AddWithValue("@id_rol", usuario.id_rol);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                DataAccess.DatabaseConnection.GetConnection().Close();
            }
        }

        public List<Usuario_Rol> GetUsuarios(string search = null)
        {
            List<Usuario_Rol> usuarios_r = new List<Usuario_Rol>();
            try
            {
                using (SqlConnection connection = DataAccess.DatabaseConnection.GetConnection())
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    string query = @"
                                      SELECT 
                                            id_usuario, dni, nombre, apellido, direccion, email, telefono, usuario, 
                                            CONVERT(VARCHAR(10), fechaNacimiento, 120) AS fechaNacimiento, 
                                            contrasenia, estado, u.id_rol AS id, descripcion
                                            FROM Usuarios u 
                                            JOIN rol r ON u.id_rol = r.id_rol";

                    if (!string.IsNullOrEmpty(search))
                    {
                        query += @" WHERE id_usuario LIKE @Buscar OR dni LIKE @Buscar OR nombre LIKE @Buscar OR apellido LIKE @Buscar 
                                    OR direccion LIKE @Buscar OR email LIKE @Buscar 
                                    OR telefono LIKE @Buscar OR usuario LIKE @Buscar OR descripcion LIKE @Buscar OR estado LIKE @Buscar";
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (!string.IsNullOrEmpty(search))
                        {
                            command.Parameters.Add(new SqlParameter("@Buscar", "%" + search + "%"));
                        }

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                usuarios_r.Add(new Usuario_Rol
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
                                    contrasenia = reader["contrasenia"].ToString(),
                                    id_rol = int.Parse(reader["id"].ToString()),
                                    descripcion = reader["descripcion"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener clientes: " + ex.Message);
            }
            return usuarios_r;
        }

        public void DeleteUsuario(int id_Usuario)
        {
            try
            {
                DataAccess.DatabaseConnection.GetConnection();

                string query = @"
                                                UPDATE Usuarios
                                                            SET estado = 
                                                                    CASE 
                                                                      WHEN estado = 'Activo' THEN 'Inactivo'
                                                                      ELSE 'Activo'
                                                                        END
                                                            WHERE id_usuario = @id_usuario";
                SqlParameter id_usuario = new SqlParameter("@id_usuario", id_Usuario);

                SqlCommand command = new SqlCommand(query, DataAccess.DatabaseConnection.GetConnection());
                command.Parameters.Add(id_usuario);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el usuario", ex.Message);
            }
            finally
            {
                DataAccess.DatabaseConnection.GetConnection().Close();
            }
        }

        public void UpdateUsuario(Usuarios usuario)
        {
            try
            {
                DataAccess.DatabaseConnection.GetConnection();
                string query = @"UPDATE usuarios SET
                                                     nombre = @nombre,
                                                     apellido = @apellido,
                                                     dni = @dni,
                                                     direccion = @direccion,
                                                     email = @email,
                                                     telefono = @telefono,
                                                     usuario = @usuarioParam,
                                                     fechaNacimiento = @fechaNacimiento,
                                                     contrasenia = @contrasenia,
                                                     id_rol = @id_rol
                                                 WHERE id_usuario = @id_usuario";

                SqlParameter nombre = new SqlParameter("@nombre", usuario.nombre);
                SqlParameter apellido = new SqlParameter("@apellido", usuario.apellido);
                SqlParameter dni = new SqlParameter("@dni", usuario.dni);
                SqlParameter direccion = new SqlParameter("@direccion", usuario.direccion);
                SqlParameter email = new SqlParameter("@email", usuario.email);
                SqlParameter telefono = new SqlParameter("@telefono", usuario.telefono);
                SqlParameter usuarioParam = new SqlParameter("@usuarioParam", usuario.usuario);
                SqlParameter fechaNacimiento = new SqlParameter("@fechaNacimiento", usuario.fechaNacimiento);
                SqlParameter contrasenia = new SqlParameter("@contrasenia", usuario.contrasenia);
                SqlParameter id_rol = new SqlParameter("@id_rol", usuario.id_rol);
                SqlParameter id_usuario = new SqlParameter("@id_usuario", usuario.id_usuario);

                SqlCommand command = new SqlCommand(query, DataAccess.DatabaseConnection.GetConnection());

                command.Parameters.Add(nombre);
                command.Parameters.Add(apellido);
                command.Parameters.Add(dni);
                command.Parameters.Add(direccion);
                command.Parameters.Add(email);
                command.Parameters.Add(telefono);
                command.Parameters.Add(usuarioParam);
                command.Parameters.Add(contrasenia);
                command.Parameters.Add(fechaNacimiento);
                command.Parameters.Add(id_rol);
                command.Parameters.Add(id_usuario);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                DataAccess.DatabaseConnection.GetConnection().Close();
            }
        }

        public Usuario_Rol ObtenerUsuarioPorCredenciales(string usuario, string contraseniaEncriptada)
        {
            Usuario_Rol usuarioRol = null;

            try
            {
                using (SqlConnection connection = DataAccess.DatabaseConnection.GetConnection())
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    Console.WriteLine($"Usuario: {usuario}, Contraseña encriptada: {contraseniaEncriptada}");

                    string query = @"
                SELECT 
                    u.id_usuario, u.dni, u.nombre, u.apellido, u.direccion, u.email, u.telefono, u.usuario, 
                    u.fechaNacimiento, u.contrasenia, u.estado, u.id_rol, r.descripcion
                FROM Usuarios u
                JOIN rol r ON u.id_rol = r.id_rol
                WHERE u.usuario = @Usuario AND u.contrasenia = @Contrasenia";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Usuario", usuario);
                        command.Parameters.AddWithValue("@Contrasenia", contraseniaEncriptada);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                usuarioRol = new Usuario_Rol
                                {
                                    id_usuario = Convert.ToInt32(reader["id_usuario"]),
                                    dni = Convert.ToInt32(reader["dni"]),
                                    nombre = reader["nombre"].ToString(),
                                    apellido = reader["apellido"].ToString(),
                                    direccion = reader["direccion"].ToString(),
                                    email = reader["email"].ToString(),
                                    telefono = reader["telefono"].ToString(),
                                    usuario = reader["usuario"].ToString(),
                                    fechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]),
                                    estado = reader["estado"].ToString(),
                                    contrasenia = reader["contrasenia"].ToString(),
                                    id_rol = Convert.ToInt32(reader["id_rol"]),
                                    descripcion = reader["descripcion"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerUsuarioPorCredenciales: " + ex.ToString());
                throw;
            }

            return usuarioRol;
        }

        public string GetNombreCompleto(string usuario)
        {
            string nombreCompleto = "";
            try
            {
                DataAccess.DatabaseConnection.GetConnection();

                string query = "SELECT nombreEmp, apellidoEmp FROM Usuarios WHERE usuario = @usuario";
                SqlCommand cmd = new SqlCommand(query, DataAccess.DatabaseConnection.GetConnection());

                cmd.Parameters.AddWithValue("@usuario", usuario);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string nombre = dr["nombreEmp"].ToString();
                    string apellido = dr["apellidoEmp"].ToString();
                    nombreCompleto = $"{nombre} {apellido}";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                DataAccess.DatabaseConnection.GetConnection().Close();
            }

            return nombreCompleto;
        }
    }
}
