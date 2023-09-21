
using ClaseAbstracta;
//Interfaces
Cubo cubo = new(1);
Rectangulo rectangulo = new(2, 2);
Circulo circulo = new(2);

Console.WriteLine("Volumen Cubo " + cubo.Volumen()+
    "\nPerímetro rectangulo: " + rectangulo.Perimetro() +
    "\nArea Circulo: " + circulo.Area());
