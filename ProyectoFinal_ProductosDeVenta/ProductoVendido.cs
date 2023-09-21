using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_ProductosDeVenta
{
    internal class ProductoVendido
    {

        #region propiedades
        private int _id;
        private int _idProducto;
        private int _stock;
        private int _idVenta;

        public int Id { get => _id; set => _id = value; }
        public int IdProducto { get => _idProducto; set => _idProducto = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public int IdVenta { get => _idVenta; set => _idVenta = value; }
        #endregion

        #region contructores
        //parámetros
        public ProductoVendido(int id, int idProducto, int stock, int idVenta)
        {
            _id = id;
            _idProducto = idProducto;
            _stock = stock;
            _idVenta = idVenta;
        }
        //defecto
        public ProductoVendido() 
        {
            _id = 0;
            _idProducto = 0;
            _stock = 0;
            _idVenta = 0;
        }
        #endregion

    }
}
