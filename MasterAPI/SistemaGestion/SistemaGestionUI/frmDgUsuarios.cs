using SistemaGestionUI;
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
    public partial class frmDgUsuarios : Form
    {
        public frmDgUsuarios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CargarUsuario()
        {
            List<Usuario> lista = UsuarioData.ListarUsuarios();
            dgUsuarios.AutoGenerateColumns = false;
            dgUsuarios.DataSource = lista;
        }



        private void frmDgUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuario();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmAltaUsuario frmAltausuario = new frmAltaUsuario();
            frmAltausuario.FormClosed += FrmAltaUsuario_FormClosed;
            frmAltausuario.ShowDialog();
        }

        private void FrmAltaUsuario_FormClosed(object? sender, FormClosedEventArgs e)
        {
            CargarUsuario();
        }

        private void dgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int Id = (int)this.dgUsuarios.Rows[e.RowIndex].Cells["Id"].Value;
            Usuario usuario = UsuarioData.ListarUsuarios().Where(x => x.Id == Id).FirstOrDefault();

            if (this.dgUsuarios.Columns[e.ColumnIndex].Name == "Editar")
            {
                frmModificarUsuario modificar = new frmModificarUsuario(usuario);
                modificar.FormClosed += FrmAltaUsuario_FormClosed;
                modificar.ShowDialog();


            }
            else if (this.dgUsuarios.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                frmEliminarUsuario eliminar = new frmEliminarUsuario(usuario);
                eliminar.FormClosed += FrmAltaUsuario_FormClosed;
                eliminar.ShowDialog();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
