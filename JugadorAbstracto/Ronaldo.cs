using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JugadorAbstracto
{
    public class Ronaldo : Jugador, IJugador
    {
        public Ronaldo(int velocidad, int tiro, int regate, int defensa, int pase, int fisico) : base(velocidad, tiro, regate, defensa, pase, fisico)
        {
        }

        void IJugador.defensa()
        {
            Console.WriteLine("Cristiano Ronaldo defendio con  " + this.defensa + " de propiedad!");
        }

        void IJugador.fisico()
        {
            Console.WriteLine("Cristiano Ronaldo soporto el embate del oponente a " + this.fisico + " de propiedad!");
        }

        void IJugador.pase()
        {
            Console.WriteLine("Cristiano Ronaldo coloco un pase a " + this.pase + " de propiedad!");
        }

        void IJugador.regate()
        {
            Console.WriteLine("Cristiano Ronaldo regateó a " + this.regate + " de propiedad!");
        }

        void IJugador.tiro()
        {
            Console.WriteLine("Cristiano Ronaldo remato a " + this.tiro + " de propiedad!");
        }

        void IJugador.velocidad()
        {
            Console.WriteLine("Cristiano Ronaldo corrio a " + this.velocidad + " de propiedad!");
        }
    }
}
