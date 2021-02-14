using System;

namespace MAT05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int M = int.Parse(vet[0]);
            int N = int.Parse(vet[1]);
            int[,] A = new int[M, N];
            int[,] B = new int[M, N];
            int[,] SOMA = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(vet[j]);
                }
            }
            for (int i = 0; i < M; i++)
            {
                vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    B[i, j] = int.Parse(vet[j]);
                }
            }
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    SOMA[i, j] = A[i, j] + B[i, j];
                }
            }
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(SOMA[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
