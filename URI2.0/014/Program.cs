using System;
using System.Globalization;

namespace _014
{
    class Program
    {
        static void Main(string[] args)
        {
            int km;
            double gasolina;

            km = int.Parse(Console.ReadLine());
            gasolina = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        }
    }
}
