using System; 

class URI {

    static void Main(string[] args) { 

        string s = Console.ReadLine ();

            string[] vet = s.Split(' ');
            int peca1 = int.Parse (vet[0]);
            int quant1 = int.Parse (vet[1]);
            double valorund1 = double.Parse (vet[2]);

            string s2 = Console.ReadLine();

            string[] vet2 = s2.Split(' ');
            int peca2 = int.Parse(vet2[0]);
            int quant2 = int.Parse(vet2[1]);
            double valorund2 = double.Parse(vet2[2]);

            double resultado1, resultado2, resultado3;

            resultado1 = valorund1 * quant1;
            resultado2 = valorund2 * quant2;
            resultado3 = resultado1 + resultado2;

            Console.WriteLine("VALOR A PAGAR: R$ " + resultado3.ToString("F2"));

    }

}