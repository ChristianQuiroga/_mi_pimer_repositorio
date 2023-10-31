using SistemaGestionData;
using SistemaGestionEntities;
using System.Net.Http.Json;

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
            //CargarProductos();
            filtrarAsync();
        }

        private async Task filtrarAsync()
        {
            HttpClient client = new HttpClient();
            // List<Cliente> clientes = ClienteBussiness.GetClientes();

            List<Producto>? list = null;
            try
            {
                string path = @"https://localhost:7005/api/Productos";
                HttpResponseMessage response = await client.GetAsync(path);

                if (response.IsSuccessStatusCode)
                {
                    list = await response.Content.ReadFromJsonAsync<List<Producto>>();
                    dgProductos.AutoGenerateColumns = true;
                    dgProductos.DataSource = list;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error de comunicacion con la API");
            }

        }



        //private void CargarProductos()
        //{
        //    List<Producto> lista = ProductoData.ListarProductos();
        //    dgProductos.AutoGenerateColumns = false;
        //    dgProductos.DataSource = lista;
        //}
        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmAltaProducto frmAltaProducto = new frmAltaProducto();
            frmAltaProducto.FormClosed += FrmAltaProducto_FormClosed;
            frmAltaProducto.ShowDialog();
        }

        private void FrmAltaProducto_FormClosed(object? sender, FormClosedEventArgs e)
        {
            //CargarProductos();
            filtrarAsync();
        }

        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int Id = (int)this.dgProductos.Rows[e.RowIndex].Cells["Id"].Value;
            //Producto producto = ProductoData.ListarProductos().Where(x => x.Id == Id).FirstOrDefault();
            Producto producto = ProductoData.ObtenerProducto(Id);

            if (this.dgProductos.Columns[e.ColumnIndex].Name == "Editar")
            {
                frmModificarProducto modificar = new frmModificarProducto(Id);
                modificar.FormClosed += FrmAltaProducto_FormClosed;
                modificar.ShowDialog();

            }
            else if (this.dgProductos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                FrmEliminarProducto eliminar = new FrmEliminarProducto(Id);
                eliminar.FormClosed += FrmAltaProducto_FormClosed;
                eliminar.ShowDialog();
            }
        }
    }
}