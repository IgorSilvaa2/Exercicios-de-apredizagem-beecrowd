using System;
using System.Globalization;

namespace Exercicios

{
    class Program
    {

        static void Main(string[] args)
        {
            Banco Conta;


            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char pergunta = char.Parse(Console.ReadLine());

            if (pergunta == 's' || pergunta == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Conta = new Banco(conta, nome, saldo);



            }
            else
            {
                Conta = new Banco(conta, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(Conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double depositoObrigatorio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Conta.Deposito(depositoObrigatorio);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(Conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saqueObrigatorio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Conta.Saque(saqueObrigatorio);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(Conta);


        }
    }
}
