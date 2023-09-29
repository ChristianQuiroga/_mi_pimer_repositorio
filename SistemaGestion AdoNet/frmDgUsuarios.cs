using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion_AdoNet
{
    public partial class frmDgUsuarios : Form
    {
        public frmDgUsuarios()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dgUsuarios.AutoGenerateColumns = false;
            dgUsuarios.DataSource = Contexto.DevolverUsuarios();


        }
    }
}
