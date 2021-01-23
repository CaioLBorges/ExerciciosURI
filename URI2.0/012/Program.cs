using System;
using System.Globalization;
namespace _012
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, tri, cir, tra, qua, ret;

            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            tri = (A * C) / 2.0;
            cir = 3.14159 * Math.Pow(C, 2);
            tra = ((A + B) * C) / 2.0;
            qua = Math.Pow(B, 2.0);
            ret = A * B;

            Console.WriteLine("TRIANGULO: " + tri.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("CIRCULO: " + cir.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("TRAPEZIO: " + tra.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("QUADRADO: " + qua.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("RETANGULO: " + ret.ToString("F3"), CultureInfo.InvariantCulture);

        }
    }
}
