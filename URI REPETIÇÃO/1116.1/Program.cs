using System;
using System.Globalization;
namespace _1116._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                string[] vs = Console.ReadLine().Split(' ');
                int A = int.Parse(vs[0]);
                int B = int.Parse(vs[1]);

                if (B == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double divisao = (double) A / B;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
