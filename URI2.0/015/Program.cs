using System;
using System.Globalization;
namespace _015
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, distancia;

            string[] vet1 = Console.ReadLine().Split(' ');
            string[] vet2 = Console.ReadLine().Split(' ');
            x1 = double.Parse(vet1[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(vet1[1], CultureInfo.InvariantCulture);
            x2 = double.Parse(vet2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(vet2[1], CultureInfo.InvariantCulture);

            distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine(distancia.ToString("F4"), CultureInfo.InvariantCulture);
        }
    }
}
