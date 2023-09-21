using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JugadorAbstracto
{
    public class Messi : Jugador, IJugador

    {
        public Messi(int velocidad, int tiro, int regate, int defensa, int pase, int fisico) : base(velocidad, tiro, regate, defensa, pase, fisico)
        {
        }

        void IJugador.defensa()
        {
            Console.WriteLine("Lionel Messi defendio con  " + this.defensa + " de propiedad!");
        }

        void IJugador.fisico()
        {
            Console.WriteLine("Lionel Messi soporto el embate del oponente a " + this.fisico + " de propiedad!");
        }

        void IJugador.pase()
        {
            Console.WriteLine("Lionel Messi coloco un pase a " + this.pase + " de propiedad!");
        }

        void IJugador.regate()
        {
            Console.WriteLine("Lionel Messi regateó a " + this.regate + " de propiedad!");
        }

        void IJugador.tiro()
        {
            Console.WriteLine("Lionel Messi remato a " + this.tiro + " de propiedad!");
        }

        void IJugador.velocidad()
        {
            Console.WriteLine("Lionel Messi corrio a " + this.velocidad + " de propiedad!");
        }
    }
}
