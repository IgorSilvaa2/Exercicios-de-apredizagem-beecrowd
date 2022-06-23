using System;
using System.Globalization;

namespace teste
{
    class program
    {
        static void Main(string[] args)
        {

            string[] vet = Console.ReadLine().Split(' ');
            int A = int.Parse(vet[0], CultureInfo.InvariantCulture);
            int B = int.Parse(vet[1], CultureInfo.InvariantCulture);
            int resultado;

           
                if (A % B == 0 || B % A == 0)
                {
                    Console.WriteLine("Sao Multiplos");

                }
                else
                {
                    Console.WriteLine("Nao sao Multiplos");
                        }
            




        }
    }
}