using System;

namespace _035
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;
            string[] valor = Console.ReadLine().Split(' ');
            A = int.Parse(valor[0]);
            B = int.Parse(valor[1]);
            C = int.Parse(valor[2]);
            D = int.Parse(valor[3]);

            if(B > C && D > A && C + D > A + B && C > 0 && D > 0 && A%2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
