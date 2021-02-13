using System;

namespace VET06
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] nome = new string[N];
            int[] idade = new int[N];
            int maior = 0, contador = 0;

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                nome[i] = vet[0];
                idade[i] = int.Parse(vet[1]);
            }
            for (int i = 0; i < N; i++)
            {
                if (idade[i] > maior)
                {
                    maior = idade[i];
                    contador = i;
                }
            }
            Console.WriteLine("Pessoa mais velha: " + nome[contador]);

        }
    }
}
