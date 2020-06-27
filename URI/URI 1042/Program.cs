using System;

namespace URI_1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, controle;
            string[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            if (a > b)
            {
                controle = b;
                b = a;
                a = controle;

                if (b > c)
                {
                    controle = c;
                    c = b;
                    b = controle;
                }
                if (a > b)
                {
                    controle = b;
                    b = a;
                    a = controle;
                }
            }
            else if (b > c)
            {
                controle = c;
                c = b;
                b = controle;

                if (a > b)
                {
                    controle = b;
                    b = a;
                    a = controle;
                }
            }
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine();
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
