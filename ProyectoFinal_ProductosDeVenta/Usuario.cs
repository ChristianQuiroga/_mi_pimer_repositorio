using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_ProductosDeVenta
{
    internal class Usuario
    {

        #region Propiedades
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _nombreUsuario;
        private string _contrasena;
        private string _mail;
        #endregion


        #region Constructores
        //por Defecto
        public Usuario()
        {
            this._id = 0;
            this._nombre = string.Empty;
            this._apellido = string.Empty;
            this._nombreUsuario = string.Empty;
            this._contrasena = string.Empty;
            this._mail = string.Empty;
        }
        //Parámetros
        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contrasena, string mail)
        {
            this._id = id;
            this._nombre = nombre;
            this._apellido = apellido;
            this._nombreUsuario = nombreUsuario;
            this._contrasena = contrasena;
            this._mail = mail;
        }
        #endregion

        #region get y set
        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public string Contrasena { get => _contrasena; set => _contrasena = value; }
        public string Mail { get => _mail; set => _mail = value; }
        #endregion

    }
}
