using System;
using System.Globalization;

namespace Exercicios_e_treinos
{
    class Program
    {
        static void Main(string[ ] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            int posicao;
            double maior;
            double[ ] vetdouble;

            vetdouble = new double[N];


            string[ ] vet = Console.ReadLine( ).Split(' ');

            //Atribui os valores do vetor string para o vetor double.
            for (int i = 0; i < N; i++)
            {
                vetdouble[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
            }

            //Variantes para guardar o maior valor e a posição.
            maior = vetdouble[0];
            posicao = 0;

            //Encontra o maior valor 
            for (int i = 0; i < N; i++)
            {                             
                if (vetdouble [i] > maior)
                {
                    maior = vetdouble[i];
                    posicao = i;
                                       
                }
                

            }
            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);



        }
    }
}
