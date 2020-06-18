using System;
using System.Net.Http.Headers;

namespace URI1004
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia dois valores inteiros. A seguir, calcule o produto entre estes dois valores e atribua esta operação à variável PROD.
            //A seguir mostre a variável PROD com mensagem correspondente.

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int PROD = A * B;

            Console.WriteLine("PROD = " + PROD);
        }
    }
}
