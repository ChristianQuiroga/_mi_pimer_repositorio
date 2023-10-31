using SistemaGestionData;
using SistemaGestionEntities;
using System.Net;
using System.Net.Http.Json;

namespace SistemaGestionUI
{
    public partial class frmModificarProducto : Form
    {
        public frmModificarProducto()
        {
            InitializeComponent();
        }

        //Otro constructor el mismo de arriba
        //Atributo _
        private Producto producto;
        private int idproducto;

        public frmModificarProducto(int IDproducto)
        {
            InitializeComponent();
            idproducto = IDproducto;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.producto.Descripciones = txtDescripcion.Text;
            this.producto.Costo = numCosto.Value;
            this.producto.PrecioVenta = numVenta.Value;
            this.producto.Stock = numStock.Value;
            this.producto.IdUsuario = int.Parse(txtUsuario.Text);

            ProductoData.ModificarProducto(producto);
            MessageBox.Show("Se grabo correctamente");

            this.Close();

        }

        private async Task<bool> ModificarProducto(Producto pproducto)
        {
            HttpClient client = new HttpClient();
            string path = @"https://localhost:7005/api/Productos";

            HttpResponseMessage response = await client.PutAsJsonAsync(
            path, pproducto);
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Se modifico correctamente");
                this.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Ocurrio un error al intentar modificar el cliente");
                return false;
            }
        }
        private async void CargarDatos()
        {
            HttpClient client = new HttpClient();

            string path = @"https://localhost:7005/api/Productos";
            HttpResponseMessage response = await client.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {
                var list = await response.Content.ReadFromJsonAsync<List<Producto>>();
                this.producto = list.Where(x => x.Id.Equals(idproducto)).SingleOrDefault();

                this.txtDescripcion.Text = producto.Descripciones;
                this.numCosto.Value = producto.Costo;
                this.numVenta.Value = producto.PrecioVenta;
                this.numStock.Value = producto.Stock;
                this.txtUsuario.Text = producto.IdUsuario.ToString();
            }
        }

        private void frmModificarProducto_Load(object sender, EventArgs e)
        {
            //this.txtDescripcion.Text = _producto.Descripciones;
            //this.numCosto.Value = _producto.Costo;
            //this.numVenta.Value = _producto.PrecioVenta;
            //this.numStock.Value = _producto.Stock;
            //this.txtUsuario.Text = _producto.IdUsuario.ToString();
            CargarDatos();

        }
    }
}
