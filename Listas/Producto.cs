using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Listas
{
    public class Producto
    {
        //Propiedades autoimplementada
        public int Codigo { get; set; }
        public string Descripcion { get; set; }

        //Constructor 
        public Producto(int codigo, string descripcion)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
        }

    }
}
