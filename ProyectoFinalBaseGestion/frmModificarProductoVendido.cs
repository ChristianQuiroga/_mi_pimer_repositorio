using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalBaseGestion
{
    public partial class frmModificarProductoVendido : Form
    {
        public frmModificarProductoVendido()
        {
            InitializeComponent();
        }

        //Otro constructor el mismo de arriba
        //Atributo _
        private ProductoVendido _productoVendido;
        public frmModificarProductoVendido(ProductoVendido productoVendido)
        {
            InitializeComponent();
            _productoVendido = productoVendido;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmModificarProductoVendido_Load(object sender, EventArgs e)
        {
            numStock.Value = _productoVendido.Stock;
            numIdProducto.Value = _productoVendido.IdProducto;
            numIdVenta.Value = _productoVendido.IdVenta;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this._productoVendido.Stock = Convert.ToInt32(numStock.Value);
            this._productoVendido.IdProducto = Convert.ToInt32(numIdProducto.Value);
            this._productoVendido.IdVenta = Convert.ToInt32(numIdVenta.Value);

            ProductoVendidoData.ModificarProductoVendido(_productoVendido);
            MessageBox.Show("Se grabo correctamente");
            this.Close();
        }
    }
}
