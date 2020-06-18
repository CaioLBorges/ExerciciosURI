using System;
using System.Globalization;

namespace URI1005
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de um aluno. 
            //A seguir, calcule a média do aluno, sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5(A soma dos pesos portanto é 11).
            //Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

            float A = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            float B = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = ((A * 3.5) + (B * 7.5)) / 11.0;

            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
