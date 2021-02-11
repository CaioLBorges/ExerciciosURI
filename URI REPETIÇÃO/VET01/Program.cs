using System;
using System.Globalization;
namespace VET01
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double[] num = new double[N];
            string[] vet = Console.ReadLine().Split(' ');
            for(int i = 0; i < N; i++)
            {
                num[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
            }
            double maior = num[0];
            int contador = 0;

            for (int i = 0; i < N; i++)
            {
                if(num[i] > maior)
                {
                    maior = num[i];
                    contador = i;
                }
 
            }
            Console.WriteLine(maior.ToString("F1"), CultureInfo.InvariantCulture);
            Console.WriteLine(contador);
        }
    }
}
