using System;
using System.Globalization;

namespace uri1046
{
    class Program
    {
        static void Main(string[] args)
        {
        double Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double reajuste;

            if (Salario == 0 || Salario <= 400.00)
            {
                double Lucro = Salario * 0.15;
                reajuste = Salario + Lucro;
                

                Console.WriteLine("Novo salario: " + reajuste.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + Lucro.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 15 %");

            }
            else if (Salario == 400.01 || Salario <= 800.00)
            {
                double Lucro = Salario * 0.12;
                reajuste = Salario + Lucro;


                Console.WriteLine("Novo salario: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + Lucro.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (Salario == 800.01 || Salario <= 1200.00)
            {
                double Lucro = Salario * 0.10;
                reajuste = Salario + Lucro;


                Console.WriteLine("Novo salario: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + Lucro.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (Salario == 1200.01 || Salario <= 2000.00)
            {
                double Lucro = Salario * 0.07;
                reajuste = Salario + Lucro;


                Console.WriteLine("Novo salario: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + Lucro.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 7 %");
            }
            else
            {
                double Lucro = Salario * 0.04;
                reajuste = Salario + Lucro;


                Console.WriteLine("Novo salario: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + Lucro.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 4 %");
            }





        }
        
    }
}