using System;

namespace URI_1019
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, 
            //e informe - o expresso no formato horas:minutos: segundos.
            // 1hora = 60min = 3600segundos

            int N, horas, minutos, segundos;

            N = int.Parse(Console.ReadLine());

            horas = N / 3600;
            minutos = (N % 3600) / 60;
            segundos = (N % 3600) % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}
