using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_ProductosDeVenta
{
    public static class ProductoVendidoData
    {
        public static ProductoVendido ObtenerProductoVendido(int id)
        {
            ProductoVendido productoVendido = new ProductoVendido();

            string connectionString = @"Server = 5CG30609HQ; DataBase = BaseGestion; Trusted_Connection = True;";
            string query = "Select id, Stock, IdProducto, IdVenta From ProductoVendido Where id = @Id";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = id });

                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    productoVendido.Id = Convert.ToInt32(dr["ID"]);
                                    productoVendido.Stock = Convert.ToInt32(dr["Stock"]);
                                    productoVendido.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                                    productoVendido.IdVenta = Convert.ToInt32(dr["IdVenta"]);
                                }
                            }
                        }
                    }
                    conexion.Close();
                }
                return productoVendido;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public static List<ProductoVendido> ListarProductosVendidos()
        {
            List<ProductoVendido> listarProductosVendidos = new List<ProductoVendido>();

            string connectionString = @"Server = 5CG30609HQ; DataBase = BaseGestion; Trusted_Connection = True;";
            var query = "Select id, Stock, IdProducto, IdVenta From ProductoVendido";

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
                                    var productoVendido = new ProductoVendido();

                                    productoVendido.Id = Convert.ToInt32(dr["ID"]);
                                    productoVendido.Stock = Convert.ToInt32(dr["Stock"]);
                                    productoVendido.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                                    productoVendido.IdVenta = Convert.ToInt32(dr["IdVenta"]);

                                    listarProductosVendidos.Add(productoVendido);

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

            return listarProductosVendidos;
        }


        public static void CrearProductoVendido(ProductoVendido productoVendido)
        {
            string connectionString = @"Server = 5CG30609HQ; DataBase = BaseGestion; Trusted_Connection = True;";
            var query = "Insert Into ProductoVendido( Stock, IdProducto, IdVenta)" +
                        "Values( @Stock, @IdProducto, @IdVenta)";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {

                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.VarChar) { Value = productoVendido.Stock });
                        comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.VarChar) { Value = productoVendido.IdProducto });
                        comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.VarChar) { Value = productoVendido.IdVenta });

                        comando.ExecuteNonQuery(); //ejecutamos el comando, te sirve para contralar, tiene mas operaciones.

                    }
                    conexion.Close(); //cerramos
                }
            }
            catch (Exception ex)
            {

                throw;
                //MessageBox.Show("Error en..." + ex);
            }
        }


        public static void ModificarProductoVendido(ProductoVendido productoVendido)
        {
            string connectionString = @"Server = 5CG30609HQ; DataBase = BaseGestion; Trusted_Connection = True";
            var query = "Update ProductoVendido " +
                        "Set Stock = @Stock, IdProducto = @IdProducto, IdVenta = @idventa " +
                        "Where Id = @id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = productoVendido.Id });

                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.VarChar) { Value = productoVendido.Stock });
                        comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.VarChar) { Value = productoVendido.IdProducto});
                        comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.VarChar) { Value = productoVendido.IdVenta });
                        
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


        public static void EliminarProductoVendido(ProductoVendido productoVendido)
        {
            string connectionString = @"Server = 5CG30609HQ; DataBase = BaseGestion; Trusted_Connection = True;";
            var query = "Delete From ProductoVendido Where Id = @id";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("id", SqlDbType.VarChar) { Value = productoVendido.Id });

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
