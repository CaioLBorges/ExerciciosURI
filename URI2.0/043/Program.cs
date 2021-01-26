using System;
using System.Globalization;
namespace _043
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, coringa;
            string[] vs = Console.ReadLine().Split(' ');
            A = double.Parse(vs[0], CultureInfo.InvariantCulture);
            B = double.Parse(vs[1], CultureInfo.InvariantCulture);
            C = double.Parse(vs[2], CultureInfo.InvariantCulture);

            if (A + B > C && C > Math.Abs(A - B))
            {
                coringa = A + B + C;
                Console.WriteLine("Perimetro = " + coringa.ToString("F1"), CultureInfo.InvariantCulture);
            }
            else
            {
                coringa = (A + B) * C / 2;
                Console.WriteLine("Area = " + coringa.ToString("F1"), CultureInfo.InvariantCulture);
            }
        }
    }
}
