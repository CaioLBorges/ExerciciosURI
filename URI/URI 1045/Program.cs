using System;
using System.Globalization;

namespace URI_1045
{
    class Program
    {
        static void Main(string[] args)
        {
            double controle;
            string[] valores = Console.ReadLine().Split(' ');
            double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            if (A < B)
            {
                controle = B;
                B = A;
                A = controle;

                if (B < C)
                {
                    controle = C;
                    C = B;
                    B = controle;
                }
                if (A < B)
                {
                    controle = B;
                    B = A;
                    A = controle;
                }
            }
            else if (B < C)
            {
                controle = C;
                C = B;
                B = controle;

                if (A < B)
                {
                    controle = B;
                    B = A;
                    A = controle;
                }
            }

            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if (A * A == B * B + C * C)
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (A * A > B * B + C * C)
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if (A * A < B * B + C * C)
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            if (A == B && A == C)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (A == B || B == C || A == C)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }



        }
    }
}
