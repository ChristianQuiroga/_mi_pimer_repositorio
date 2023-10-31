using SistemaGestionData;
using SistemaGestionEntities;
using System.Net.Http.Json;
using System.Net;

namespace SistemaGestionUI
{
    public partial class FrmEliminarProducto : Form
    {
        //atributo
        private Producto _producto;
        private int idProducto;
        public FrmEliminarProducto()
        {
            InitializeComponent();
        }

        //constructor
        public FrmEliminarProducto(int IDproducto)
        {
            InitializeComponent();
            this.idProducto = IDproducto;

            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ////Solo hacemos eso.
            //ProductoData.EliminarProducto(_producto);
            //MessageBox.Show("Se elimino correctamente");
            EliminarProducto(this._producto);
            this.Close();

        }

        private void FrmEliminarProducto_Load(object sender, EventArgs e)
        {
            //this.txtDescripcion.Text = _producto.Descripciones;
            //this.numCosto.Value = _producto.Costo;
            //this.numVenta.Value = _producto.PrecioVenta;
            //this.numStock.Value = _producto.Stock;
            //this.txtUsuario.Text = _producto.IdUsuario.ToString();

            CargarDatos();
        }

        private async void CargarDatos()
        {
            HttpClient client = new HttpClient();

            string path = @"https://localhost:7005/api/Productos";
            HttpResponseMessage response = await client.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {
                var list = await response.Content.ReadFromJsonAsync<List<Producto>>();
                this._producto = list.Where(x => x.Id.Equals(idProducto)).SingleOrDefault();

                txtDescripcion.Text = _producto.Descripciones;
                numCosto.Value = _producto.Costo;
                numVenta.Value = _producto.PrecioVenta;
                numStock.Value = _producto.Stock;
                txtUsuario.Text = _producto.IdUsuario.ToString();
            }
        }


        private async Task<bool> EliminarProducto(Producto pproducto)
        {
            string path = @"https://localhost:7005/api/Productos";
            HttpClient client = new HttpClient();
            try
            {
                HttpRequestMessage request = new HttpRequestMessage
                {
                    Content = JsonContent.Create(pproducto.Id),
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri(path, UriKind.Absolute)
                };

                HttpResponseMessage response = await client.SendAsync(
          request);
                response.EnsureSuccessStatusCode();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show("Se elimino correctamente");
                    this.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al intentar eliminar el cliente");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al intentar eliminar el cliente");

                return false;
            }

        }
    }
}
