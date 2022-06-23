using System;
using System.Globalization;

namespace teste
{
    class program
    {
        static void Main(string[] args)
        {
            int tempo, velocidade;
            double litro;

            tempo = int.Parse(Console.ReadLine());
            velocidade = int.Parse(Console.ReadLine());

            litro = velocidade * tempo / 12.0;

            Console.WriteLine(litro.ToString("F3", CultureInfo.InvariantCulture));
            
        }


    }
}
