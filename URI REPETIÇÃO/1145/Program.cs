using System;

namespace _1145
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vs = Console.ReadLine().Split(' ');
            int X = int.Parse(vs[0]);
            int Y = int.Parse(vs[1]);

            if (X > 1 && X < 20 && Y > X && Y < 100000)
            {
                for (int i = 1; i <= Y; i++)
                {
                    for(int j = 1; j < X; j++)
                    {
                        Console.Write(i + " ");
                        i++;
                    }
                    Console.WriteLine(i);
                }
            }
        }
    }
}
