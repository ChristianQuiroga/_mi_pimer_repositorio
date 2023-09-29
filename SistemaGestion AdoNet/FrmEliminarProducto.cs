using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion_AdoNet
{
    public partial class FrmEliminarProducto : Form
    {
        public FrmEliminarProducto()
        {
            InitializeComponent();
        }

        //atributo
        private Producto _producto;
        //constructor
        public FrmEliminarProducto(Producto producto)
        {
            InitializeComponent();
            _producto = producto;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Solo hacemos eso.
            Contexto.EliminarProducto(_producto);
            MessageBox.Show("Se grabo correctamente");

        }

        private void FrmEliminarProducto_Load(object sender, EventArgs e)
        {
            this.txtDescripcion.Text = _producto.Descripciones;
            this.numCosto.Value = _producto.Costo;
            this.numVenta.Value = _producto.PrecioVenta;
            this.numStock.Value = _producto.Stock;
            this.txtUsuario.Text = _producto.IdUsuario.ToString();
        }
    }
}
