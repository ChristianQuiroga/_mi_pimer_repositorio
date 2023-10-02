using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalBaseGestion
{
    public class Venta
    {

        #region atributos
        private int _id;
        private string _comentarios;
        private int _idUsuario;
        #endregion



        #region Propiedades
        public int Id { get => _id; set => _id = value; }
        public string Comentarios { get => _comentarios; set => _comentarios = value; }
        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }

        #endregion



        #region constructores
        //parámetros
        public Venta(int id, string comentarios, int idUsuario)
        {
            this.Id = id;
            this.Comentarios = comentarios;
            this.IdUsuario = idUsuario;
        }
        //defecto
        public Venta()
        {
            this.Id = 0;
            this.Comentarios = string.Empty;
            this.IdUsuario = 0;
        }
        #endregion
    }
}
