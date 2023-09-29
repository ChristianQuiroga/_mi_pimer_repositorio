namespace Listas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ListaMayores mayores;

        private void CargarMayores()
        {
            dgMayores.AutoGenerateColumns = true; //genera las columnas automaticamente.
            dgMayores.DataSource = mayores.GetListaMayores().ToList(); //que me traiga la lista.
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            mayores = new ListaMayores();
            Cliente[] clientes =
            {
                new Cliente("Juan Perez", 1234, "Larrea 492",52),
                new Cliente("Luis Perea", 451, "Rivadavia 492",4552),
                new Cliente("Natalia Paez", 1934, "Holguin 492",7052),
                new Cliente("Ruben Holbmer", 100, "Corrientes 492",2052),
                new Cliente("Jose Waiver", 134, "San Juan 492",2052)
            };

            mayores.InsertaEnLista(clientes);
            CargarMayores();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cliente aModificar = new Cliente("Natalia Paez", 1934, "Holguin 492", 7052);
            Cliente clienteNuevo = new Cliente("Francisco Juares", 1934, "San Diego 492", 45);
            mayores.Modificar(aModificar, clienteNuevo);

            CargarMayores();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Cliente clienteBorrar = new Cliente("Juan Perez", 1234, "Larrea 492", 52);
            //primero se desvincula la grilla, porque sino da error.
            dgMayores.DataSource = null;
            mayores.Borrar(clienteBorrar);
            CargarMayores();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            mayores.Ordenar();
            CargarMayores();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgMayores.DataSource = null;
            dgMayores.Refresh();

            mayores.Limpiar();
        }

        private void btnCargarLista_Click(object sender, EventArgs e)
        {
            dgMayores.Refresh();
            dgMayores.DataSource = mayores.GetListaMayores().ToList();
            //CargarMayores();
            //l
            
        }
    }
}