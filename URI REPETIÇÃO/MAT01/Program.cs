using System;

namespace MAT01
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;

            string[] vet = Console.ReadLine().Split(' ');
            M = int.Parse(vet[0]);
            N = int.Parse(vet[1]);
            int[,] matriz = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = int.Parse(vet[j]);
                }
            }
            Console.WriteLine("VALORES NEGATIVOS:");
            
            for (int i =0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        Console.WriteLine(matriz[i, j]);
                    }
                }
            }
        }
    }
}
