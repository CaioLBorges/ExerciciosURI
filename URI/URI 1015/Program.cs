using System;
using System.Globalization;

namespace URI_1015
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1, y1) e p2(x2, y2) 
            //e calcule a distância entre eles, mostrando 4 casas decimais após a vírgula, segundo a fórmula:

            double x1, x2, y1, y2, distancia;

            string[] vet = Console.ReadLine().Split(' ');
            x1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            x2 = double.Parse(vet2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(vet2[1], CultureInfo.InvariantCulture);

            distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
