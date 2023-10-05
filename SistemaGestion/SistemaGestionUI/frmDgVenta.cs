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
    public partial class frmDgVenta : Form
    {
        public frmDgVenta()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CargarVenta()
        {
            List<Venta> lista = VentaData.ListarVentas();
            dgVenta.AutoGenerateColumns = false;
            dgVenta.DataSource = lista;

        }
        private void frmDgVenta_Load(object sender, EventArgs e)
        {
            CargarVenta();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmAltaVenta frm = new frmAltaVenta();
            frm.FormClosed += Frm_FormClosed;
            frm.ShowDialog();
        }

        private void Frm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            CargarVenta();
        }

        private void dgVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int Id = (int)this.dgVenta.Rows[e.RowIndex].Cells["Id"].Value;
            Venta venta = VentaData.ListarVentas().Where(x => x.Id == Id).FirstOrDefault();

            if (this.dgVenta.Columns[e.ColumnIndex].Name == "Editar")
            {
                frmModificarVenta modificar = new frmModificarVenta(venta);
                modificar.FormClosed += Frm_FormClosed;
                modificar.ShowDialog();

            }
            else if (this.dgVenta.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                frmEliminarVenta eliminar = new frmEliminarVenta(venta);
                eliminar.FormClosed += Frm_FormClosed;
                eliminar.ShowDialog();
            }
        }
    }
}
