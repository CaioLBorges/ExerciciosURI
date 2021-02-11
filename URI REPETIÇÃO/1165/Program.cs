using System;

namespace _1165
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                int X = int.Parse(Console.ReadLine());

                if (X == 2 || X == 3 || X == 5 || X == 7)
                {
                    Console.WriteLine(X + " eh primo");
                }
                else if (X % 2 != 0 && X % 3 != 0 && X % 5 != 0 && X % 7 != 0 && X != 1)
                {
                    Console.WriteLine(X + " eh primo");
                }
                else
                {
                    Console.WriteLine(X + " nao eh primo");
                }

            }*/

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {

                int x = int.Parse(Console.ReadLine());
                int metade = x / 2;

                bool primo = true;

                for (int j = 2; j <= metade; j++)
                {
                    if (x % j == 0)
                    {
                        primo = false;
                        break;
                    }
                }

                if (primo)
                {
                    Console.WriteLine(x + " eh primo");
                }
                else
                {
                    Console.WriteLine(x + " nao eh primo");
                }
            }
        }
    }
}

