using System;

namespace VET02
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] numeros = new int[N];
            string[] vet = Console.ReadLine().Split(' ');
            for(int i = 0; i < N; i++)
            {
                numeros[i] = int.Parse(vet[i]);
            }

            int contador = 0;
            for(int i = 0; i < N; i++)
            {
                if(numeros[i] % 2 == 0)
                {
                    Console.Write(numeros[i] + " ");
                    contador++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(contador);
        }
    }
}
