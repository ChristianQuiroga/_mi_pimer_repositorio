using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_ProductosDeVenta
{
    public class ProductoVendido
    {
        #region Atributos
        private int _id;
        private int _idProducto;
        private int _stock;
        private int _idVenta;
        #endregion

        #region Propiedades
        public int Id { get => _id; set => _id = value; }
        public int IdProducto { get => _idProducto; set => _idProducto = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public int IdVenta { get => _idVenta; set => _idVenta = value; }
        #endregion


        #region contructores
        //parámetros
        public ProductoVendido(int id, int idProducto, int stock, int idVenta)
        {
            this.Id = id;
            this.IdProducto = idProducto;
            this.Stock = stock;
            this.IdVenta = idVenta;
        }
        //defecto
        public ProductoVendido() 
        {
            this.Id = 0;
            this.IdProducto = 0;
            this.Stock = 0;
            this.IdVenta = 0;
        }
        #endregion

    }
}
