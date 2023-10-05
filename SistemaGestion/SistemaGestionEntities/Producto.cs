using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class Producto
    {

        #region Atributos
        private int _id;
        private string? _descripciones;
        private decimal _costo;
        private decimal _precioVenta;
        private decimal _stock;
        private int _idUsuario;
        #endregion


        #region Propiedades
        public int Id { get => _id; set => _id = value; }
        public string? Descripciones { get => _descripciones; set => _descripciones = value; }
        public decimal Costo { get => _costo; set => _costo = value; }
        public decimal PrecioVenta { get => _precioVenta; set => _precioVenta = value; }
        public decimal Stock { get => _stock; set => _stock = value; }
        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        #endregion



        #region Contructores
        //parámetros
        public Producto(int id, string descripcion, decimal costo, decimal precioVenta, decimal stock, int idUsuario)
        {
            this.Id = id;
            this.Descripciones = descripcion;
            this.Costo = costo;
            this.PrecioVenta = precioVenta;
            this.Stock = stock;
            this.IdUsuario = idUsuario;
        }
        //por defecto
        public Producto()
        {
            this.Id = 0;
            this.Descripciones = string.Empty;
            this.Costo = 0.00m;
            this.PrecioVenta = 0.00m;
            this.Stock = 0;
            this.IdUsuario = 0;
        }
        #endregion


    }
}
