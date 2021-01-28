using System;
using System.Globalization;
namespace _1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int quantia = 0, rato = 0, sapo = 0, coelho = 0, total = 0;
            char tipo;
            double pR, pS, pC;

            for(int i = 1; i <= N; i++)
            {
                string[] vs = Console.ReadLine().Split(' ');
                quantia = int.Parse(vs[0]);
                tipo = char.Parse(vs[1]);
                total += quantia;

                switch (tipo)
                {
                    case 'R':
                        rato += quantia;
                        break;
                    case 'S':
                        sapo += quantia;
                        break;
                    case 'C':
                        coelho += quantia;
                        break;
                }
            }
            pR = rato * 100.00 / total;
            pS = sapo * 100.00 / total;
            pC = coelho * 100.00 / total;

            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelho);
            Console.WriteLine("Total de ratos: " + rato);
            Console.WriteLine("Total de sapos: " + sapo);
            Console.WriteLine("Percentual de coelhos: " + pC.ToString("F2")+ " %", CultureInfo.InvariantCulture);
            Console.WriteLine("Percentual de ratos: " + pR.ToString("F2")+ " %", CultureInfo.InvariantCulture );
            Console.WriteLine("Percentual de sapos: " + pS.ToString("F2")+ " %", CultureInfo.InvariantCulture);
        }
    }
}
