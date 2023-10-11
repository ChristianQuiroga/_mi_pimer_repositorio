using SistemaGestionData;
using SistemaGestionEntities;
using SistemaGestionEntities.Responses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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

        private void frmAltaProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
