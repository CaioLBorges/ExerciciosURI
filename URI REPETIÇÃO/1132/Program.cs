using System;

namespace _1132
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
                int mudadora = Y;
                Y = X;
                X = mudadora;
            }
            for(int i = X; i <= Y; i++)
            {
                if(i % 13 != 0)
                {
                    soma += i; 
                }
            }
            Console.WriteLine(soma);
        }
    }
}
