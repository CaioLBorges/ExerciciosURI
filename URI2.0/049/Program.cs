using System;

namespace _049
{
    class Program
    {
        static void Main(string[] args)
        {
            string i1 = Console.ReadLine();
            string i2 = Console.ReadLine();
            string i3 = Console.ReadLine();

            if(i1 == "vertebrado")
            {
                if(i2 == "ave")
                {
                    if(i3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else
                {
                    if(i3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else
            {
                if(i2 == "inseto")
                {
                    if(i3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else
                {
                    if (i3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
            /*
            switch (i1)
            {
                case "vertebrado":
                    switch (i2)
                    {
                        case "ave":
                            switch (i3)
                            {
                                case "carnivoro":
                                    Console.WriteLine("aguia");
                                    break;
                                case "onivoro":
                                    Console.WriteLine("pombo");
                                    break;
                            }
                            break;
                        case "mamifero":
                            switch (i3)
                            {
                                case "onivoro":
                                    Console.WriteLine("homem");
                                    break;
                                case "herbivoro":
                                    Console.WriteLine("vaca");
                                    break;
                            }
                            break;
                    }
                    break;
                case "invertebrado":
                    switch (i2)
                    {
                        case "inseto":
                            switch (i3)
                            {
                                case "hematofago":
                                    Console.WriteLine("pulga");
                                    break;
                                case "herbivoro":
                                    Console.WriteLine("lagarta");
                                    break;
                            }
                            break;
                        case "anelideo":
                            switch (i3)
                            {
                                case "hematofago":
                                    Console.WriteLine("sanguessuga");
                                    break;
                                case "onivoro":
                                    Console.WriteLine("minhoca");
                                    break;
                            }
                            break;
                    }
                    break;


            }*/
        }
    }
}
