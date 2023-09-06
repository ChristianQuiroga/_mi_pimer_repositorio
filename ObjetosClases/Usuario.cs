using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosClases
{
    internal class Usuario
    {
        #region atributos
        private string _nombre;
        private string _apellido;
        private int _dni;
        private string _email;
        private int _edad;
        private string _domicilio;
        #endregion

        #region get & set
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Dni { get => _dni; set => _dni = value; }
        public string Email { get => _email; set => _email = value; }
        public int Edad { get => _edad; set => _edad = value; }
        public string Domicilio { get => _domicilio; set => _domicilio = value; }
        #endregion

        #region Constructores
        //Constructores por Defecto!
        public Usuario()
        {
            _nombre = string.Empty;
            _apellido = string.Empty;
            _dni = 0;
            _email = string.Empty;
            _edad = 0;
            _domicilio = string.Empty;
        }
        //Constructores parametrizados THIS
        public Usuario(string nombre, string apellido, int dni, string email, int edad, string domicilio)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._dni = dni;
            this._email = email;
            this._edad = edad;
            this._domicilio = domicilio;
        }

        #endregion

        #region Métodos
        public bool EsMayorEdad()
        {
            return this._edad >= 18;
        }
        public string CambiarDireccion(string domicilio)
        {
            return this._domicilio = domicilio;
        }
        public bool EsGmail()
        {
            return (this._email == string.Empty);
        }

        public void MostrarDatos()
        {
            Console.WriteLine("");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Nombre Apellido: " + _nombre + _apellido);
            Console.WriteLine("DNI: " + _dni);
            Console.WriteLine($"Edad: {_edad}");
            Console.WriteLine($"E-Mail: {_email}");
            Console.WriteLine($"Domicilio: {_domicilio}");
            Console.WriteLine("*******************************************");
        }
        #endregion
    }
}
