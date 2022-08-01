using System;
using System.Globalization;

namespace Classes
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            Conversor.Cotação = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            Conversor.Compra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais =  " + Conversor.IOF().ToString("F2", CultureInfo.InvariantCulture));
            

        }
    }
}
