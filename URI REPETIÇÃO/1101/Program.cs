using System;

namespace _1101
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vs = Console.ReadLine().Split(' ');
            int A = int.Parse(vs[0]);
            int B = int.Parse(vs[1]);

            while (A > 0 && B > 0)
            {
                int soma = 0;

                if (A > B)
                {
                    int organizadora = B;
                    B = A;
                    A = organizadora;
                }
                for (int i = A; i <= B; i++)
                {
                    Console.Write(i + " ");
                    soma += i;
                }
                Console.WriteLine("Sum=" + soma);
                vs = Console.ReadLine().Split(' ');
                A = int.Parse(vs[0]);
                B = int.Parse(vs[1]);
            }
        }
    }
}
