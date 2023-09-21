using JugadorAbstracto;

namespace JugadorAbstracto
{
    public class ImplementarJugador
    {
        static void Main(string[] args)
        {
            Messi messi = new Messi(70, 89, 95, 15, 90, 50);
            Console.WriteLine("");
            Ronaldo ronaldo = new Ronaldo(88, 98, 89, 20, 90, 78);

            messi.velocidad();
            

            

        }
    }
}