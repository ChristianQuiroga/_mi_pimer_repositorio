using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI
{
    public partial class frmAltaProductoVendido : Form
    {
        public frmAltaProductoVendido()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmAltaProductoVendido_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ProductoVendido productoVendido = new ProductoVendido();
            productoVendido.Stock = Convert.ToInt32(numStock.Value);
            productoVendido.IdProducto = Convert.ToInt32(numIdProducto.Value);
            productoVendido.IdVenta = Convert.ToInt32(numIdVenta.Value);

            ProductoVendidoData.CrearProductoVendido(productoVendido);
            MessageBox.Show("Se grabo correctamente");
            this.Close();
        }
    }
}
