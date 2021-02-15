using System;
using System.Globalization;
namespace MAT06
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double[,] matriz = new double[N, N];
            double soma = 0.0;

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = double.Parse(vet[j], CultureInfo.InvariantCulture);
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matriz[i, j] > 0)
                    {
                        soma += matriz[i, j];
                    }
                }
            }
            Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1"), CultureInfo.InvariantCulture);
            int linha = int.Parse(Console.ReadLine());
            int coluna = int.Parse(Console.ReadLine());
            Console.Write("LINHA ESCOLHIDA: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(matriz[linha, i].ToString("F1") + " ");
            }
            Console.WriteLine(); Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(matriz[i, coluna].ToString("F1") + " ");
            }
            Console.WriteLine();
            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(matriz[i, i].ToString("F1") + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if(matriz[i,j] < 0)
                    {
                        matriz[i, j] = Math.Pow(matriz[i, j], 2.0);
                    }
                }
            }
            Console.WriteLine("MATRIZ ALTERADA:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matriz[i, j].ToString("F1") + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
