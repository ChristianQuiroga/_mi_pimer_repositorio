using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasBasicas
{
    public partial class AlaCarta_actividad : Form
    {
        public AlaCarta_actividad()
        {
            InitializeComponent();
        }

        //Declaramos el Dictionary
        private Dictionary<string, Dictionary<string, double>> menuRestaurante = new Dictionary<string, Dictionary<string, double>>();
            
        private void AlaCarta_actividad_Load(object sender, EventArgs e)
        {
            #region menú
            menuRestaurante.Add("Bebidas", new Dictionary<string, double> { { "Coca Cola",100},
                {"SevenUp",100 },
                {"Fanta",100 }});
            menuRestaurante.Add("Entradas", new Dictionary<string, double> { { "Vite tone", 800},
                {"Rabas",1000 },
                {"Fiambre",200 }});
            menuRestaurante.Add("Plato Principal", new Dictionary<string, double> { { "Lomo",1000},
                {"Milanesa", 500 },
                {"Pasta",800 }});


            lstMenu.Items.Add("Sección\t\t\t\t\tProducto\t\tPrecio");
            //doble foreach
            foreach  (KeyValuePair<string,Dictionary<string,Double>> seccion in menuRestaurante)
            {
                lstMenu.Items.Add(seccion.Key);
                foreach (KeyValuePair<string,Double> precioValor in seccion.Value)
                {
                    lstMenu.Items.Add("\t\t\t\t\t" + precioValor.Key.ToUpper() + "\t\t" + precioValor.Value);
                }
            }
            
            #endregion


        }
    }
}
