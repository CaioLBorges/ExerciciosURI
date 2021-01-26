using System;
using System.Globalization;
namespace _051
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double iR = 0.0;

            if (salario > 2000.00)
            {
                salario -= 2000.00;
                if (salario <= 1000.00)
                {
                    iR += salario * 0.08;
                }
                else if (salario <= 2500.00)
                {
                    iR = (1000.00 * 0.08) + (salario - 1000.00) * 0.18;
                }
                else
                {
                    iR = (1000.00 * 0.08) + (1500.00 * 0.18) + (salario - 2500.00) * 0.28;
                }
                Console.WriteLine("R$ " + iR.ToString("F2"), CultureInfo.InvariantCulture);
            }
            else
            {
                Console.WriteLine("Isento");
            }
        }
    }
}
