using System;
using System.Globalization;

namespace teste
{
    class program
    {
        static void Main(string[] args)
        {
            int dias, anos, meses, resto;

            dias = int.Parse(Console.ReadLine());

            resto = dias;

            anos = resto / 365;
            Console.WriteLine(anos + " ano(s)");
            resto %= 365;


            meses = resto / 30;
            Console.WriteLine(meses + " mes(es)");
            resto %= 30;

            Console.WriteLine(resto + " dia(s)");

        }

    }
}
