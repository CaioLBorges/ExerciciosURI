using System;

namespace _1097
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int k = 0;
            for(int i = 1; i <= 9; i += 2)
            {
                for(int j = 7; j >= 5; j--)
                {
                    Console.WriteLine("I=" + i + " J=" + (j + k));
                }
                k += 2; 
            }*/
            int j = 7;
            for (int i = 1; i <= 9; i += 2)
            {
                Console.WriteLine("I=" + i + " J=" + j);
                Console.WriteLine("I=" + i + " J=" + (j - 1));
                Console.WriteLine("I=" + i + " J=" + (j - 2));
                j += 2;
            }


        }
    }
}
