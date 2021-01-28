using System;

namespace _1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int fim = 1, grenal = 0, vitInter = 0, vitGremio = 0, empate = 0;

            while (fim == 1)
            {
                string[] vs = Console.ReadLine().Split(' ');
                int golInter = int.Parse(vs[0]);
                int golGremio = int.Parse(vs[1]);
                grenal += 1;

                if (golInter > golGremio)
                {
                    vitInter += 1;
                }
                else if (golGremio > golInter)
                {
                    vitGremio += 1;
                }
                else
                {
                    empate += 1;
                }
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                fim = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(grenal + " grenais");
            Console.WriteLine("Inter:" + vitInter);
            Console.WriteLine("Gremio:" + vitGremio);
            Console.WriteLine("Empates:" + empate);

            if (vitGremio > vitInter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            if (vitGremio < vitInter)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}
