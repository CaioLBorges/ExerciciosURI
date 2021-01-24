using System;

namespace _044
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            string[] vs = Console.ReadLine().Split(' ');
            A = int.Parse(vs[0]);
            B = int.Parse(vs[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }

    }
}
