using System;

namespace URI_3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            /*estrutura básica para comando enquanto, onde não se sabe quantidade de vezes que irá repetir, teste feito antes de executar comando*/
            int x, soma = 0;

            x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                soma += x;
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("A SOMA É: " + soma);
        }
    }
}
