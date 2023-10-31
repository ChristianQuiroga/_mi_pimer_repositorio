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
    public static class ProductoData
    {
        private static string connectionString = @"Server = 5CG30609HQ; DataBase = BaseGestion; Trusted_Connection = True;";

        public static Producto ObtenerProducto(int id) //hay un parámetro Id
        {
            Producto producto = new Producto();
            // Importante: Para que funcione
            // Modifica el parametro Server por el de tu Servidor
            //string connectionString = @"Server = 5CG30609HQ; DataBase = BaseGestion; Trusted_Connection = True;";
            string query = "SELECT Id,Descripciones,Costo,PrecioVenta,Stock,IdUsuario FROM Producto Where Id=@Id"; //@ para que lo reconozca como parámetro. Ojo que el Scalar solo me trae un campo.(Id). Una solo columna de la fila.

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open(); //Abro

                    using (SqlCommand comando = new SqlCommand(query, conexion)) //Command
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = id });

                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    producto.Id = Convert.ToInt32(dr["Id"]);
                                    producto.Descripciones = dr["Descripciones"].ToString();
                                    producto.Costo = Convert.ToDecimal(dr["Costo"]);
                                    producto.PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]);
                                    producto.Stock = Convert.ToInt32(dr["Stock"]);
                                    producto.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                }
                            }
                        }
                    }

                    // Opcional
                    conexion.Close();
                }
                return producto;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static List<Producto> ListarProductos()
        {
            List<Producto> lista = new List<Producto>();
            //string connectionString = @"Server = 5CG30609HQ; DataBase = BaseGestion; Trusted_Connection = True;";
            var query = "Select id, descripciones, Costo, PrecioVenta, stock,  idusuario From Producto";


            try //por cualquier error que se produsca.
            {
                using (SqlConnection conexion = new SqlConnection(connectionString)) //sqlConexion
                {
                    conexion.Open(); //abrir

                    using (SqlCommand comando = new SqlCommand(query, conexion)) //Command
                    {

                        using (SqlDataReader dr = comando.ExecuteReader()) //lista o set de objetos (ExecuteReader)
                        {
                            if (dr.HasRows) //hay filas?
                            {
                                while (dr.Read()) //lo leo!
                                {
                                    var producto = new Producto(); // Creo el obj.

                                    producto.Id = Convert.ToInt32(dr["ID"]); //siempre comvertir al tipo de dato.
                                    producto.Descripciones = dr["Descripciones"].ToString();
                                    producto.Costo = Convert.ToDecimal(dr["Costo"]);
                                    producto.PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]);
                                    producto.Stock = Convert.ToInt32(dr["Stock"]);
                                    producto.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);

                                    lista.Add(producto); //Agrego el obj. a la lista.

                                }
                            }
                        }
                        //opcional, con las llaves muere el objeto, pero como buena practica lo cerr
                        conexion.Close();
                    }

                    return lista;
                }
            }
            catch (Exception ex)
            {
                return null;
                //MessageBox.Show(ex.Message);  ????
            }


        }
        //una clase que no hace falta instanciarla. static, al tener un campo Identity la tabla no la escribimos. Es autoincremental.
        public static ProductoResponse CrearProducto(Producto producto)
        //public static void CrearProducto(Producto producto)
        {
            ProductoResponse response = new ProductoResponse();

            //string connectionString = @"Server = 5CG30609HQ; DataBase = BaseGestion; Trusted_Connection = True;";
            var query = "Insert Into Producto(Descripciones, Costo, Precioventa, stock, Idusuario)" +
                        "Values(@Descripciones, @Costo, @PrecioVenta, @stock, @idusuario)";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open(); //abre la conexion
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        //se puede determinar si es Procedimiento Tabla o Consulta. Me trae todos los campos en vez de hacer un Select. Procedimiento Almacenados.
                        //comando.CommandType = CommandType.TableDirect;

                        //teda los tipos de datos del sql, varchar, todos los tipos. SQLDbType//System.Data
                        comando.Parameters.Add(new SqlParameter("Descripciones", SqlDbType.VarChar) { Value = producto.Descripciones });
                        comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Decimal) { Value = producto.Costo });
                        comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = producto.PrecioVenta });
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Decimal) { Value = producto.Stock });//INT
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = producto.IdUsuario });

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
                response.Mensaje = ex.Message;
                return response;

            }


        }

        //public static void ModificarProducto(Producto producto)
        public static ProductoResponse ModificarProducto(Producto producto)
        {
            ProductoResponse response = new ProductoResponse();


            //string connectionString = @"Server = 5CG30609HQ; DataBase = BaseGestion; Trusted_Connection = True";
            var query = "Update Producto " +
                        "Set Descripciones = @Descripciones, Costo = @Costo, Precioventa = @PrecioVenta, stock = @Stock, Idusuario = @IdUsuario " +
                        "Where id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        //teda los tipos de datos del sql, varchar, todos los tipos.
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = producto.Id });

                        comando.Parameters.Add(new SqlParameter("Descripciones", SqlDbType.VarChar) { Value = producto.Descripciones });
                        comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Decimal) { Value = producto.Costo });
                        comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = producto.PrecioVenta });
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Decimal) { Value = producto.Stock });//INT
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = producto.IdUsuario });

                        comando.ExecuteNonQuery(); //ejecutamos el comando

                    }
                    conexion.Close(); //cerramos
                }
                response.Mensaje = "OK";
                return response;
            }
            catch (Exception ex)
            {

                //throw new Exception("Ocurrio error: " + ex.Message, ex);
                //MessageBox.Show("Error en..." + ex);
                response.Mensaje = ex.Message;
                return response;
            }
        }


        //public static void EliminarProducto(Producto producto)
        public static ProductoResponse EliminarProducto(int Id)
        {
            ProductoResponse response = new ProductoResponse();

            //string connectionString = @"Server = 5CG30609HQ; DataBase = BaseGestion; Trusted_Connection = True;";
            var query = "Delete From Producto Where id = @Id";

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
