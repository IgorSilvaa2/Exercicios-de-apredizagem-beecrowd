using System;
using System.Globalization;
namespace Classes
{
    class Conversor 
    {
        public static double Cotação;
        public static double Compra;
        public static double Iof = 6.0;

        public static double IOF()
        {
            return Compra * Cotação + (Compra * Cotação * Iof / 100);
        }
    }
}
