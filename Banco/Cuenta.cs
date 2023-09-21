using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Cuenta
    {
        //atributos

        protected string _nroCuentaEspecial;

        private int _nroCuenta;

        //public int NroCuenta { get {  return _nroCuenta; } } //seria de solo lectura
        //Propiedad Full (Property Full), es para acceder al atributo.
        public int NroCuenta
        {
            get { return _nroCuenta; }
            set { _nroCuenta = value; }
        }

        //Propiedad Autoimplementada
        public DateTime _fechaApertura { get; set; }
        public float _saldo { get; set; }
        public string _tipoInteres { get; set; }

        //?
        public  Cliente cliente { get; set; }


        //Constructor, es para Inicializarla
        public Cuenta()
        {
            this._nroCuenta = 0;
            this._saldo = 0;
            this._fechaApertura = DateTime.Now;
            this._tipoInteres = string.Empty;
        }

        //Otro constructor por parámetro
        public Cuenta(int nroCuenta, DateTime fechaApertura, float saldo, string tipoInteres)
        {
            this._nroCuenta = nroCuenta;
            this._saldo = saldo;
            this._fechaApertura = fechaApertura;
            this._tipoInteres = tipoInteres;
        }

        //Métodos
        public void Depositar(float importeDeposito)
        {
            this._saldo += importeDeposito;
        }
        public void Extraer(float importeExtracion)
        {
            this._saldo -= importeExtracion;
        }

        public float CalcularTasa(string tipoInteres)
        {
            if (tipoInteres == "Variable")
            {
                return 5;
            }
            else
            {
                return 10;
            }
        }
    }
}
