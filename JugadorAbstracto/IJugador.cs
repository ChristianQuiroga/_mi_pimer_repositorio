using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JugadorAbstracto
{
    public interface IJugador
    {
        void velocidad();
        void tiro();
        void regate();
        void defensa();
        void pase();
        void fisico();

    }
}
