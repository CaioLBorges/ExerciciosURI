using System;
using System.Globalization;
namespace _021
{
    class Program
    {
        static void Main(string[] args)
        {
            double N;
            int nota, quociente, resto, moeda;

            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("NOTAS:");

            resto = (int)N;
            nota = 100;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto %= nota;

            nota = 50;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto %= nota;

            nota = 20;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto %= nota;

            nota = 10;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto %= nota;

            nota = 5;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto %= nota;

            nota = 2;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto %= nota;

            Console.WriteLine("MOEDAS:");

            nota = 1;
            quociente = resto / nota;
            Console.WriteLine(quociente + " moeda(s) de R$ " + nota + ".00");
            int n = (int)N;
            resto = (int)(N *100 + 0.05) - n*100;

            moeda = 50;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.50");
            resto %= moeda;

            moeda = 25;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.25");
            resto %= moeda;

            moeda = 10;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.10");
            resto %= moeda;

            moeda = 5;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.05");
            resto %= moeda;

            Console.WriteLine(resto + " moeda(s) de R$ 0.01");
        }
    }
}
