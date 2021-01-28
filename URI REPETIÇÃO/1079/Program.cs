using System;
using System.Globalization;
namespace _1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for(int i = 1; i <= N; i++)
            {
                string[] vs = Console.ReadLine().Split(' ');
                double A = double.Parse(vs[0], CultureInfo.InvariantCulture);
                double B = double.Parse(vs[1], CultureInfo.InvariantCulture);
                double C = double.Parse(vs[2], CultureInfo.InvariantCulture);

                double media = (A * 2 + B * 3 + C * 5) / 10.0;

                Console.WriteLine(media.ToString("F1"), CultureInfo.InvariantCulture);
            }
        }
    }
}
