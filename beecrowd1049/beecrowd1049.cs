using System;
using System.Globalization;


namespace aula
{
    class program
    {
        static void Main(string[] args)
        {
          
            string B, C, D;

            B = Console.ReadLine();

            if (B == "vertebrado" || B == "invertebrado")
            {
                C = Console.ReadLine();

                if (C == "ave" || C == "mamifero" || C == "inseto" || C == "anelideo")
                {
                    D = Console.ReadLine();

                    if (C == "ave" && D == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (C == "ave" && D == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                    else if (C == "mamifero" && D == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (C == "mamifero" && D == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                    else if (C == "inseto" && D == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (C == "inseto" && D == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                    else if (C == "anelideo" && D == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (C == "anelideo" && D == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }

                }

            }
            
        }
    }
}
