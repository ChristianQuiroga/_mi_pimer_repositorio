using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalBaseGestion
{
    public class Usuario
    {

        #region atributos
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _nombreUsuario;
        private string _contrasena;
        private string _mail;
        #endregion

        #region propiedades
        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public string Contrasena { get => _contrasena; set => _contrasena = value; }
        public string Mail { get => _mail; set => _mail = value; }
        #endregion


        #region Constructores
        //por Defecto
        public Usuario()
        {
            this.Id = 0;
            this.Nombre = string.Empty;
            this.Apellido = string.Empty;
            this.NombreUsuario = string.Empty;
            this.Contrasena = string.Empty;
            this.Mail = string.Empty;
        }
        //Parámetros
        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contrasena, string mail)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NombreUsuario = nombreUsuario;
            this.Contrasena = contrasena;
            this.Mail = mail;
        }
        #endregion
    }
}
