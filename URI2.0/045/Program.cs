using System;
using System.Globalization;
namespace _045
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, operador;
            string[] vs = Console.ReadLine().Split(' ');
            A = double.Parse(vs[0], CultureInfo.InvariantCulture);
            B = double.Parse(vs[1], CultureInfo.InvariantCulture);
            C = double.Parse(vs[2], CultureInfo.InvariantCulture);

            if (C > B && C > A)
            {
                operador = A;
                A = C;
                C = operador;
            }
            else if (B > A && B > C)
            {
                operador = A;
                A = B;
                B = operador;
            }
            if (C > B)
            {
                operador = B;
                B = C;
                C = operador;
            }

            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if(A == (B * B + C * C) / A)
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (A > (B * B + C * C) / A)
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if (A < (B * B + C * C) / A)
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }

            if(A == B && B == C)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if(A == B || B == C || A == C)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}
