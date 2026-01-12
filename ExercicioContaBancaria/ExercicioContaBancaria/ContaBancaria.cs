using System.Globalization;

namespace ExercicioContaBancaria
{
    internal class ContaBancaria
    {
        public static double TaxaSaque = 5.0;

        public int Numero {  get; private set; } 
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;

        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this (numero, titular)
        {
            Saldo = depositoInicial;

        }

       public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo = Saldo - (quantia + TaxaSaque);
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", " + 
                "Titular: " + Titular + ", " 
                + "Saldo: $  " + Saldo.ToString("f2", CultureInfo.InvariantCulture);
        }
      
    }
}
