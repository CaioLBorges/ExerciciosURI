using System;
using System.Globalization;

namespace URI_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double pagar;
            string[] vet = Console.ReadLine().Split(' ');

            codigo = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);
            pagar = 0.0;

            switch (codigo)
            {
                case 1:
                    pagar = quantidade * 4.00;
                    break;

                case 2:
                    pagar = quantidade * 4.50;
                    break;

                case 3:
                    pagar = quantidade * 5.00;
                    break;

                case 4:
                    pagar = quantidade * 2.00;
                    break;

                case 5:
                    pagar = quantidade * 1.50;
                    break;
            }

            Console.WriteLine("Total: R$ " + pagar.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
