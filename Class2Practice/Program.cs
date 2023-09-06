using System.ComponentModel;

namespace Class2Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Bloque de comentario
             */

            // Linea

            #region if anidado
            /// descripcion 
            /*
            //Console.WriteLine("Hello, World!");
            int cantidadProductosVendidos;
            int cantidadProdutosDeposito = 50;
            int stock;

            Console.WriteLine("Ingrese cantidad de productos Vendidos");
            Console.WriteLine("======================================");

            cantidadProductosVendidos = Convert.ToInt32(Console.ReadLine());

            stock = cantidadProdutosDeposito - cantidadProductosVendidos;


            if (stock == 0)
            {
                Console.WriteLine("Reponer stock de productos");
                //cantidadProdutosDeposito = cantidadProdutosDeposito + 10;
                cantidadProdutosDeposito += 10;
                Console.WriteLine("Productos cargados al deposito");
            }
            else
            {
                if (stock <= 5)
                {
                    Console.WriteLine("Stock minimo, Reponer stock de productos");
                    //cantidadProdutosDeposito = cantidadProdutosDeposito + 5;
                    cantidadProdutosDeposito += 5;
                    Console.WriteLine("Productos cargados al deposito");
                    Console.WriteLine("Informar a ventas {0} productos sin vender.", stock);
                }
                else
                {
                    Console.WriteLine($"Informar a ventas {stock} productos sin vender");
                }
            }
            Console.ReadKey();
            */
            #endregion



            #region Ejemplo Universidad
            //Universidad
            /*
            string comision = string.Empty;
            int nota = 0;
            Console.WriteLine("Ingrese la comisión");
            comision = Console.ReadLine();

            switch (comision)
            {
                case "A":
                    Console.WriteLine("Turno Mañana");
                    break;
                case "B":
                    Console.WriteLine("Turno Tarde");
                    break;
                case "C":
                    Console.WriteLine("Turno Noche");
                    break;
                default:
                    Console.WriteLine("Sin turno asignados.");
                    break;
            }

            Console.WriteLine("Ingrese la Nota");
            nota = int.Parse(Console.ReadLine());

            if (nota < 4)
            {
                Console.WriteLine("Reprobo!");
            }
            else
            {
                if (nota <= 7)
                {
                    Console.WriteLine("Aprobo la cursada!");
                }
                else
                {
                    Console.WriteLine("Promociono!");
                }
            }

            Console.ReadKey();
            */
            #endregion


            #region Validar Acceso
            const int mi_pass = 12345678;
            const char categoria = 'A';
            
            int getpass;
            string descrip;

            Console.WriteLine("VALIDAR DATOS DE ACCESOS");
            Console.WriteLine("========================");

            Console.WriteLine("Get your Password!");
            getpass = int.Parse(Console.ReadLine());

            switch (categoria)
            {
                case 'A':
                    descrip = "Es Administrador!";
                    break;
                case 'U':
                    descrip = "Es Usuario";
                    break;
                default:
                    descrip = "Sin Perfil";
                    break;

            }

            if (getpass == mi_pass)
            {
                Console.WriteLine($"Datos correctos, Bien venido!, prefil {descrip}");
            }
            else
            {
                Console.WriteLine("Datos incorrectos!, vuelva a ingresar la contraseña!");
                Console.WriteLine("Get your Password, again!");
                getpass = int.Parse(Console.ReadLine());

                if (getpass == mi_pass)
                {
                    Console.WriteLine($"Datos correctos, Bien venido!, prefil {descrip}");
                }
                else
                {
                    Console.WriteLine("Datos incorrectos! reinciar el sistema!");
                }
            }

            Console.ReadKey();
            #endregion
        }
    }
}