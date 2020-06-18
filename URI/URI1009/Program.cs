using System;
using System.Globalization;

namespace URI1009
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês(em dinheiro).
            //Sabendo que este vendedor ganha 15 % de comissão sobre suas vendas efetuadas, informar o total a receber no final do mês, 
            //com duas casas decimais.

            string nomeVendedor = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salarioTotal = salarioFixo + (0.15 * totalVendas);

            Console.WriteLine("TOTAL = R$ " + salarioTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
