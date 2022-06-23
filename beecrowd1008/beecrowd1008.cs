using System; 

class URI {

    static void Main(string[] args) { 

        int funcionarios, horas;
        double valorporhora, calculasalario;
        funcionarios = int.Parse(Console.ReadLine());
        horas = int.Parse(Console.ReadLine());
        valorporhora = double.Parse(Console.ReadLine());

        calculasalario = valorporhora * horas;

        Console.WriteLine("NUMBER = " + funcionarios);
        Console.WriteLine("SALARY = U$ " + calculasalario.ToString("0.00"));

    }

}