using System;
using System.Globalization;

namespace Exercicios
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentaSalario (double porcentagem)
        {
             SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0) ;
        }

        public override string ToString()
        {
            return Nome + ", R$" + SalarioLiquido().ToString("F3",CultureInfo.InvariantCulture);
        }

    }
}
