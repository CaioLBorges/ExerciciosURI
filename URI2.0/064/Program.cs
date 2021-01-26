using System;
using System.Globalization;
namespace _064
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double D = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double E = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double F = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int contadora = 0; 
            double guardadora = 0.0;

            if (A > 0)
            {
                contadora += 1;
                guardadora += A;
            }
            if (B > 0)
            {
                contadora += 1;
                guardadora += B;
            }
            if (C > 0)
            {
                contadora += 1;
                guardadora += C;
            }
            if (D > 0)
            {
                contadora += 1;
                guardadora += D;
            }
            if (E > 0)
            {
                contadora += 1;
                guardadora += E;
            }
            if (F > 0)
            {
                contadora += 1;
                guardadora += F;
            }
            Console.WriteLine(contadora + " valores positivos");
            Console.WriteLine((guardadora / contadora).ToString("F1"), CultureInfo.InvariantCulture);
        }
    }
}
