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
    public partial class frmModificarProducto : Form
    {
        public frmModificarProducto()
        {
            InitializeComponent();
        }

        //Otro constructor el mismo de arriba
        //Atributo _
        private Producto _producto;
        public frmModificarProducto(Producto producto)
        {
            InitializeComponent();
            _producto = producto;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this._producto.Descripciones = txtDescripcion.Text;
            this._producto.Costo = numCosto.Value;
            this._producto.PrecioVenta = numVenta.Value;
            this._producto.Stock = numStock.Value;
            this._producto.IdUsuario = int.Parse(txtUsuario.Text);

            ProductoData.ModificarProducto(_producto);
            MessageBox.Show("Se grabo correctamente");

            this.Close();

        }

        private void frmModificarProducto_Load(object sender, EventArgs e)
        {
            this.txtDescripcion.Text = _producto.Descripciones;
            this.numCosto.Value = _producto.Costo;
            this.numVenta.Value = _producto.PrecioVenta;
            this.numStock.Value = _producto.Stock;
            this.txtUsuario.Text = _producto.IdUsuario.ToString();
        }
    }
}
