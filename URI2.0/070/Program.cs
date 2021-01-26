using System;

namespace _070
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());

            if(X % 2 == 0)
            {
                X += 1;
            }
            Console.WriteLine(X);
            Console.WriteLine(X + 2);
            Console.WriteLine(X + 4);
            Console.WriteLine(X + 6);
            Console.WriteLine(X + 8);
            Console.WriteLine(X + 10);

        }
    }
}
