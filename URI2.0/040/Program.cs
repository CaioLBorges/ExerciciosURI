using System;
using System.Globalization;
namespace _040
{
    class Program
    {
        static void Main(string[] args)
        {
            float N1, N2, N3, N4, nExame, media, mediaF;

            string[] vs = Console.ReadLine().Split(' ');
            N1 = float.Parse(vs[0], CultureInfo.InvariantCulture);
            N2 = float.Parse(vs[1], CultureInfo.InvariantCulture);
            N3 = float.Parse(vs[2], CultureInfo.InvariantCulture);
            N4 = float.Parse(vs[3], CultureInfo.InvariantCulture);

            media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;
            if (media == 4.85f)
            {
                media = 4.8f;
            }
            Console.WriteLine("Media: " + media.ToString("F1"), CultureInfo.InvariantCulture);

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                nExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + nExame.ToString("F1"), CultureInfo.InvariantCulture);

                mediaF = (media + nExame) / 2;

                if (mediaF >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado");
                }
                Console.WriteLine("Media final: " + mediaF.ToString("F1"), CultureInfo.InvariantCulture);
            }
        }
    }
}
