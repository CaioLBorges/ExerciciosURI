using System;

namespace _1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int leitor = 0, alcool = 0, gasolina = 0, disel = 0;

            while (leitor != 4)
            {
                leitor = int.Parse(Console.ReadLine());

                if (leitor == 1)
                {
                    alcool += 1;
                }
                else if (leitor == 2)
                {
                    gasolina += 1;
                }
                else if (leitor == 3)
                {
                    disel += 1;
                }
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + disel);
        }
    }
}
