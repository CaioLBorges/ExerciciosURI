using System;

namespace _1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if(x == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if(x % 2 == 0)
                {
                    Console.Write("EVEN ");
                }
                else
                {
                    Console.Write("ODD ");
                }
                if(x > 0)
                {
                    Console.WriteLine("POSITIVE");
                }
                else if(x < 0)
                {
                    Console.WriteLine("NEGATIVE");
                }
            }
        }
    }
}
