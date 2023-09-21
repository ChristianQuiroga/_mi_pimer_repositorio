using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    public class Circulo : I2DMedidasCalculable
    {
        double radio;
        public Circulo(double radio) 
        {
            this.radio = radio;
        }
        public double Area()
        {
            //Pi *r*r
            return Math.PI * Math.Pow(this.radio, 2);
            //Math.pi devuelve el número Pi y Math.Pow cálcula
            // la potencia del primer parámetro
        }

        public double Perimetro()
        {
            //2*PI*r;
            return 2 * Math.PI * this.radio;
        }
    }
}
