// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Actividad Clase 4, Venta de productos de tienda");
Console.WriteLine("================================================");

#region variables
const String repetir = "FIN";
String codPro = String.Empty;
int unidadVendidas = 0;
string nombrePro = String.Empty;
int montototal = 0;
bool confimar = false;
#endregion 

//cod
while (!codPro.Equals(repetir))
{
    Console.WriteLine("Ingrese codigo de Venta: ");
    codPro = Console.ReadLine().ToUpper();

    if (codPro != repetir)
    {
        Console.WriteLine("Ingrese Cantidad Venta: ");
        unidadVendidas = Convert.ToInt32(Console.ReadLine());

        montototal = montototal + f_calcularVenta(codPro, unidadVendidas);
    }

}

Console.WriteLine("Usted ingreso FIN, desea Confirmar compra o Cancelar [TRUE/FALSE]");
confimar = Convert.ToBoolean(Console.ReadLine());
f_confirmar(confimar);



#region Funciones
int f_calcularVenta(string codigo, int cantidadVenta)
{
    int totalUni = 0;
    switch (codigo)
    {
        case "DES":
            nombrePro = "Desodorante";
            totalUni = totalUni + (cantidadVenta * 200);
            break;
        case "JP":
            nombrePro = "Javon en Polvo";
            totalUni = totalUni + (cantidadVenta * 300);
            break;
        case "DET":
            nombrePro = "Detergente";
            totalUni = totalUni + (cantidadVenta * 250);
            break;
    }
    return totalUni;
}

void f_confirmar(bool confirmar)
{
    if (confirmar == true )
    {
        Console.Clear();
        Console.WriteLine("******************************************");
        Console.WriteLine("El Monto total a abonar es: " + montototal);
        Console.WriteLine("******************************************");
    }
else
    {
        Console.WriteLine("Se Cancelo la compra! GRACIAS");

    }

}

#endregion