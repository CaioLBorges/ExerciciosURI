using System;
using System.Globalization;

namespace URI1010
{
    class Program
    {
        static void Main(string[] args)
        {
            //Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, 
            //o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Após, calcule e mostre o valor a ser pago.

            string[] vet1 = Console.ReadLine().Split(" ");
            string[] vet2 = Console.ReadLine().Split(" ");

            int codigoPeca1 = int.Parse(vet1[0]);
            int codigoPeca2 = int.Parse(vet2[0]);
            int numPeca1 = int.Parse(vet1[1]);
            int numPeca2 = int.Parse(vet2[1]);
            double valorUnidade1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);
            double valorUnidade2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double valorPagar = (numPeca1 * valorUnidade1 + numPeca2 * valorUnidade2);

            Console.WriteLine("VALOR A PAGAR: R$ " + valorPagar.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
