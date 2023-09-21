using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JugadorAbstracto
{
    public abstract class Jugador
    {
        public int velocidad { get; set; }
        protected int tiro { get; set; }
        public int regate { get; set; }
        protected int defensa { get; set; }
        protected int pase { get; set; }
        protected int fisico { get; set; }

        public Jugador(int velocidad, int tiro, int regate, int defensa, int pase, int fisico)
        {
            this.velocidad = velocidad;
            this.tiro = tiro;
            this.regate = regate;
            this.defensa = defensa;
            this.pase = pase;
            this.fisico = fisico;
        }

    }
}
