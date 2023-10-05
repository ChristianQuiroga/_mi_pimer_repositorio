using AppClientesEntities;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppClientesData
{
    public static class ClienteData
    {
        public static List<Cliente> GetClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            string connectionString = @"Server = 5CG30609HQ; DataBase = BaseGestion; Trusted_Connection = True;";
            string query = "Select * from clientes";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var cl = new Cliente();
                                    cl.Id = Convert.ToInt32(dr["Id"]);
                                    cl.NombreApellido = dr["NombreApellido"].ToString();
                                    cl.Domicilio = dr["Domicilio"].ToString();
                                    cl.Telefono = dr["Telefono"].ToString();

                                    clientes.Add(cl);
                                }
                            }
                        }
                    }
                    //opcional
                    conexion.Close();

                }
                return clientes;

            }
            catch (Exception ex)
            {

                
                //throw ex;
                //Console.WriteLine(ex.Message);
                return clientes;
            }

        }
    }
}
