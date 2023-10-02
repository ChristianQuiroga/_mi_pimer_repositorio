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
    public partial class frmEliminarUsuario : Form
    {
        public frmEliminarUsuario()
        {
            InitializeComponent();
            
        }

        //atributo
        private Usuario _usuario;
        //constructor
        public frmEliminarUsuario(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;

            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void frmEliminarUsuario_Load(object sender, EventArgs e)
        {
            txtNombre.Text = this._usuario.Nombre;
            txtApellido.Text = this._usuario.Apellido;
            txtNombreUsuario.Text = this._usuario.NombreUsuario;
            txtContraseña.Text = this._usuario.Contrasena;
            txtMail.Text = this._usuario.Mail;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Solo hacemos eso.
            UsuarioData.EliminarUsuario(_usuario);
            MessageBox.Show("Se grabo correctamente");

            this.Close();
        }
    }
}
