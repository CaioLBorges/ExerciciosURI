using System;
using System.Globalization;

namespace URI_1043
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, area, perimetro;
            string[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            if (a < (b + c) && a > Math.Abs(b - c) && b < (a + c) && b > Math.Abs(a - c) && c < (a + b) && c > Math.Abs(a - b))
            {
                perimetro = a + b + c;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                area = ((a + b) * c) / 2;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
