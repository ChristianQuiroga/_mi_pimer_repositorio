namespace EjerciciosClaseAfter_Unidad1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            /*Realizar un programa que pida ingresar por el teclado un número entero, y que indique si el número es positivo, 0  o negativo. 
            */

            //int num1 = 0;

            //Console.WriteLine($"Ingres número: ");
            //num1 = int.Parse(Console.ReadLine());
            //if (num1 > 0)
            //{
            //    Console.WriteLine("Positivo!");
            //}
            //else Console.WriteLine("Negativo!");
            //Console.ReadKey();
            #endregion

            #region 2
            //2)	Crear un programa que pida tres números e indique cual es el menor y cual es el mayor
            int num1 = 0, num2 = 0, num3 = 0;
            int menor = 0;

            Console.WriteLine("Número 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            menor = num1;

            Console.WriteLine("Número 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 < menor) 
            {
                menor = num2;
            }

            Console.WriteLine("Número 3");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num3 <  menor)
            {
                menor = num3;
            }


            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"El Mayor es {num1}");
            }
            else
            {
                if (num2 > num1 && num2 > num3)
                    Console.WriteLine($"El Mayor es {num2}");
                else
                    Console.WriteLine($"El mayor es {num3}");
            }

            Console.WriteLine($"El Menor es {menor}");
            Console.ReadKey();


            #endregion

            #region 3
            //3)	Crear un programa que pida ingresar un numero e indique si es par o impar
            //Console.WriteLine("ingresar un numero e indique si es par o impar");
            //float numParImpar = 0.00f;
            //Console.WriteLine("Ingrese un Número: ");
            //numParImpar = Convert.ToSingle(Console.ReadLine());
            //if ((numParImpar % 2) == 0)
            //{
            //    Console.WriteLine("ES NUMERO PAR =>" + numParImpar);
            //}
            //else
            //{
            //    Console.WriteLine("ES NUMERO IMPAR =>" + numParImpar);
            //}

            #endregion

            #region 4
            //4)	Realizar el ejercicio que muestre el nombre del cliente y la cantidad de artículos comprados, si la cantidad es menor de 30 pagara en efectivo,
            //si es mayor de 30 y menor de 60 pagara con tarjeta,  si es mayor de 60 pagara con cheque.

            //Console.WriteLine("Realizar el ejercicio que muestre el nombre del cliente y la cantidad de artículos comprados, si la cantidad es menor de 30 pagara en efectivo,\r\n" +
            //    "si es mayor de 30 y menor de 60 pagara con tarjeta,  si es mayor de 60 pagara con cheque.");
            //Console.WriteLine("=================================================================================================");
            //Console.WriteLine();

            //String nombreCli = String.Empty;
            //int cantArticulosComprados = 0;

            //Console.WriteLine("Ingrese Razon Social: ");
            //nombreCli = Console.ReadLine();
            //Console.WriteLine("Ingrese Unidades cantidad de Comprada: ");
            //cantArticulosComprados = Convert.ToInt32(Console.ReadLine());

            //if (cantArticulosComprados <= 30 ) 
            //{
            //    Console.WriteLine($"El Cliente: {nombreCli} \r\n Se Abono en Efectivo! de acuerdo a la cantidad comprada: {cantArticulosComprados}");
            //}
            //else
            //{
            //    if (cantArticulosComprados > 30 && cantArticulosComprados <= 60 )
            //    {
            //        Console.WriteLine($"El Cliente: {nombreCli} \r\n Se Abono con Tarjeta Crédito! de acuerdo a la cantidad comprada: {cantArticulosComprados}");
            //    }

            //    Console.WriteLine($"El Cliente: {nombreCli} \r\n Se Abono con CHEQUE! de acuerdo a la cantidad comprada: {cantArticulosComprados}");
            //}

            //Console.ReadKey();  

            #endregion

            #region 5
            //Console.WriteLine("Ingresar dos valores numéricos y mostrar su suma, resta, multiplicación y división. Si la multiplicación es mayor e igual que 20 restarle el resultado de la resta de los 2 valores, \r\n " +
            //    "caso contrario a la multiplicación añadirle su suma, mostrar el resultado.");
            //Console.WriteLine("=================================================================================================");
            //Console.WriteLine();

            //int val1 = 0, val2 = 0;
            //int suma = 0, resta = 0, multi = 0, division = 0 ;

            //Console.WriteLine("Ingrese los 2 valores int: ");
            //val1 = int.Parse(Console.ReadLine());
            //val2 = int.Parse(Console.ReadLine());
            //suma = val1 + val2;
            //resta = val1 - val2;
            //multi = val1 * val2;
            //division = val1 / val2;

            //Console.WriteLine($"La suma es: {suma}");
            //Console.WriteLine($"La resta es: {resta}");
            //Console.WriteLine($"La multiplicación es: {val1 * val2}");
            //Console.WriteLine($"La división es: {val1 / val2}");

            //if (multi >= 20)
            //{
            //    Console.WriteLine("Al valor multiplicación restarle la resta: " + (multi - resta));
            //}
            //else {
            //    Console.WriteLine("Al valor multiplicación añadirle la suma: " + (multi + suma));
            //        };

            //Console.ReadKey();
            #endregion

            #region 6
            //Console.WriteLine("Crear un programa donde se cargue la edad de una persona, en caso de tener 18 años o mas indicar que es mayor de edad.");
            //Console.WriteLine("=========================================================================================================================");
            //Console.WriteLine();

            //int edad = 0;
            //String esMayorEdad = string.Empty;

            //Console.WriteLine("Ingrese edad: ");
            //edad = Convert.ToInt32(Console.ReadLine());

            //if (edad >=18) 
            //{
            //    Console.WriteLine($"Es mayor de edad tiene: {edad} ");
            //}
            //else Console.WriteLine($"Es menor de edad tiene: {edad} ");
            //Console.ReadKey();

            #endregion

            #region 7
            //Console.WriteLine("Crear un programa donde se ingrese la nota de un alumno y en caso que sea mayor o igual a 7 indicar Aprobo y caso contrario Reprobo.");
            //Console.WriteLine("=========================================================================================================================");
            //Console.WriteLine();

            //float notaAlumno = 0.00f;
            //Console.WriteLine("Ingrese nota de Alumno: ");
            //notaAlumno = Convert.ToSingle(Console.ReadLine());

            //if (notaAlumno >= 7)
            //{
            //    Console.WriteLine($"Aprobado! ");

            //}
            //else Console.WriteLine("Reprobado!");


            //Console.ReadKey();

            #endregion

            #region 8
            //Console.WriteLine("Crear un programa donde se ingrese el estado civil, indicando C para casado, S para soltero, " +
            //    "D para divorciado y cualquier otro valor indica Sin Especificar, mostrar la descripcion del estado civil segun el valor indicado por el usuario.");
            //Console.WriteLine("=========================================================================================================================");
            //Console.WriteLine();

            //char estadoCivil;

            //Console.WriteLine("INGRESE ESTADO CIVIL [S/C/D]:");
            ////estadoCivil = char.Parse(Console.ReadLine());
            ////estadoCivil =  Convert.ToChar(Console.ReadLine().ToLower());
            //estadoCivil = Console.ReadKey(true).KeyChar;

            //switch (Convert.ToString(estadoCivil).ToLower())
            //{
            //    case "s":
            //        Console.WriteLine("Es Soltero!");
            //        break;
            //    case "c":
            //        Console.WriteLine("Es Casado!");
            //        break;
            //    case "d":
            //        Console.WriteLine("Es Divorciado!");
            //        break;
            //    default:
            //        Console.WriteLine("Sin especificar!");
            //        break;
            //}

            #endregion

            #region 9
            Console.WriteLine("Ingresar el precio de un producto y en caso de que sea mayor a 1000 hacer un descuento del 10%, si supera los 10000 hacer " +
                "un descuento del 15% y en caso que sea inferior a 1000 no aplicar descuento, en todos los casos mostrar por pantalla el monto de descuento " +
                "aplicado y el total a pagar.");
            Console.WriteLine("=========================================================================================================================");
            Console.WriteLine();

            float precioProducto = 0f;
            Console.WriteLine("Ingrese precio del Producto: ");
            precioProducto = Convert.ToSingle(Console.ReadLine());
            //precioProducto = Convert.ToInt32(Console.ReadLine());

            switch (precioProducto)
            {
                case (< 1000):
                    Console.WriteLine($"No aplica Descuento! \n\r {precioProducto}" );
                    break;
                case (<= 10000):
                    Console.WriteLine($"El precio del producto es mayor a 1000, se te aplicara un Descuento del 10%.\n\r {(precioProducto- (precioProducto * 10)/100)}");
                    break;
                case (>10000):
                    Console.WriteLine($"El precio del producto es mayor a 10000, se te aplicara un Descuento del 15%.\n\r {(precioProducto * 0.15) - precioProducto}");
                    break;

            }


            #endregion
        }
    }
}