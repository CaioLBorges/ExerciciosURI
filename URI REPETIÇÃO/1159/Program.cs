using System;

namespace _1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            while (x != 0)
            {
                if (x % 2 != 0)
                {
                    x += 1;
                }
                Console.WriteLine(5 * x + 20);
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}
