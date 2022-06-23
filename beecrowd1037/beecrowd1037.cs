using System;
using System.Globalization;

namespace teste
{
    class program
    {
        static void Main(string[] args)
        {

            double Numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (Numero < 0.0 || Numero > 100.0 )
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (Numero <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (Numero <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (Numero <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else  
            {
                Console.WriteLine("Intervalo (75,100]");
            }


        }

    }
}
