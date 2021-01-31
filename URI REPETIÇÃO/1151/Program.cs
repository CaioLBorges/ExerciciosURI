using System;

namespace _1151
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int A = 0, B = 1;

            for (int i = 0; i < N; i++)
            {
                if(i == N - 1)
                {
                    Console.WriteLine(A);
                }
                else
                {
                    Console.Write(A + " ");
                }
                int aux = B;
                B = A;
                A = aux + B;
            }
        }
    }
}
