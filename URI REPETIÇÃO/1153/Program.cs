using System;

namespace _1153
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int fatorial = N;

            for (int i = 1; i < N; i++)
            {
                fatorial *= i;
            }
            Console.WriteLine(fatorial);
        }
    }
}
