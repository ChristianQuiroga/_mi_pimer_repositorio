using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    internal abstract class FiguraGeometrica
    {
        //las clases abstractas van sin Atributos solo métodos sin funcionalidades
        public abstract double Area();
        public abstract double Perimetro();
    }
}
