using System;

namespace _1115
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vs = Console.ReadLine().Split(' ');
            int x = int.Parse(vs[0]);
            int y = int.Parse(vs[1]);

            while(x != 0 && y != 0)
            {
                if (x > 0)
                {
                    if(y > 0)
                    {
                        Console.WriteLine("primeiro");
                    }
                    else
                    {
                        Console.WriteLine("quarto");
                    }
                }
                else
                {
                    if (y > 0)
                    {
                        Console.WriteLine("segundo");
                    }
                    else
                    {
                        Console.WriteLine("terceiro");
                    }
                }
                vs = Console.ReadLine().Split(' ');
                x = int.Parse(vs[0]);
                y = int.Parse(vs[1]);

            }
        }
    }
}
