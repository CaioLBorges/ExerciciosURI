using System;
using System.Globalization;
namespace _066
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
            int contP = 0, contI = 0, contPositivo = 0, contNegativo = 0;

            if (A > 0)
            {
                contPositivo += 1;
            }
            else if(A != 0)
            {
                contNegativo += 1;
            }
            if (A % 2 == 0)
            {
                contP += 1;
            }
            else
            {
                contI += 1;
            }
            if (B > 0)
            {
                contPositivo += 1;
            }
            else if(B != 0)
            {
                contNegativo += 1;
            }
            if (B % 2 == 0)
            {
                contP += 1;
            }
            else
            {
                contI += 1;
            }
            if (C > 0)
            {
                contPositivo += 1;
            }
            else if(C != 0)
            {
                contNegativo += 1;
            }
            if (C % 2 == 0)
            {
                contP += 1;
            }
            else
            {
                contI += 1;
            }
            if (D > 0)
            {
                contPositivo += 1;
            }
            else if(D != 0)
            {
                contNegativo += 1;
            }
            if (D % 2 == 0)
            {
                contP += 1;
            }
            else
            {
                contI += 1;
            }
            if (E > 0)
            {
                contPositivo += 1;
            }
            else if(E != 0)
            {
                contNegativo += 1;
            }
            if (E % 2 == 0)
            {
                contP += 1;
            }
            else
            {
                contI += 1;
            }
            Console.WriteLine(contP + " valor(es) par(es)");
            Console.WriteLine(contI + " valor(es) impar(es)");
            Console.WriteLine(contPositivo + " valor(es) positivo(s)");
            Console.WriteLine(contNegativo + " valor(es) negativo(s)");
        }
    }
}
