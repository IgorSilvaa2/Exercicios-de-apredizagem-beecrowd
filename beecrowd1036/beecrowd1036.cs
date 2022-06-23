using System;
using System.Globalization;

namespace teste {
    class program {
        static void Main(string[] args) {
            // 10.0 3.0 5.0

            string[] vet = Console.ReadLine().Split(' ');

            double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double Delta = Math.Pow(B, 2) - 4 * A *C;
            double Bahskara1 = (-B + Math.Sqrt(Delta)) / (2 * A);
            double Bahskara2 = (-B - Math.Sqrt(Delta)) / (2 * A);

            if (Delta < 0 || 2 * A == 0  )
            {
                Console.WriteLine("Impossivel calcular");

            }
            else
            {
                Console.WriteLine("R1 = " + Bahskara1.ToString("F5",CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + Bahskara2.ToString("F5", CultureInfo.InvariantCulture));
            }

        }

    }
}
