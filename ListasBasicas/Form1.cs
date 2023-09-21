namespace ListasBasicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //declaramos el Diccionario  a nivel clase, y pueda ser visible en nuestro botones.
        private Dictionary<string, string> ciudadesxPaises = new Dictionary<string, string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lblSaludo.Text += " Christian";

            //declaramos un array
            string[] razaPerrosArray = new string[5];
            string[] razaPerrosArray2 = { "Bulldog", "Pastor Aleman", "Dogo Argentino" };


            //una forma de inicializar
            razaPerrosArray[0] = "Dalmata";
            razaPerrosArray[1] = "Overjero Aleman";
            razaPerrosArray[2] = "Salchichas";
            razaPerrosArray[3] = "Caniche";
            razaPerrosArray[4] = "Pequines";

            //lo recorremos con el indice i
            for (int i = 0; i < razaPerrosArray.Length; i++)
            {
                this.lstRazas.Items.Add(razaPerrosArray[i]);
            }

            //recorremos y add al objeto lstRazas
            for (int i = 0; i < razaPerrosArray2.Length; i++)
            {
                this.lstRazas.Items.Add(razaPerrosArray2[i]);
            }

            float mayor = 0;
            //Como son propiedades lo podes hacer "constructor por parámetros"  En este caso no se creo el constructo en la clase Producto.
            Producto[] BebidasGaseosas =
            {
                new Producto() { Id=1, Nombre="Coca cola", PrecioCompra=1700.0f, Categoria="Gaseosa"},
                new Producto() { Id = 2, Nombre = "Pepsi", PrecioCompra = 1800.123456f, Categoria = "Gaseosa" },
                new Producto() { Id = 3, Nombre = "Seven Up", PrecioCompra = 1500.0f, Categoria = "Gaseosa" },
                new Producto() { Id = 4, Nombre = "Manaos", PrecioCompra = 150.123456f, Categoria = "Gaseosa" }
            };

            foreach (var item in BebidasGaseosas)
            {
                if (item.PrecioCompra > mayor)
                {
                    mayor = item.PrecioCompra;
                }
            }

            this.lblPrecioMayor.Text += mayor;

            //
            Producto BebidaMasCara = new Producto();
            //utilizamos un foreach para recorrer el arraya de objetos.
            foreach (Producto bebida in BebidasGaseosas)
            {
                if (bebida.PrecioCompra > BebidaMasCara.PrecioCompra)
                {
                    BebidaMasCara = bebida;
                }
            }
            lblPrecioMasCaro.Text += BebidaMasCara.Nombre;

            //INVESTIGAR TIPO GENERICO!!!!




            //Diccionarios ejemplo se declara afuera a nivel clase
            //tiene que tener visibilidad, si queda en el load nace y muere ahí. En el Load lo cargamos.
            ciudadesxPaises.Add("Bucaramanga", "Chile");
            ciudadesxPaises.Add("Bógota", "Colombia");
            ciudadesxPaises.Add("Sucre", "Bolivia");
            ciudadesxPaises.Add("Buenos Aires", "Argentina");
            ciudadesxPaises.Add("Rio do Janeiro", "Brasil");

            //Usamos el Foreach() para recorrerlo
            foreach (KeyValuePair<string, string> ciudad in ciudadesxPaises)
            {
                lstCiudadesxPaises.Items.Add(ciudad.Key + " - " + ciudad.Value);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string pais;
            if (ciudadesxPaises.ContainsKey("Sucre")) //pregunto si existe x key
            {
                ciudadesxPaises.TryGetValue("Sucre", out pais); //trygetvalue 
                MessageBox.Show("El país donde pertenece la ciudad Sucre es: " + pais);
            }
        }

        private void btnEliminarItem_Click(object sender, EventArgs e)
        {
            ciudadesxPaises.Remove("Bucaramanga");
            lstCiudadesxPaises.Items.Clear();
            //volvemos a cargar la lista. pero se repite el código, hacer un método
            foreach (KeyValuePair<string, string> ciudad in ciudadesxPaises)
            {
                lstCiudadesxPaises.Items.Add(ciudad.Key + " - " + ciudad.Value);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ciudadesxPaises["Buenos Aires"] = "Chile";

            lstCiudadesxPaises.Items.Clear();
            //volvemos a cargar la lista. pero se repite el código, hacer un método
            foreach (KeyValuePair<string, string> ciudad in ciudadesxPaises)
            {
                lstCiudadesxPaises.Items.Add(ciudad.Key + " - " + ciudad.Value);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ciudadesxPaises.Clear();
            lstCiudadesxPaises.Items.Clear();
            MessageBox.Show("Se limpio el contenido del Diccionario");
        }
    }
}