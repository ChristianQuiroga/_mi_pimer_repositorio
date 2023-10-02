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
    public partial class frmDgProductoVendido : Form
    {
        public frmDgProductoVendido()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void CargarProductoVendido()
        {
            List<ProductoVendido> lista = ProductoVendidoData.ListarProductosVendidos();
            dgProductosVendidos.AutoGenerateColumns = false;
            dgProductosVendidos.DataSource = lista;
        }
        private void frmDgProductoVendido_Load(object sender, EventArgs e)
        {
            CargarProductoVendido();
        }

        private void cmdCrear_Click(object sender, EventArgs e)
        {
            frmAltaProductoVendido frmAltaProductoVendido = new frmAltaProductoVendido();
            frmAltaProductoVendido.FormClosed += FrmAltaProductoVendido_FormClosed;
            frmAltaProductoVendido.ShowDialog();
        }

        private void FrmAltaProductoVendido_FormClosed(object? sender, FormClosedEventArgs e)
        {
            CargarProductoVendido();
        }

        private void dgProductosVendidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int Id = (int)this.dgProductosVendidos.Rows[e.RowIndex].Cells["Id"].Value;
            ProductoVendido productoVendido = ProductoVendidoData.ListarProductosVendidos().Where(x => x.Id == Id).FirstOrDefault();

            if (this.dgProductosVendidos.Columns[e.ColumnIndex].Name == "Editar")
            {
                frmModificarProductoVendido modificar = new frmModificarProductoVendido(productoVendido);
                modificar.FormClosed += FrmAltaProductoVendido_FormClosed;
                modificar.ShowDialog();

            }
            else if (this.dgProductosVendidos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                frmEliminarProductoVendido eliminar = new frmEliminarProductoVendido(productoVendido);
                eliminar.FormClosed += FrmAltaProductoVendido_FormClosed;
                eliminar.ShowDialog();
            }
        }
    }
}
