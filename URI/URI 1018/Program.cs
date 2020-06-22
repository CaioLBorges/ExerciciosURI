﻿using System;

namespace URI_1018
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis(cédulas) no qual o valor pode ser decomposto.
            //As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1.A seguir mostre o valor lido e a relação de notas necessárias.

            int N, nota100, nota50, nota20, nota10, nota5, nota2, nota1;
            
            N = int.Parse(Console.ReadLine());

            nota100 = N / 100;
            nota50 = (N % 100) / 50;
            nota20 = (N % 100) % 50 / 20;
            nota10 = (((N % 100) % 50) % 20) / 10;
            nota5 = ((((N % 100) % 50) % 20) % 10) / 5;
            nota2 = (((((N % 100) % 50) % 20) % 10) % 5) / 2;
            nota1 = ((((((N % 100) % 50) % 20) % 10) % 5) % 2);

            Console.WriteLine(N);
            Console.WriteLine(nota100 + " nota(s) de R$ 100,00");
            Console.WriteLine(nota50 + " nota(s) de R$ 50,00");
            Console.WriteLine(nota20 + " nota(s) de R$ 20,00");
            Console.WriteLine(nota10 + " nota(s) de R$ 10,00");
            Console.WriteLine(nota5 + " nota(s) de R$ 5,00");
            Console.WriteLine(nota2 + " nota(s) de R$ 2,00");
            Console.WriteLine(nota1 + " nota(s) de R$ 1,00");

        }
    }
}
