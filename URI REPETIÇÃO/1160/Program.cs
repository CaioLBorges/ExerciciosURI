using System;
namespace _1160
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            if (T >= 1 && T <= 3000)
            {
                for (int i = 1; i <= T; i++)
                {
                    string[] vs = Console.ReadLine().Split(' ');
                    int PA = int.Parse(vs[0]);
                    int PB = int.Parse(vs[1]);
                    double G1 = double.Parse(vs[2]);
                    double G2 = double.Parse(vs[3]);
                    int anos = 0;

                    while (PA <= PB)
                    {
                        PA += (int)(PA * (G1 / 100));
                        PB += (int)(PB * (G2 / 100));
                        anos += 1;
                        if (anos > 100)
                        {
                            Console.WriteLine("Mais de 1 seculo.");
                            break;
                        }
                    }
                    if (anos <= 100)
                    {
                        Console.WriteLine(anos + " anos.");
                    }
                }


            }

        }
    }
}
