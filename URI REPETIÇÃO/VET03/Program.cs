using System;

namespace VET03
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            int[] B = new int[N];
            int[] C = new int[N];

            string[] vet1 = Console.ReadLine().Split(' ');
            string[] vet2 = Console.ReadLine().Split(' ');

            for(int i = 0; i < N; i++)
            {
                A[i] = int.Parse(vet1[i]);
                B[i] = int.Parse(vet2[i]);

            }
            for(int i = 0; i < N; i++)
            {
                C[i] = A[i] + B[i];
                Console.Write(C[i] + " ");
            }

        }
    }
}
