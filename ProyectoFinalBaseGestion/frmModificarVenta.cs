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
    public partial class frmModificarVenta : Form
    {
        public frmModificarVenta()
        {
            InitializeComponent();
            
        }


        //Otro constructor el mismo de arriba
        //Atributo _
        private Venta _venta;
        public frmModificarVenta(Venta venta)
        {
            InitializeComponent();
            _venta = venta;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmModificarVenta_Load(object sender, EventArgs e)
        {
            txtId.Text = Convert.ToString(this._venta.Id);
            txtComentarios.Text = this._venta.Comentarios;
            txtIdUsuario.Text = Convert.ToString(this._venta.IdUsuario);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            this._venta.Comentarios = txtComentarios.Text;
            this._venta.IdUsuario = Convert.ToInt32(txtIdUsuario.Text);

            VentaData.ModificarVenta(this._venta);
            MessageBox.Show("Se grabo correctamente");
            this.Close();
        }
    }
}
