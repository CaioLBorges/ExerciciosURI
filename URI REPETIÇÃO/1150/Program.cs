using System;

namespace _1150
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            while(z <= x)
            {
                z = int.Parse(Console.ReadLine());
            }
            int contador = 1, soma = x;

           while(soma <= z)
            {
                soma += x + contador;
                contador ++;

            }
            Console.WriteLine(contador);
        }
    }
}
