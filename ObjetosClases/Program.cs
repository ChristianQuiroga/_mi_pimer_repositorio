using ObjetosClases;
using System.Runtime.CompilerServices;

char confirma;

Usuario testUsuario = new Usuario();
Usuario testUsuarioParam = new Usuario("Chris", "Quiroga", 93801424, "chris.quiroga12@gmail.com", 44, "Chiclana 4598");



Console.WriteLine("Mostrar datos del Usuario cargado por Defecto");
Console.WriteLine("***********************************************");

Console.WriteLine("Nombre: " + testUsuario.Nombre);
Console.WriteLine("Apellido: " + testUsuario.Apellido);
Console.WriteLine("DNI: " + testUsuario.Dni);
Console.WriteLine("e-mail: " + testUsuario.Email);
Console.WriteLine("Edad: " + testUsuario.Edad);
Console.WriteLine("Domicilio: " + testUsuario.Domicilio);
Console.WriteLine();

Console.WriteLine("Mostrar datos del Usuario cargado por Párametro");
Console.WriteLine("***********************************************");

//Mostrar datos
//for (int i = 0; i < 6; i++)
//{
//    Console.WriteLine("Nombre: " + testUsuario.i);
//}
Console.WriteLine("Nombre: " + testUsuarioParam.Nombre);
Console.WriteLine("Apellido: " + testUsuarioParam.Apellido);
Console.WriteLine("DNI: " + testUsuarioParam.Dni);
Console.WriteLine("e-mail: " + testUsuarioParam.Email);
Console.WriteLine("Edad: " + testUsuarioParam.Edad);
Console.WriteLine("Domicilio: " + testUsuarioParam.Domicilio);
Console.WriteLine();

if (testUsuarioParam.EsMayorEdad())
{
    Console.WriteLine($"Es mayor de edad tiene {testUsuarioParam.Edad}");
    Console.WriteLine($"Es mayor de edad tiene {testUsuario.Edad}");
}

Console.WriteLine($"Cambiar la direción {testUsuarioParam.Domicilio}");

testUsuarioParam.Domicilio = Console.ReadLine();
Console.WriteLine($"La nueva dirección es : {testUsuarioParam.Domicilio}");

//Generar un usuario Nuevo
Console.WriteLine("Agregar un usuario nuevo: [s/n]");
confirma = Convert.ToChar(Console.ReadLine().ToUpper());
if (confirma == 'S')
{
    Usuario newUsuario = new Usuario();
    Console.WriteLine("Nombre: ");
    newUsuario.Nombre = Console.ReadLine();
    Console.WriteLine("Apellido: ");
    newUsuario.Apellido = Console.ReadLine();
    Console.WriteLine("DNI: ");
    newUsuario.Dni = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("e-mail: ");
    newUsuario.Email = Console.ReadLine();
    Console.WriteLine("Edad: ");
    newUsuario.Edad = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Domicilio: ");
    newUsuario.Domicilio = Console.ReadLine();
    
    Console.WriteLine();
    newUsuario.MostrarDatos();
}






