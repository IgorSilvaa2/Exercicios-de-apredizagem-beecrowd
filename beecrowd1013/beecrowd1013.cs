using System;
using System.Globalization;

namespace teste
{
    class program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int abs;
            
            string [] vet  = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);  

            abs = (a + b + Math.Abs(a - b)) / 2;

            if (abs > c)
            {
                Console.WriteLine(abs + " eh o maior");
            }
            else
            {
                Console.WriteLine(c + " eh o maior");
            }

        }
    }
}