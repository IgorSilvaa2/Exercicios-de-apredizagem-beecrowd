using System; 

class URI {

    static void Main(string[] args) { 

          string nome ;
        double salario, vendas, comissao, TOTAL;
        nome = Console.ReadLine();
        salario = double.Parse(Console.ReadLine());
        vendas = double.Parse(Console.ReadLine());
        comissao = vendas * 0.15;
        TOTAL = salario + comissao;
        Console.WriteLine("TOTAL = R$ " + TOTAL.ToString("F2"));
    }

}