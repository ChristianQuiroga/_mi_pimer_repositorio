using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas
{
    public partial class ActividadClase_ProductosConE : Form
    {
        public ActividadClase_ProductosConE()
        {
            InitializeComponent();
        }

        ProductoConE productoConE;
        private void ActividadClase_ProductosConE_Load(object sender, EventArgs e)
        {
            productoConE = new ProductoConE();
            Producto[] productos = {new Producto(1,"Notebook Lenovo"),
                                    new Producto(2,"Mouse Genius"),
                                    new Producto(3,"Teclado Generico"),
                                    new Producto(4,"Procesa6dor intel I5"),
                                    new Producto(5,"Kinstong de 16 GB"),
                                    new Producto(6,"Monitor 20")
            };

            productoConE.InsertarEnLista(productos);
            dgProductosConE.AutoGenerateColumns = true;
            dgProductosConE.DataSource = productoConE.MostrarLista();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgProductosConE.DataSource = null;
            productoConE.LimpiarLista();
            dgProductosConE.Refresh();
        }
    }
}
