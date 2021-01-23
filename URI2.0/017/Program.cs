using System;
using System.Globalization;
namespace _017
{
    class Program
    {
        static void Main(string[] args)
        {
            int vMedia;
            double consumo, distancia, preco, gasto, cMedio, tempo;

            Console.WriteLine("=== COMPUTADOR DE BORDO ===");
            Console.Write("TEMPO EM HORAS: ");
            tempo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("VELOCIDADE MÉDIA: ");
            vMedia = int.Parse(Console.ReadLine());
            Console.Write("CONSUMO MÉDIO DO CARRO: ");
            cMedio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("PREÇO DA GASOLINA: ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            distancia = tempo * vMedia;
            consumo = distancia / 18.0;
            gasto = consumo * preco;

            Console.WriteLine("=== GASTOS ===");
            Console.WriteLine("CONSUMO EM LITROS: " + consumo.ToString("F1"),CultureInfo.InvariantCulture);
            Console.WriteLine("GASTO TOTAL: R$ " + gasto.ToString("F2"), CultureInfo.InvariantCulture);



        }
    }
}


    
