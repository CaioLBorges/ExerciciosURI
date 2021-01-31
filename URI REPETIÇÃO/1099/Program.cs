using System;

namespace _1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                string[] vs = Console.ReadLine().Split(' ');
                int A = int.Parse(vs[0]);
                int B = int.Parse(vs[1]);
                int soma = 0;
                if(A > B)
                {
                    int organizadora = B;
                    B = A;
                    A = organizadora;
                }
                for(int j = A + 1; j < B; j++)
                {
                    if (j % 2 != 0)
                    {
                        soma += j;
                    }
                }
                Console.WriteLine(soma);
            }
        }
    }
}
