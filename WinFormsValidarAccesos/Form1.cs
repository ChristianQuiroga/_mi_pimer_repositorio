namespace WinFormsValidarAccesos
{
    public partial class Form1 : Form
    {
        const string mi_pass = "12345678";
        const char categoria = 'U';
        public int intentos = 1;

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {


            String getpass;
            string descrip;

            //label1.Text = "VALIDAR DATOS DE ACCESOS";
            //Console.WriteLine("========================");
            //label2.Text = "Get your Password!";

            getpass = textBox1.Text;

            switch (categoria)
            {
                case 'A':
                    descrip = "Es Administrador!";
                    break;
                case 'U':
                    descrip = "Es Usuario";
                    break;
                default:
                    descrip = "Sin Perfil";
                    break;

            }

            if (getpass == mi_pass && intentos == 1)
            {
                label3.Text = $"Datos correctos, Bien venido!, el perfil es {descrip}";
            }
            else
            {
                label3.Text = "Datos incorrectos!";
                label2.Text = "Get your Password, again!";
                //getpass = int.Parse(Console.ReadLine());
                //getpass = textBox1.Text;
            }

            if (getpass == mi_pass && intentos == 2)
            {
                label3.Text = $"Datos correctos, Bien venido!, el perfil es {descrip}";
            }
            else
            {
                label3.Text = "Datos incorrectos! reinciar el sistema!";
            }


            this.intentos += 1;
            //Console.ReadKey();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}