using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario Dados;
            Dados = new Funcionario();

            Console.Write("Nome: ");
            Dados.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            Dados.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            Dados.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Dados.SalarioLiquido();
            Console.WriteLine("Funcionário: " + Dados);

            Console.WriteLine();           
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Dados.AumentaSalario(porcent);

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + Dados);
            

            

        }
    }
}