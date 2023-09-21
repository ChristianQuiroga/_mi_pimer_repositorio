namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float tasa= 0;

            Cuenta cta1 = new Cuenta();
            //Cuenta cta2 = new Cuenta(0001,DateTime(2023,10,14),500000,"Cta Pesos");
            Console.WriteLine("Cuenta Inicializada");
            Console.WriteLine("Nro Cuenta " + cta1.NroCuenta + Environment.NewLine
                                + "Fecha de Apertura " + cta1._fechaApertura + Environment.NewLine
                                + "Saldo " + cta1._saldo + Environment.NewLine
                                + "Tipo de Interes " + cta1._tipoInteres);
            cta1.NroCuenta = 1;
            cta1._fechaApertura = new DateTime(2023, 10, 14);
            cta1._saldo = 10000.00f;
            cta1._tipoInteres = "Variable";
            
            Console.WriteLine("");

            Console.WriteLine("Cuenta Modificada");
            Console.WriteLine("Nro Cuenta " + cta1.NroCuenta + Environment.NewLine
                                + "Fecha de Apertura " + cta1._fechaApertura + Environment.NewLine
                                + "Saldo " + cta1._saldo + Environment.NewLine
                                + "Tipo de Interes " + cta1._tipoInteres);
            
            Console.WriteLine("");

            Cuenta myCuenta = new Cuenta(2, new DateTime(2023, 10, 15),500000,"Fija");
            Console.WriteLine("Cuenta Nueva 2");
            Console.WriteLine("Nro Cuenta " + myCuenta.NroCuenta + Environment.NewLine
                                + "Fecha de Apertura " + myCuenta._fechaApertura + Environment.NewLine
                                + "Saldo " + myCuenta._saldo + Environment.NewLine
                                + "Tipo de Interes " + myCuenta._tipoInteres);

            myCuenta.Depositar(5000);
            Console.WriteLine("Su saldo es  " + myCuenta._saldo);

            myCuenta.Extraer(500000);
            Console.WriteLine("Su saldo es  " + myCuenta._saldo);

            tasa = myCuenta.CalcularTasa(myCuenta._tipoInteres);
            Console.WriteLine("La tasa es del " + tasa + "%");

            //Implementamos la Herencia
            Console.WriteLine("");
            CajaAhorro cajaAhorro = new CajaAhorro();
            cajaAhorro._saldo = 50000;
            cajaAhorro.NroCuenta = 2;
            cajaAhorro._fechaApertura = new DateTime(2023, 5, 5);
            cajaAhorro._tipoInteres = "Variable";
            cajaAhorro.NroCuentaEspecial = "1234";

            Console.WriteLine("Nro Cuenta " + cajaAhorro.NroCuenta + Environment.NewLine
                                + "Fecha de Apertura " + cajaAhorro._fechaApertura + Environment.NewLine
                                + "Saldo " + cajaAhorro._saldo + Environment.NewLine
                                + "Tipo de Interes " + cajaAhorro._tipoInteres + Environment.NewLine
                                + "Nro Cuenta Especial " + cajaAhorro.NroCuentaEspecial);



            Console.WriteLine("");
            CuentaCorriente ctacte = new CuentaCorriente();
            ctacte._saldo = 50000;
            ctacte.NroCuenta = 2;
            ctacte._fechaApertura = new DateTime(2023, 5, 5);
            ctacte._tipoInteres = "Variable";
            ctacte.NroCuentaEspecial = "1234";

            Console.WriteLine("Nro Cuenta " + ctacte.NroCuenta + Environment.NewLine
                                + "Fecha de Apertura " + ctacte._fechaApertura + Environment.NewLine
                                + "Saldo " + ctacte._saldo + Environment.NewLine
                                + "Tipo de Interes " + ctacte._tipoInteres + Environment.NewLine
                                + "Nro Cuenta Especial " + ctacte.NroCuentaEspecial);
        }
    }
}