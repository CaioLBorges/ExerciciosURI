using System;
using System.Globalization;

namespace _060
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            double D = double.Parse(Console.ReadLine());
            double E = double.Parse(Console.ReadLine());
            double F = double.Parse(Console.ReadLine());

            int contadora = 0;
            if (A > 0)
            {
                contadora += 1;
            }
            if (B > 0)
            {
                contadora += 1;
            }
            if (C > 0)
            {
                contadora += 1;
            }
            if (D > 0)
            {
                contadora += 1;
            }
            if (E > 0)
            {
                contadora += 1;
            }
            if (F > 0)
            {
                contadora += 1;
            }
            Console.WriteLine(contadora + " valores positivos");
        }
    }
}
