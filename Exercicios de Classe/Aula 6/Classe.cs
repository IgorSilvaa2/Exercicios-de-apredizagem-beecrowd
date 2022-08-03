using System;
using System.Globalization;

namespace Exercicios
{
    class Banco
    {
        public static int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        

        public Banco(int conta, string titular)
        {
            Conta = conta;
            Titular = titular;
            Saldo = 0.0;
        }


        public Banco(int conta, string titular, double saldo) : this (conta, titular)
        {
            Saldo = saldo;
        }

        public double Deposito(double valor)
        {
            return Saldo += valor;
        }

        public double Saque(double valor)
        {
            return Saldo = (Saldo - valor) - 5.0;
        }

        public override string ToString()
        {
            return "Conta " + Conta + "," + " Titular: " + Titular + "," + " Saldo: $ " + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
