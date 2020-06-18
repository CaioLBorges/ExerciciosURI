﻿using System;
using System.Globalization;
using System.Threading;

namespace URI1013
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida(em Km) 
            //e o total de combustível gasto(em litros).

            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double consumo = X / Y;

            Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

        }
    }
}
