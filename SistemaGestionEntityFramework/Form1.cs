using System.Data;
using SistemaGestionEntityFramework;

namespace SistemaGestionEntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cliente
            var db = new SistemaGestionContext();

            //Query
            var clientes = db.Clientes
                .OrderBy(x => x.Id)
                .ToList(); //
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = clientes;

            //Producto
            var db1 = new SistemaGestionContext();
            var producto = db1.Productos
                .OrderBy(x => x.Id)
                .ToList();
            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.DataSource = producto;

            //ProductosVendido
            var db2 = new SistemaGestionContext();
            var productoVendido = db1.ProductoVendidos
                .OrderBy(x => x.Id)
                .ToList();
            dataGridView3.AutoGenerateColumns = true;
            dataGridView3.DataSource = productoVendido;

            //Usuario
            var db3 = new SistemaGestionContext();
            var usuario = db1.Usuarios
                .OrderBy(x => x.Id)
                .ToList();
            dataGridView4.AutoGenerateColumns = true;
            dataGridView4.DataSource = usuario;

            //Venta
            var db4 = new SistemaGestionContext();
            var venta = db1.Ventas
                .OrderBy(x => x.Id)
                .ToList();
            dataGridView5.AutoGenerateColumns = true;
            dataGridView5.DataSource = venta;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}