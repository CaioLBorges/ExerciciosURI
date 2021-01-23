using System;
using System.Globalization;

namespace _014
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y, media;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = X / Y;

            Console.WriteLine(media.ToString("F3") + " km/l", CultureInfo.InvariantCulture );
        }
    }
}
