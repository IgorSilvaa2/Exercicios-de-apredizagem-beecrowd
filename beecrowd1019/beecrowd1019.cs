using System;
using System.Globalization;

namespace teste
{
    class program
    {
        static void Main(string[] args)
        {
            int N,Hora,Minutos,Segundos,Resto;

            N = int.Parse(Console.ReadLine());

            Resto = N;

            Hora = Resto / 3600;
            Resto = Resto % 3600;
            Minutos = Resto / 60;  
            Resto %= 60;

            Console.WriteLine(Hora + ":" + Minutos + ":" + Resto);
                      

        }

    }
}

