using System;
using System.Globalization;
namespace _1156
{
    class Program
    {
        static void Main(string[] args)
        {
            double S = 1.0;
            int pow = 1;
            for(int i = 3; i <= 39; i+=2)
            {         
                S +=  i/ Math.Pow(2.0, pow);
                pow += 1;
            }
            Console.WriteLine(S.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
