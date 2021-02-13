using System;
using System.Globalization;
namespace VET07
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] nome = new string[N];
            double[] nota1 = new double[N];
            double[] nota2 = new double[N];
            double media = 0.0;

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                nome[i] = vet[0];
                nota1[i] = double.Parse(vet[1], CultureInfo.InvariantCulture);
                nota2[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Alunos aprovados:");
            for (int i = 0; i < N; i++)
            {
                media = (nota1[i] + nota2[i]) / 2.0;
                if (media >= 6.0)
                {
                    Console.WriteLine(nome[i]);
                }
            }

        }
    }
}
