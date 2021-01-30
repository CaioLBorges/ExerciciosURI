using System;

namespace _1133
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            if(X > Y)
            {
                int modificadora = Y;
                Y = X;
                X = modificadora;
            }
            for(int i = (X + 1); i < Y; i++)
            {
                if(i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
