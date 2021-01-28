using System;
using System.Globalization;
namespace _1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;
            double totalIdade = 0.0, dividendo = 0;

            while(idade >= 0)
            {
                idade = int.Parse(Console.ReadLine());
                if(idade > 0)
                {
                    dividendo += +1.0;
                    totalIdade += idade;
                }
            }
            Console.WriteLine((totalIdade / dividendo).ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
