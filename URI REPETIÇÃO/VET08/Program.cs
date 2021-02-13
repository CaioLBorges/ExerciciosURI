using System;
using System.Globalization;
namespace VET08
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double[] altura = new double[N];
            char[] sexo = new char[N];
            double maior = 0.0, media = 0.0, mulheres = 0.0;
            int homens = 0;

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(vet[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(vet[1]);
            }

            double menor = altura[0];
            for (int i = 0; i < N; i++)
            {
                if (altura[i] > maior)
                {
                    maior = altura[i];
                }
                if (altura[i] < menor)
                {
                    menor = altura[i];
                }
                if (sexo[i] == 'F')
                {
                    media += altura[i];
                    mulheres++;
                }
                else
                {
                    homens++;
                }
            }
            media /= mulheres;

            Console.WriteLine("Menor altura = " + menor.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Maior altura = " + maior.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Media das alturas das  mulheres = " + media.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Numero de homens = " + homens);

        }
    }
}
