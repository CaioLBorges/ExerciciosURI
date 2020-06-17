using System;
using System.Globalization;

namespace URI1002
{
    class Program
    {
        static void Main(string[] args)
        {
            //A fórmula para calcular a área de uma circunferência é: area = π.raio2.Considerando para este problema que π = 3.14159:
            //-Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π.

            double area, raio;
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = 3.14159 * Math.Pow(raio, 2);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
