using System;

namespace _1059
{
    class Program
    {
        static void Main(string[] args)
        {
            int par = 0;
            for(int i = 1; par < 100; i++)
            {
                par += 2;
                Console.WriteLine(par);
            }
            
        }
    }
}
