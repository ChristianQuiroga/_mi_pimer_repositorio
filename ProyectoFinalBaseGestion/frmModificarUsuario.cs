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
    public partial class frmModificarUsuario : Form
    {
        public frmModificarUsuario()
        {
            InitializeComponent();
            
        }

        //Otro constructor el mismo de arriba
        //Atributo _
        private Usuario _usuario;
        public frmModificarUsuario(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;

            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this._usuario.Nombre = txtNombre.Text;
            this._usuario.Apellido = txtApellido.Text;
            this._usuario.NombreUsuario = txtNombreUsuario.Text;
            this._usuario.Contrasena = txtContraseña.Text;
            this._usuario.Mail = txtMail.Text;

            UsuarioData.ModificarUsuario(_usuario);
            MessageBox.Show("Se grabo correctamente");

            this.Close();
        }

        private void frmModificarUsuario_Load(object sender, EventArgs e)
        {
            txtNombre.Text = this._usuario.Nombre;
            txtApellido.Text = this._usuario.Apellido;
            txtNombreUsuario.Text = this._usuario.NombreUsuario;
            txtContraseña.Text = this._usuario.Contrasena;
            txtMail.Text = this._usuario.Mail;
        }
    }
}
