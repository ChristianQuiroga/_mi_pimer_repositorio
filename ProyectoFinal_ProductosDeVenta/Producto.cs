using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_ProductosDeVenta
{
    internal class Producto
    {

        #region propiedades
        private int _id;
        private string _descripcion;
        private double _costo;
        private double _precioVenta;
        private int _stock;
        private int _idUsuario;
        #endregion

        #region Contructores
        //parámetros
        public Producto(int id, string descripcion, double costo, double precioVenta, int stock, int idUsuario)
        {
            _id = id;
            _descripcion = descripcion;
            _costo = costo;
            _precioVenta = precioVenta;
            _stock = stock;
            _idUsuario = idUsuario;
        }
        //por defecto
        public Producto() 
        {
            _id = 0;
            _descripcion = string.Empty;
            _costo = 0.00d;
            _precioVenta = 0.00D;
            _stock = 0;
            _idUsuario = 0;
        }
        #endregion

        #region Get/Set
        public int Id { get => _id; set => _id = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public double Costo { get => _costo; set => _costo = value; }
        public double PrecioVenta { get => _precioVenta; set => _precioVenta = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        #endregion
    }
}
