
using System.Runtime.CompilerServices;

namespace SistemaGestionAfter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de producto");

            List<Producto> lista = Contexto.ListarProductos();
            foreach (Producto item in lista) 
            {
                Console.WriteLine("Descripción " + item.Descripciones);
            }

            Producto producto = new Producto();
            //le pido al usuario los datos.
            producto.PrecioVenta = 5000;
            producto.Costo = 100;
            producto.Descripciones = "Gorras";
            producto.Stock = 100;
            producto.IdUsuario = 1;
            Contexto.CrearProducto(producto);
        }
    }
}