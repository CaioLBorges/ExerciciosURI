using System;

namespace _013
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, MaiorAB, Maior;
            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            MaiorAB = (A + B + Math.Abs(A - B)) / 2;
            Maior = (MaiorAB + C + Math.Abs(MaiorAB - C)) / 2;

            Console.WriteLine(Maior + " eh o maior");
        }
    }
}
