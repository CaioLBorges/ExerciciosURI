using System;
using System.Globalization;
namespace _048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double reajuste = 0.0; 
            int percentual = 0;

            if(salario <= 400.00)
            {
                percentual = 15;
                reajuste = salario * 0.15;
            }
            else if(salario > 400.00 && salario <= 800.00)
            {
                percentual = 12;
                reajuste = salario * 0.12;
            }
            else if(salario > 800.00 && salario <= 1200.00)
            {
                percentual = 10;
                reajuste = salario * 0.10;
            }
            else if(salario > 1200.00 && salario <= 2000.00)
            {
                percentual = 7;
                reajuste = salario * 0.07;
            }
            else if(salario > 2000.00)
            {
                percentual = 4;
                reajuste = salario * 0.04;
            }
            salario += reajuste;
            Console.WriteLine("Novo salario: " + salario.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Em percentual: " + percentual + " %");
        }
    }
}
