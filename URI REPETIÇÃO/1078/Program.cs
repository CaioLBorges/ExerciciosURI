using System;

namespace _1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            if(N > 2 && N < 1000)
            {
                for(int i = 1; i <=10; i++)
                {
                    Console.WriteLine(i + " x " + N + " = " + i * N);
                }
            } 
        }
    }
}
