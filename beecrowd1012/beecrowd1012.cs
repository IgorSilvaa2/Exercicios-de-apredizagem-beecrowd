using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] vet;
            double TRIANGULO, CIRCULO, TRAPEZIO, QUADRADO, RETANGULO;

            vet = Console.ReadLine().Split(' ');

            double A = double.Parse(vet[0]);
            double B = double.Parse(vet[1]);
            double C = double.Parse(vet[2]);

            TRIANGULO = A * C / 2;
            CIRCULO = 3.14159 * Math.Pow(C, 2);
            TRAPEZIO = (A + B) * C / 2;
            QUADRADO = (B * B);
            RETANGULO = (A * B);

            Console.WriteLine("TRIANGULO: " + TRIANGULO.ToString("F3"));
            Console.WriteLine("CIRCULO: " + CIRCULO.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + TRAPEZIO.ToString("F3"));
            Console.WriteLine("QUADRADO: " + QUADRADO.ToString("F3"));
            Console.WriteLine("RETANGULO: " + RETANGULO.ToString("F3"));





        }


    }
}

