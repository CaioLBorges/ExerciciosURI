using System;

namespace _061
{
    class Program
    {
        static void Main(string[] args)
        {
            int W, X, Y, Z, diaI, diaF, sI, sF, sT, resto;

            string[] vetI = Console.ReadLine().Split(' ');
            diaI = int.Parse(vetI[1]);
            vetI = Console.ReadLine().Split(' ');
            sI = (diaI - 1) * 24 * 60 * 60 + int.Parse(vetI[0]) * 60 * 60 + int.Parse(vetI[2]) * 60 + int.Parse(vetI[4]);

            vetI = Console.ReadLine().Split(' ');
            diaF = int.Parse(vetI[1]);
            vetI = Console.ReadLine().Split(' ');
            sF = (diaF - 1) * 24 * 60 * 60 + int.Parse(vetI[0]) * 60 * 60 + int.Parse(vetI[2]) * 60 + int.Parse(vetI[4]);

            sT = sF - sI;

            W = sT / (24 * 60 * 60);
            resto = sT % (24 * 60 * 60);
            X = resto / (60 * 60);
            resto = resto % (60 * 60);
            Y = resto / 60;
            Z = resto % 60;

            Console.WriteLine(W + " dia(s)");
            Console.WriteLine(X + " horas(s)");
            Console.WriteLine(Y + " minutos(s)");
            Console.WriteLine(Z + " segundo(s)");
        }
    }
}