using System;

namespace _1143
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            if ( N > 1 && N < 1000)
            {
                for(int i = 1; i <= N; i++)
                {
                    Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
                }
            }
        }
    }
}
