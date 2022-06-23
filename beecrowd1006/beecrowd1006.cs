using System; 

class URI {

    static void Main(string[] args) { 

        double a, b, c, peso1, peso2,peso3, MEDIA;

        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());
        peso1 = 2.0;
        peso2 = 3.0;
        peso3 = 5.0;
        MEDIA = (a * peso1 + b * peso2 + c * peso3) / (peso1 + peso2 + peso3);
        Console.WriteLine("MEDIA = " + MEDIA.ToString("F1"));

    }

}