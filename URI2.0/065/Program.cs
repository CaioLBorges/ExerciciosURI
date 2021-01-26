using System;

namespace _065
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            int E = int.Parse(Console.ReadLine());
            int contadora = 0;

            if ((A % 2) == 0)
            {
                contadora += 1;
            }
            if ((B % 2) == 0)
            {
                contadora += 1;
            }
            if ((C % 2) == 0)
            {
                contadora += 1;
            }
            if ((D % 2) == 0)
            {
                contadora += 1;
            }
            if ((E % 2) == 0)
            {
                contadora += 1;
            }
            Console.WriteLine(contadora + " valores pares");
        }
    }
}
