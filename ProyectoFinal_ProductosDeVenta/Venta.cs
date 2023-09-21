using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_ProductosDeVenta
{
    internal class Venta
    {

        #region propiedades
        
        private int _id;
        private string _comentarios;
        private int _idUsuario;

        public int Id { get => _id; set => _id = value; }
        public string Comentarios { get => _comentarios; set => _comentarios = value; }
        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        
        #endregion

        #region constructores
        //parámetros
        public Venta(int id, string comentarios, int idUsuario)
        {
            _id = id;
            _comentarios = comentarios;
            _idUsuario = idUsuario;
        }
        //defecto
        public Venta()
        {
            _id = 0;
            _comentarios = string.Empty;
            _idUsuario = 0;
        }
        
        #endregion
    }
}
