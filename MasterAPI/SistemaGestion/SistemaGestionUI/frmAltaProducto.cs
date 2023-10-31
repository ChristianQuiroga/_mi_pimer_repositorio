using SistemaGestionData;
using SistemaGestionEntities;
using SistemaGestionEntities.Responses;
using System.Net.Http.Json;
using System.Net;

namespace SistemaGestionUI
{
    public partial class frmAltaProducto : Form
    {
        public frmAltaProducto()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            ProductoResponse response = new ProductoResponse();


            producto.Descripciones = txtDescripcion.Text;
            producto.Costo = numCosto.Value;
            producto.PrecioVenta = numVenta.Value;
            producto.Stock = numStock.Value;
            producto.IdUsuario = int.Parse(txtUsuario.Text);

            //ProductoData.CrearProducto(producto);
            response = ProductoData.CrearProducto(producto);
            if (response.Mensaje == "OK")
            {
                MessageBox.Show("Se grabo correctamente");
            }
            else
                MessageBox.Show("Ocurrio un error: " + response.Mensaje);

            this.Close();

        }

        private async Task<bool> AltaCliente(Producto producto)
        {
            HttpClient client = new HttpClient();
            string path = @"https://localhost:7005/api/Productos";

            HttpResponseMessage response = await client.PostAsJsonAsync(
            path, producto);
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Se dio de alta correctamente");
                this.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Ocurrio un error al intentar dar de alta");
                return false;
            }
        }

        private void frmAltaProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
