using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {

            double raio, pi = 3.14159;
            double volume;

            raio = double.Parse(Console.ReadLine());
            volume = (4.0 / 3) * pi * Math.Pow(raio, 3);
            Console.WriteLine("VOLUME = " + volume.ToString("F3"));



        }


    }
}

