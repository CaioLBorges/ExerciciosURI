using System;
using System.Globalization;
namespace _041
{
    class Program
    {
        static void Main(string[] args)
        {
            double X, Y;

            string[] vs = Console.ReadLine().Split(' ');
            X = double.Parse(vs[0], CultureInfo.InvariantCulture);
            Y = double.Parse(vs[1], CultureInfo.InvariantCulture);

            if (X == 0.0 && Y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (X == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (Y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (X > 0.0 && Y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (X > 0.0 && Y < 0.0)
            {
                Console.WriteLine("Q4");
            }
            else if (X < 0.0 && Y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else
            {
                Console.WriteLine("Q3");
            }

        }
    }
}
