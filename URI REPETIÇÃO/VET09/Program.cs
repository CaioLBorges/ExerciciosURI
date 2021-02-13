using System;
using System.Globalization;
namespace VET09
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] produto = new string[N];
            double[] precoCompra = new double[N];
            double[] precoVenda = new double[N];
            double totalCompra = 0.0, totalVenda = 0.0, lucro = 0.0, lucroTotal = 0.0;
            int menos10 = 0, mais20 = 0, entre10E20 = 0;

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                produto[i] = vet[0];
                precoCompra[i] = double.Parse(vet[1], CultureInfo.InvariantCulture);
                precoVenda[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);
            }
            for (int i = 0; i < N; i++)
            {
                totalCompra += precoCompra[i];
                totalVenda += precoVenda[i];
                lucro = 100.0 * (precoVenda[i] - precoCompra[i]) / precoCompra[i];
                if (lucro < 10)
                {
                    menos10++;
                }
                else if (lucro > 20)
                {
                    mais20++;
                }
                else
                {
                    entre10E20++;
                }
            }
            lucroTotal = totalVenda - totalCompra;
            Console.WriteLine("Lucro abaixo de 10%: " + menos10);
            Console.WriteLine("Lucro entre 10% e 20%: " + entre10E20);
            Console.WriteLine("Lucro acima de 20%: " + mais20);
            Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor total de venda: " + totalVenda.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Lucro total: " + lucroTotal.ToString("F2"), CultureInfo.InvariantCulture);


        }
    }
}
