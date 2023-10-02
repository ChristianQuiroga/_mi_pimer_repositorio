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
    public partial class frmAltaUsuario : Form
    {
        public frmAltaUsuario()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmAltaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario();

            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;
            usuario.NombreUsuario = txtNombreUsuario.Text;
            usuario.Contrasena = txtContraseña.Text;
            usuario.Mail = txtMail.Text;

            UsuarioData.CrearUsuario(usuario);
            MessageBox.Show("Se grabo correctamente");

            this.Close();

        }
    }
}
