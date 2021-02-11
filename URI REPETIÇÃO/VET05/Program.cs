using System;
using System.Globalization;
namespace VET05
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] numeros = new int[N];
            double media = 0.0, contador = 0.0;

            string[] vet = Console.ReadLine().Split(' ');
            for(int i = 0; i < N; i++)
            {
                numeros[i] = int.Parse(vet[i]);
            }
            for(int i = 0; i < N; i++)
            {
                if(numeros[i] % 2 == 0)
                {
                    media += numeros[i];
                    contador++;
                }
            }
            media /= contador;
            Console.WriteLine(media.ToString("F1"), CultureInfo.InvariantCulture);
        }
    }
}
