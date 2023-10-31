using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class Venta
    {

        //Otra forma mas simple
        public int Id { get; set; }
        public string? Comentarios { get; set; }
        public int IdUsuario { get; set; }



        //#region atributos
        //private int _id;
        //private string _comentarios;
        //private int _idUsuario;
        //#endregion



        //#region Propiedades
        //public int Id { get => _id; set => _id = value; }
        //public string Comentarios { get => _comentarios; set => _comentarios = value; }
        //public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }

        //#endregion



        //#region constructores
        ////parámetros
        //public Venta(int id, string comentarios, int idUsuario)
        //{
        //    this.Id = id;
        //    this.Comentarios = comentarios;
        //    this.IdUsuario = idUsuario;
        //}
        ////defecto
        //public Venta()
        //{
        //    this.Id = 0;
        //    this.Comentarios = string.Empty;
        //    this.IdUsuario = 0;
        //}
        //#endregion
    }
}
