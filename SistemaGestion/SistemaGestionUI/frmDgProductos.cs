using SistemaGestionData;
using SistemaGestionEntities;
using System.Data.SqlClient;

namespace SistemaGestionUI
{
    public partial class frmDgProductos : Form
    {
        public frmDgProductos()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarProductos();


            //List<Producto> lista = new List<Producto>();
            //string connectionString = @"Server = 5CG30609HQ; DataBase = BaseGestion; Trusted_Connection = True;";
            //var query = "Select id, descripciones, Costo, stock, PrecioVenta, idusuario From Producto;";

            //try
            //{
            //    using (SqlConnection conexion = new SqlConnection(connectionString))
            //    {
            //        conexion.Open();
            //        using (SqlCommand comando = new SqlCommand(query, conexion))
            //        {
            //            using (SqlDataReader dr = comando.ExecuteReader())
            //            {
            //                if (dr.HasRows)
            //                {
            //                    while (dr.Read())
            //                    {
            //                        var producto = new Producto();

            //                        producto.Id = Convert.ToInt32(dr["ID"]);
            //                        producto.Descripciones = dr["Descripciones"].ToString();
            //                        producto.Costo = Convert.ToDecimal(dr["Costo"]);
            //                        producto.PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]);
            //                        producto.Stock = Convert.ToInt32(dr["Stock"]);
            //                        producto.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);

            //                        lista.Add(producto);

            //                    }
            //                }
            //            }

            //            //opcional.
            //            conexion.Close();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}

            //dgProductos.AutoGenerateColumns = false;
            //dgProductos.DataSource = lista;

        }

        private void CargarProductos()
        {
            List<Producto> lista = ProductoData.ListarProductos();
            dgProductos.AutoGenerateColumns = false;
            dgProductos.DataSource = lista;
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmAltaProducto frmAltaProducto = new frmAltaProducto();
            frmAltaProducto.FormClosed += FrmAltaProducto_FormClosed;
            frmAltaProducto.ShowDialog();
        }

        private void FrmAltaProducto_FormClosed(object? sender, FormClosedEventArgs e)
        {
            CargarProductos();
        }

        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int Id = (int)this.dgProductos.Rows[e.RowIndex].Cells["Id"].Value;
            Producto producto = ProductoData.ListarProductos().Where(x => x.Id == Id).FirstOrDefault();

            if (this.dgProductos.Columns[e.ColumnIndex].Name == "Editar")
            {
                frmModificarProducto modificar = new frmModificarProducto(producto);
                modificar.FormClosed += FrmAltaProducto_FormClosed;
                modificar.ShowDialog();

            }
            else if (this.dgProductos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                FrmEliminarProducto eliminar = new FrmEliminarProducto(producto);
                eliminar.FormClosed += FrmAltaProducto_FormClosed;
                eliminar.ShowDialog();
            }
        }
    }
}