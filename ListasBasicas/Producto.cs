using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasBasicas
{
    internal class Producto
    {

        //las Propiedades van en Mayuscula. Son propiedades son Autoimplementadas get set, no hace falta crearlas otra vez. Solo las creas cuando cuando creas una propiedad Full.
        //Los Atributos en minusculas
        public int Id {  get; set; }
        public string Nombre { get; set; }
        public float PrecioCompra { get; set; }
        public string Categoria { get; set; }



    }
}
