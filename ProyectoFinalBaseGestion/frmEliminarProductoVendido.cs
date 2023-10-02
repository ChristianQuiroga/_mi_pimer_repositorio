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
    public partial class frmEliminarProductoVendido : Form
    {
        public frmEliminarProductoVendido()
        {
            InitializeComponent();
        }

        //atributo
        private ProductoVendido _productoVendido;
        //constructor
        public frmEliminarProductoVendido(ProductoVendido productoVendido)
        {
            InitializeComponent();
            _productoVendido = productoVendido;

            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void frmEliminarProductoVendido_Load(object sender, EventArgs e)
        {
            numStock.Value = this._productoVendido.Stock;
            numIdProducto.Value = this._productoVendido.IdProducto;
            numIdVenta.Value = this._productoVendido.IdVenta;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Solo hacemos eso.
            ProductoVendidoData.EliminarProductoVendido(_productoVendido);
            MessageBox.Show("Se elimino correctamente");
            this.Close();

        }
    }
}
