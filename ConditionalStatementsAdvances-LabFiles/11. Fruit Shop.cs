using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
      //. banana / apple / orange / grapefruit / kiwi / pineapple / grapes
           
            string dayOfWeek = Console.ReadLine();
     //.Monday / Tuesday / Wednesday / Thursday / Friday / Saturday / Sunday

            double quantity = double.Parse(Console.ReadLine());
            
            switch (dayOfWeek)
            {
                case ("Monday"):
                case ("Tuesday"):
                case ("Wednesday"):
                case ("Thursday"):
                case ("Friday"):
                    if (fruit == "banana")
                    {
                        double price = 2.5 * quantity;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (fruit == "apple")
                    {
                        double price = 1.2 * quantity;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (fruit == "orange")
                    {
                        double price = 0.85 * quantity;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (fruit == "grapefruit")
                    {
                        double price = 1.45 * quantity;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (fruit == "kiwi")
                    {
                        double price = 2.70 * quantity;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (fruit == "pineapple")
                    {
                        double price = 5.50 * quantity;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (fruit == "grapes")
                    {
                        double price = 3.85 * quantity;
                        Console.WriteLine($"{price:f2}");
                    }
                    else
                        Console.WriteLine("error");
                    break;

                case ("Saturday"):
                case ("Sunday"):
                    if (fruit == "banana")
                    {
                        double price = 2.7 * quantity;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (fruit == "apple")
                    {
                        double price = 1.25 * quantity;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (fruit == "orange")
                    {
                        double price = 0.90 * quantity;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (fruit == "grapefruit")
                    {
                        double price = 1.60 * quantity;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (fruit == "kiwi")
                    {
                        double price = 3.0 * quantity;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (fruit == "pineapple")
                    {
                        double price = 5.60 * quantity;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (fruit == "grapes")
                    {
                        double price = 4.20 * quantity;
                        Console.WriteLine($"{price:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                    default:
                    Console.WriteLine("error");
                    break;



            }

        }
    }
}
