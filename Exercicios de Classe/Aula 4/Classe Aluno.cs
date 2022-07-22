using System;
using System.Globalization;

namespace Exercicios
{
    class Aluno
    {
        public string NomeDoAluno;
        public double Nota1, Nota2, Nota3, NotaTotal;


        public double NotaFinal()
        {
            return NotaTotal = Nota1 + Nota2 + Nota3;
        }

        public void Aprovacao()
        {
            if (NotaFinal() >= 60.0)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");

                NotaTotal = 60.0 - NotaTotal;
                Console.WriteLine("FALTARAM " + NotaTotal.ToString("F2", CultureInfo.InvariantCulture)
                  + " PONTOS");

            }

        }


    }
}
