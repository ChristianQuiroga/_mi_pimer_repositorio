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
    public partial class frmEliminarVenta : Form
    {
        public frmEliminarVenta()
        {
            InitializeComponent();
            
        }

        //atributo
        private Venta _venta;
        //constructor
        public frmEliminarVenta(Venta venta)
        {
            InitializeComponent();
            _venta = venta;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmEliminarVenta_Load(object sender, EventArgs e)
        {
            txtId.Text = Convert.ToString(this._venta.Id);
            txtComentarios.Text = this._venta.Comentarios;
            txtIdUsuario.Text = Convert.ToString(this._venta.IdUsuario);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Solo hacemos eso.
            VentaData.EliminarVenta(_venta);
            MessageBox.Show("Se elimino correctamente");
            this.Close();

        }
    }
}
