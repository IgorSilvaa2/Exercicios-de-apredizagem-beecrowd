using System; 

class URI {

    static void Main(string[] args) { 

        double a, b, peso1, peso2, MEDIA;
        
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        peso1 =  3.5;
        peso2 = 7.5;
        MEDIA = (a * peso1 + b * peso2) / (peso1 + peso2);
        Console.WriteLine("MEDIA = " + MEDIA.ToString("F5"));

    }

}