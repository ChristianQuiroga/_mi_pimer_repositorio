using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class ProductoConE
    {
        private List<Producto> _productoConE;
        public ProductoConE() 
        {
            _productoConE = new List<Producto>();
        }
        public void InsertarEnLista(Producto[] arrayProducto)
        {
            for (int i = 0; i < arrayProducto.Length; i++)
            {
                if (arrayProducto[i].Descripcion.Contains("E") || arrayProducto[i].Descripcion.Contains("e"))
                {
                    _productoConE.Add(new Producto(arrayProducto[i].Codigo, arrayProducto[i].Descripcion));
                }
            }
        }

        //Método
        public List<Producto> MostrarLista()
        { 
            return _productoConE;
        }
        public void LimpiarLista() { _productoConE.Clear(); }
    }   
}
