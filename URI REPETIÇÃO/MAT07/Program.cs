using System;

namespace MAT07
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int[,] filas = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    filas[i, j] = int.Parse(vet[j]);
                }
            }
            int girarFila = int.Parse(Console.ReadLine());
            girarFila -= 1;
            int girador = filas[girarFila, N - 1];

            for (int j = N-1; j > 0; j--)
            {
                filas[girarFila, j] = filas[girarFila, j - 1];
            }
            filas[girarFila, 0] = girador;

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(filas[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
