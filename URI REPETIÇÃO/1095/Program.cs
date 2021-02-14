using System;

namespace _1095
{
    class Program
    {
        static void Main(string[] args)
        {
            int I = 1, J = 60;

            while(J >= 0)
            {
                Console.WriteLine("I=" + I + " J=" + J);
                I += 3;
                J -= 5;
            }
        }
    }
}
