using System;

namespace _1149
{
    class Program
    {
        static void Main(string[] args)
        {

            int A = 0, N = 0, i, soma;

            string[] valores = Console.ReadLine().Split(' ');
            A = int.Parse(valores[0]);


            i = 1;
            while (N <= 0)
            {
                valores = Console.ReadLine().Split(' ');

                N = int.Parse(valores[i]);
                i = i + 1;

            }

            soma = 0;
            for (i = 0; i < N; i++)
            {
                soma = soma + A + i;
            }

            Console.WriteLine(soma);

        }
    }
}
