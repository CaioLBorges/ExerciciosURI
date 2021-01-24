using System;
using System.Globalization;
namespace _038
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double valorCod, valorTotal;

            string[] vs = Console.ReadLine().Split(' ');
            codigo = int.Parse(vs[0]);
            quantidade = int.Parse(vs[1]);
            valorCod = 0;

            switch (codigo)
            {
                case 1:
                    valorCod = 4.00;
                    break;
                case 2:
                    valorCod = 4.50;
                    break;
                case 3:
                    valorCod = 5.00;
                    break;
                case 4:
                    valorCod = 2.00;
                    break;
                case 5:
                    valorCod = 1.00;
                    break;
            }
            valorTotal = valorCod * quantidade;

            Console.WriteLine("Total: R$ " + valorTotal.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
