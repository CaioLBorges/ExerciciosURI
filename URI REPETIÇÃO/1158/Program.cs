using System;

namespace _1158
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                string[] vs = Console.ReadLine().Split(' ');
                int x = int.Parse(vs[0]);
                int y = int.Parse(vs[1]);
                int soma = 0;

                if (x % 2 == 0)
                {
                    x++;
                }
                for(int j = 0; j < y * 2; j += 2)
                {
                    soma += x + j;
                }
                Console.WriteLine(soma);
            }
        }
    }
}
