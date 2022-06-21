using System;
using System.Globalization;

namespace vamos
{
    class Program
    {
        static void Main (string[] args)
        {
        string [] vet = Console.ReadLine().Split(' ');

            double N1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double N2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double N3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            double N4 = double.Parse(vet[3], CultureInfo.InvariantCulture);

            double peso1, peso2, peso3, peso4;

            peso1 = 2.0 * N1;
            peso2 = 3.0 * N2;
            peso3 = 4.0 * N3;
            peso4 = 1.0 * N4;

            double Media = (peso1 + peso2 + peso3 + peso4) / 4;

            Console.WriteLine("Media: " + Media);

        }
        
    }
}