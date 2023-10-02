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
    public partial class frmAltaVenta : Form
    {
        public frmAltaVenta()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.Comentarios = txtComentarios.Text;
            venta.IdUsuario = Convert.ToInt32(txtIdUsuario.Text);

            VentaData.CrearVenta(venta);
            MessageBox.Show("Se grabo correctamente");
            this.Close();
        }

        private void frmAltaVenta_Load(object sender, EventArgs e)
        {

        }
    }
}
