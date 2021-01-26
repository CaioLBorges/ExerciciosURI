using System;

namespace _046
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vs = Console.ReadLine().Split(' ');
            int inicio = int.Parse(vs[0]);
            int fim = int.Parse(vs[1]);
            int tempo;

            if (inicio >= fim)
            {
                tempo = 24 - inicio + fim;
            }
            else
            {
                tempo = fim - inicio;
            }
            Console.WriteLine("O JOGO DUROU " + tempo + " HORA(S)");
        }
    }
}
