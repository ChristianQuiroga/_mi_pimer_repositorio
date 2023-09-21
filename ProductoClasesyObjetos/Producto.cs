using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoClasesyObjetos
{
    internal class Producto
    {
        //con getter y setter
        private int _codigo;
        private string _descripcion;
        private double _precioDeCompra;
        private double _precioDeVenta;
        private string _categoria;

        //parámetros
        public Producto(int codigo, string descripcion, double precioDeCompra, double precioDeVenta, string categoria)
        {
            _codigo = codigo;
            _descripcion = descripcion;
            _precioDeCompra = precioDeCompra;
            _precioDeVenta = precioDeVenta;
            _categoria = categoria;
        }

        //constructor por defecto


    }
}
