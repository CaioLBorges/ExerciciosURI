using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia = int.Parse(Console.ReadLine());
            string D;

            switch(dia){
                case 1:
                    D = "Segunda";
                    break;
                case 2:
                    D = "Terça";
                    break;
                case 3:
                    D = "Quarta";
                    break;
                case 4:
                    D = "Quinta";
                    break;
                case 5:
                    D = "Sexta";
                    break;
                case 6:
                    D = "Sábado";
                    break;
                case 7:
                    D = "Domingo";
                    break;

                default:
                    D = "Valor inválido!";
                    break;
            }
            Console.WriteLine(D);
           
        }
    }
}
