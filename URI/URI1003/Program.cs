using System;

namespace URI1003
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia dois valores inteiros, no caso para variáveis A e B. A seguir, calcule a soma entre elas e atribua à variável SOMA.
            //A seguir escrever o valor desta variável.

            int A, B, SOMA;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            SOMA = A + B;

            Console.WriteLine("SOMA = " + SOMA);
        }
    }
}
