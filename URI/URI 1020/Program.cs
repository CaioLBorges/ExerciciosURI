using System;

namespace URI_1020
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias
            //Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias.Nos casos de teste nunca haverá 
            //uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364.Este é apenas um exercício com objetivo de testar 
            //raciocínio matemático simples.

            int anos, meses, N, resto;

            N = int.Parse(Console.ReadLine());

            anos = N / 365;
            Console.WriteLine(anos + " ano(s)");
            resto = N % 365;

            meses = resto / 30;
            
            resto = resto % 30;
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(resto + " dia(s)");
          

           


        }
    }
} 
