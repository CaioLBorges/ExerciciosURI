﻿using System;
using System.Globalization;
namespace VET04
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double[] notas = new double[N];

            string[] vet = Console.ReadLine().Split(' ');

            double media = 0.0;
            for(int i = 0; i < N; i++)
            {
                notas[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
                media += notas[i];
            }
            media /= N;
            Console.WriteLine(media.ToString("F3"), CultureInfo.InvariantCulture);

            for(int i = 0; i < N; i++)
            {
                if(notas[i] < media)
                {
                    Console.WriteLine(notas[i]);
                }
            }

        }
    }
}
