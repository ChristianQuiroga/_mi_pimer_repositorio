using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public static class VentaData
    {
        public static string connectionString = @"Server = 5CG30609HQ; DataBase = BaseGestion; Trusted_Connection = True;";

        //public static Venta ObtenerVenta(int id)
        //{
        //    Venta venta = new Venta();

        //    string connectionString = @"Server = 5CG30609HQ; DataBase = BaseGestion; Trusted_Connection = True;";
        //    string query = "Select id, comentarios, idUsuario From Venta Where id = @id";

        //    try
        //    {
        //        using (SqlConnection conexion = new SqlConnection(connectionString))
        //        {
        //            conexion.Open();

        //            using (SqlCommand comando = new SqlCommand(query, conexion))
        //            {
        //                comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = id });

        //                using (SqlDataReader dr = comando.ExecuteReader())
        //                {
        //                    if (dr.HasRows)
        //                    {
        //                        while (dr.Read())
        //                        {
        //                            venta.Id = Convert.ToInt32(dr["Id"]);
        //                            venta.Comentarios = dr["Comentarios"].ToString();
        //                            //venta.IdUsuario = dr["idUsuario"].ToString();
        //                            venta.IdUsuario = Convert.ToInt32(dr["Id"]);
        //                        }
        //                    }
        //                }
        //            }

        //            // Opcional
        //            conexion.Close();
        //        }
        //        return venta;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}


        public static List<Venta> ListarVentas()
        {
            List<Venta> listarVentas = new List<Venta>();
            //var listarVentas = new List<Venta>();  Otra forma

            //string connectionString = @"Server = 5CG30609HQ; DataBase = BaseGestion; Trusted_Connection = True;";
            var query = "Select id, comentarios, idUsuario From Venta ";

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
                                    var venta = new Venta();

                                    venta.Id = Convert.ToInt32(dr["ID"]);
                                    venta.Comentarios = dr["Comentarios"].ToString();
                                    venta.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);

                                    listarVentas.Add(venta);
                                }
                            }
                        }
                        conexion.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
                //MessageBox.Show(ex.Message);
            }

            return listarVentas;
        }


        public static void CrearVenta(Venta venta)
        {
            //string connectionString = @"Server = 5CG30609HQ; DataBase = BaseGestion; Trusted_Connection = True;";
            var query = "Insert Into Venta(Comentarios, idUsuario)" +
                        "Values(@Comentarios, @idUsuario)";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {

                        comando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                        comando.Parameters.Add(new SqlParameter("idUsuario", SqlDbType.VarChar) { Value = venta.IdUsuario });

                        comando.ExecuteNonQuery();

                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {

                throw;
                //MessageBox.Show("Error en..." + ex);
            }
        }


        public static void ModificarVenta(Venta venta)
        {
            //string connectionString = @"Server = 5CG30609HQ; DataBase = BaseGestion; Trusted_Connection = True";
            var query = "Update Venta " +
                        "Set Comentarios = @Comentarios, IdUsuario = @IdUsuario " +
                        "Where id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = venta.Id });

                        comando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.VarChar) { Value = venta.IdUsuario });

                        comando.ExecuteNonQuery();

                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
                //MessageBox.Show("Error en..." + ex);
            }
        }


        public static void EliminarVenta(int Id)
        {
            //string connectionString = @"Server = 5CG30609HQ; DataBase = BaseGestion; Trusted_Connection = True;";
            var query = "Delete From Venta Where id = @Id";

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
            }
            catch (Exception ex)
            {

                throw;
                //MessageBox.Show("Error en..." + ex);
            }
        }
    }
}
