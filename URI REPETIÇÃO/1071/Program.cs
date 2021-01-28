using System;

namespace _1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int soma = 0;
            if (X > Y)
            {
                int cont = X;
                X = Y;
                Y = cont;
            }
            for(int i = X + 1; i < Y; i++)
            {
                if(i % 2 != 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}
