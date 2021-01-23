using System;

namespace _019
{
    class Program
    {
        static void Main(string[] args)
        {
            int segundos, minutos, horas, N, resto;

            N = int.Parse(Console.ReadLine());

            horas = N / (60 * 60);
            resto = N % (60 * 60);
            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);

        }
    }
}
