using System;
using System.Globalization;

namespace URI_1021
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. 
            A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto.
            As notas consideradas são de 100, 50, 20, 10, 5, 2.As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01.
            A seguir mostre a relação de notas necessárias.*/


            double N, moeda, restoMoeda;
            int quociente, nota, resto;

            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            resto = (int) N;
            restoMoeda = N - resto;

            Console.WriteLine("NOTAS:");

            nota = 100;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % nota;

            nota = 50;
            quociente = resto / nota;
                Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % nota;

            nota = 20;
            quociente = resto / nota;
                Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % nota;

            nota = 10;
            quociente = resto / nota;
                Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % nota;

            nota = 5;
            quociente = resto / nota;
                Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % nota;

            nota = 2;
            quociente = resto / nota;
                Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % nota;

            Console.WriteLine("MOEDAS:");

            nota = 1;
            quociente = resto / nota;
            Console.WriteLine(quociente + " moeda(s) de R$ 1.00");
            resto = resto % nota;

            moeda = 0.50;
            quociente = (int)(restoMoeda / moeda);
                Console.WriteLine(quociente + " moeda(s) de R$ 0.50");
            restoMoeda = restoMoeda % moeda;

            moeda = 0.25;
            quociente = (int)(restoMoeda / moeda);
                Console.WriteLine(quociente + " moeda(s) de R$ 0.25");
            restoMoeda = restoMoeda % moeda;

            moeda = 0.10;
            quociente = (int)(restoMoeda / moeda);
                Console.WriteLine(quociente + " moeda(s) de R$ 0.10");
            restoMoeda = restoMoeda % moeda;

            moeda = 0.05;
            quociente = (int)(restoMoeda / moeda);
                Console.WriteLine(quociente + " moeda(s) de R$ 0.05");
            restoMoeda = restoMoeda % moeda;

            moeda = 0.01;
            quociente = (int)(restoMoeda / moeda);
                Console.WriteLine(quociente + " moeda(s) de R$ 0.01");
            restoMoeda = restoMoeda % moeda;

          

        }
    }
}
