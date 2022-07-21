using System;
using System.Globalization;

namespace Exercicios_e_treinos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Digite o nome da primeira pessoa !");
            Console.WriteLine("Nome: ");

            pessoa1.nome = Console.ReadLine();

            Console.WriteLine("Digite a idade da primeira pessoa !! ");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa !");
            Console.WriteLine("Nome: ");

            pessoa2.nome = Console.ReadLine();

            Console.WriteLine("Digite a idade da segunda pessoa !! ");
            pessoa2.idade = int.Parse(Console.ReadLine());

            if (pessoa1.idade > pessoa2.idade )
            {
                Console.WriteLine(pessoa1.nome + " é o mais velho !!");
            }
            else
            {
                Console.WriteLine(pessoa2.nome + " é o mais velho !!");
            }



        }
    }
}
