using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno Dados;

            Dados = new Aluno();

            Console.Write("Nome do aluno: ");
            Dados.NomeDoAluno = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            Dados.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Dados.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Dados.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Dados.NotaFinal();
            Console.WriteLine("NOTA FINAL = " + Dados.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            Dados.Aprovacao();

            

        }
    }
}