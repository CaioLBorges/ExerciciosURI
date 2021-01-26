using System;

namespace _042
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            string[] vs = Console.ReadLine().Split(' ');
            A = int.Parse(vs[0]);
            B = int.Parse(vs[1]);
            C = int.Parse(vs[2]);

            if (A <= B && A <= C)
            {
                Console.WriteLine(A);
                if (B <= C)
                {
                    Console.WriteLine(B);
                    Console.WriteLine(C);
                }
                else
                {
                    Console.WriteLine(C);
                    Console.WriteLine(B);
                }
            }
            else if (B < A && B < C)
            {
                Console.WriteLine(B);
                if (A <= C)
                {
                    Console.WriteLine(A);
                    Console.WriteLine(C);
                }
                else
                {
                    Console.WriteLine(C);
                    Console.WriteLine(A);
                }
            }
            else
            {
                Console.WriteLine(C);
                if (A < B)
                {
                    Console.WriteLine(A);
                    Console.WriteLine(B);
                }
                else
                {
                    Console.WriteLine(B);
                    Console.WriteLine(A);
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
        }
    }
}
