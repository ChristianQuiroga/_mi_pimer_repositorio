//Console.WriteLine("Hello, World!");
Console.WriteLine("=================================");
Console.WriteLine("Mostrar Variables");
Console.WriteLine("=================================");

string nombre = "Christian";
string apellido = "Quiroga";
int dni = 93801424;
int edad = 44;
double altura = 1.84;

Console.WriteLine("Nombre Apellido: " + nombre + ' ' + apellido);
Console.WriteLine("DNI: " + dni);
Console.WriteLine("Edad: " + edad);
Console.Write("Altura: " + altura);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("=================================");
Console.WriteLine("INGRESE DOS NUMEROS POR PANTALLA");
Console.WriteLine("=================================");

//Ingresar 2 números por pantalla
int val1 = 0;
int val2 = 0;

//Console.WriteLine("Ingrese num 1: ") + Convert.ToInt32(Console.ReadLine(val1));
//Console.WriteLine("Ingrese num 1:{0}", (val1 = Convert.ToInt32(Console.ReadLine())));
Console.WriteLine("Ingrese num 1: ");
val1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese num 2:");
val2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int sum = val1 + val2;
Console.WriteLine("Suma: " + sum);


Console.WriteLine("=================================");
Console.WriteLine("CONCATENAR TEXTO");
Console.WriteLine("=================================");

Console.WriteLine("Mi nombre es : " + nombre + " El Yakuza " + apellido);
Console.ReadKey();