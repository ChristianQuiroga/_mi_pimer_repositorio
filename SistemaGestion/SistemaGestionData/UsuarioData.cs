using SistemaGestionEntities;
using SistemaGestionEntities.Responses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaGestionData
{
    public static class UsuarioData
    {
        public static string connectionString = @"Server = 5CG30609HQ; DataBase = BaseGestion; Trusted_Connection = True;";

        //public static Usuario ObtenerNombreUsuario(int Id)
        //public static List<Usuario> ObtenerNombreUsuario(int Id)
        //{
        //    Usuario usuario = new Usuario();
        //    List<Usuario> listaNombre = new List<Usuario>();

        //    string query = "Select id, nombre, apellido, nombreusuario, contraseña, mail From Usuario Where id=@Id";

        //    try
        //    {
        //        using (SqlConnection conexion = new SqlConnection(connectionString))
        //        {
        //            conexion.Open();

        //            using (SqlCommand comando = new SqlCommand(query, conexion))
        //            {
        //                comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = Id });

        //                using (SqlDataReader dr = comando.ExecuteReader())
        //                {
        //                    if (dr.HasRows)
        //                    {
        //                        while (dr.Read())
        //                        {
        //                            //usuario.Id = Convert.ToInt32(dr["Id"]);
        //                            usuario.Nombre = dr["Nombre"].ToString();
        //                            //usuario.Apellido = dr["Apellido"].ToString();
        //                            //usuario.NombreUsuario = dr["nombreusuario"].ToString();
        //                            //usuario.Contrasena = dr["contraseña"].ToString();
        //                            //usuario.Mail = dr["mail"].ToString();
        //                            listaNombre.Add(usuario);
        //                        }
        //                    }
        //                }
        //            }

        //            // Opcional
        //            conexion.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //    return listaNombre;
        //}

        //Traer Nombre Usuario

        #region Trear Nombre
        public static List<Usuario> TraerNombre(string user, string password)
        {
            List<Usuario> listaNombre = new List<Usuario>();
            Usuario usuario = new Usuario();

            string query = "Select Nombre, apellido, mail From Usuario Where NombreUsuario = '@user' AND Contraseña = '@password'"; 

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using(SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        ////comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = Id });
                        comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = user });
                        comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = password });
                        //comando.Parameters.AddWithValue("nombreusuario", user);
                        //comando.Parameters.AddWithValue("contraseña", password);

                        using(SqlDataReader dr = comando.ExecuteReader())
                        //comando.ExecuteScalar();
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    //usuario.Id = Convert.ToInt32(dr["Id"]);
                                    usuario.Nombre = dr["Nombre"].ToString();
                                    //usuario.Apellido = dr["Apellido"].ToString();
                                    //usuario.NombreUsuario = dr["nombreusuario"].ToString();
                                    //usuario.Contrasena = dr["contraseña"].ToString();
                                    //usuario.Mail = dr["mail"].ToString();
                                    listaNombre.Add(usuario);
                                }
                            }
                        }
                    }
                    // Opcional
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return listaNombre;
        }
        #endregion

        #region Validar Usuario
        //public static List<Usuario> ValidarUsuario(string user)
        //{
        //    Usuario usuario = new Usuario();
        //    List<Usuario> listaNombre = new List<Usuario>();

        //    string query = "Select id, nombre, apellido, nombreusuario, contraseña, mail From Usuario Where nombreusuario=@user";

        //    try
        //    {
        //        using (SqlConnection conexion = new SqlConnection(connectionString))
        //        {
        //            conexion.Open();

        //            using (SqlCommand comando = new SqlCommand(query, conexion))
        //            {
        //                comando.Parameters.Add(new SqlParameter("nombreusuario", SqlDbType.VarChar) { Value = user });

        //                using (SqlDataReader dr = comando.ExecuteReader())

        //                {
        //                    if (dr.HasRows)
        //                    {
        //                        while (dr.Read())
        //                        {
        //                            //usuario.Id = Convert.ToInt32(dr["Id"]);
        //                            usuario.Nombre = dr["Nombre"].ToString();
        //                            //usuario.Apellido = dr["Apellido"].ToString();
        //                            //usuario.NombreUsuario = dr["nombreusuario"].ToString();
        //                            //usuario.Contrasena = dr["contraseña"].ToString();
        //                            //usuario.Mail = dr["mail"].ToString();
        //                            listaNombre.Add(usuario);
        //                        }
        //                    }
        //                }
        //            }

        //            // Opcional
        //            conexion.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //    return listaNombre;
        //}

        #endregion

        public static List<Usuario> ListarUsuarios()
        {
            //Creamos una lista del Obj Usuarios, hay dos formas.
            List<Usuario> listaUsuarios = new List<Usuario>();
            //var listaUsarios = new List<Usuario>();

            //pasos para la conexion a la BD
            //string connectionString = @"Server = 5CG30609HQ; DataBase = BaseGestion; Trusted_Connection = True;";
            var query = "Select id, nombre, apellido, nombreusuario, contraseña, mail From Usuario;";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader dr = comando.ExecuteReader())

                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var usuario = new Usuario();

                                    usuario.Id = Convert.ToInt32(dr["ID"]);
                                    usuario.Nombre = dr["Nombre"].ToString();
                                    usuario.Apellido = dr["Apellido"].ToString();
                                    usuario.NombreUsuario = dr["NombreUsuario"].ToString();
                                    usuario.Contrasena = dr["Contraseña"].ToString();
                                    usuario.Mail = dr["Mail"].ToString();

                                    //agrego a la lista
                                    listaUsuarios.Add(usuario);

                                }
                            }
                        }

                        //opcional.
                        conexion.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
                //MessageBox.Show(ex.Message);
            }

            return listaUsuarios;
        }

        //public static void CrearUsuario(Usuario usuario)
        public static UsuarioResponse CrearUsuario(Usuario usuario)
        {
            UsuarioResponse response = new UsuarioResponse();

            //string connectionString = @"Server = 5CG30609HQ; DataBase = BaseGestion; Trusted_Connection = True;";
            var query = "Insert Into Usuario(nombre, apellido, nombreusuario, contraseña, mail)" +
                        "Values(@nombre, @apellido, @nombreusuario, @contraseña, @mail)";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        //se puede determinar si es Procedimiento Tabla o Consulta. Me trae todos los campos en vez de hacer un Select. Procedimiento Almacenados.
                        //comando.CommandType = CommandType.TableDirect;

                        //teda los tipos de datos del sql, varchar, todos los tipos. SQLDbType//System.Data
                        comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                        comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                        comando.Parameters.Add(new SqlParameter("Nombreusuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                        comando.Parameters.Add(new SqlParameter("contraseña", SqlDbType.VarChar) { Value = usuario.Contrasena });
                        comando.Parameters.Add(new SqlParameter("mail", SqlDbType.VarChar) { Value = usuario.Mail });

                        comando.ExecuteNonQuery(); //ejecutamos el comando, te sirve para contralar, tiene mas operaciones.

                    }
                    conexion.Close(); //cerramos
                }
                response.Mensaje = "OK";
                return response;
            }
            catch (Exception ex)
            {

                //throw;
                //MessageBox.Show("Error en..." + ex);
                response.Mensaje = ex.Message;
                return response;

            }
        }

        //public static void ModificarUsuario(Usuario usuario)
        public static UsuarioResponse ModificarUsuario(Usuario usuario)
        {
            UsuarioResponse response = new UsuarioResponse();

            //string connectionString = @"Server = 5CG30609HQ; DataBase = BaseGestion; Trusted_Connection = True";
            var query = "Update Usuario " +
                        "Set Nombre = @nombre, Apellido = @apellido, NombreUsuario = @nombreusuario, contraseña = @contraseña, Mail = @mail " +
                        "Where id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        //teda los tipos de datos del sql, varchar, todos los tipos.
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = usuario.Id });

                        comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                        comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                        comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                        comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contrasena });
                        comando.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });

                        comando.ExecuteNonQuery();

                    }
                    conexion.Close();
                }
                response.Mensaje = "OK";
                return response;
            }
            catch (Exception ex)
            {

                //MessageBox.Show("Error en..." + ex);
                response.Mensaje = ex.Message;
                return response;
            }
        }

        public static UsuarioResponse EliminarUsuario(int Id)
        {
            UsuarioResponse response = new UsuarioResponse();

            //string connectionString = @"Server = 5CG30609HQ; DataBase = BaseGestion; Trusted_Connection = True;";
            var query = "Delete From Usuario Where id = @Id";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = Id });

                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
                response.Mensaje = "OK";
                return response;
            }
            catch (Exception ex)
            {

                response.Mensaje = ex.Message;
                return response;
            }
        }
    }
}
