using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Cliente
    {
        //Propiedades
        public string Nombre { get; set; }
        public long Id { get; set;}
        public string Direccion { get; set; }
        public short Edad { get; set;}

        //Constructor con parámetros
        public Cliente(string nombre, long id, string direccion, short edad)
        {
            //this. como buena construmbre para referenciar a la Clase.
            this.Nombre = nombre;
            this.Id = id;
            this.Direccion = direccion;
            this.Edad = edad;
        }

        //sobrescribimos el obj Equals
        public override bool Equals(object? obj) //? significa que puede ser null
        {
            Cliente cliente = (Cliente)obj;
            return this.Id.Equals(cliente.Id);
        }
    }
}
