using System;

namespace _047
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] vs = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(vs[0]);
            int minInicial = int.Parse(vs[1]);
            int horaFinal = int.Parse(vs[2]);
            int minFinal = int.Parse(vs[3]);

            int minInicialTotal = horaInicial * 60 + minInicial;
            int minFinalTotal = horaFinal * 60 + minFinal;
            int tempoTotal;

            if (minFinalTotal > minInicialTotal)
            {
                tempoTotal = minFinalTotal - minInicialTotal;

            }
            else
            {
                tempoTotal = (24 * 60 - minInicialTotal) + minFinalTotal;
            }
            int duracaoHoras = tempoTotal / 60;
            int duracaoMinutos = tempoTotal % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");
        }
    }
}
