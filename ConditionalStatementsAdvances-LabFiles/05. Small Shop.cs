using System;
using System.Xml.Schema;

namespace _05._Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();   
            double quantity =double.Parse(Console.ReadLine());
            

            if (town == "Sofia")

     //. coffee-0.50, water-0.80, beer-1.20, sweets-1.45, peanuts-1.60
            {
                if (product == "coffee")
                {
                    double totalPrice = 0.5 * quantity;
                    Console.WriteLine(totalPrice);
                }
                else if (product == "water")
                {
                    double totalPrice = 0.8*quantity;
                    Console.WriteLine(totalPrice);
                }
                else if (product=="beer")
                {
                    double totalPrice = 1.2*quantity;
                    Console.WriteLine(totalPrice);
                }
                else if (product=="sweets")
                {
                    double totalPrice = 1.45 * quantity;
                    Console.WriteLine(totalPrice);
                }
                else
                {
                    double totalPrice = 1.6*quantity;
                    Console.WriteLine(totalPrice);
                }
                

            }

            else if (town == "Plovdiv")

    //. coffee-0.40, water-0.70, beer-1.15, sweets-1.30, peanuts-1.50
            {
                if (product == "coffee")
                {
                    double totalPrice = 0.4 * quantity;
                    Console.WriteLine(totalPrice);
                }
                else if (product == "water")
                {
                    double totalPrice = 0.7 * quantity;
                    Console.WriteLine(totalPrice);
                }
                else if (product == "beer")
                {
                    double totalPrice = 1.15 * quantity;
                    Console.WriteLine(totalPrice);
                }
                else if (product == "sweets")
                {
                    double totalPrice = 1.30 * quantity;
                    Console.WriteLine(totalPrice);
                }
                else
                {
                    double totalPrice = 1.5 * quantity;
                    Console.WriteLine(totalPrice);
                }

            }

            else
   //. coffee-0.45, water-0.70, beer-1.10, sweets-1.35, peanuts-1.55
            {
                if (product == "coffee")
                {
                    double totalPrice = 0.45 * quantity;
                    Console.WriteLine(totalPrice);
                }
                else if (product == "water")
                {
                    double totalPrice = 0.7 * quantity;
                    Console.WriteLine(totalPrice);
                }
                else if (product == "beer")
                {
                    double totalPrice = 1.1 * quantity;
                    Console.WriteLine(totalPrice);
                }
                else if (product == "sweets")
                {
                    double totalPrice = 1.35 * quantity;
                    Console.WriteLine(totalPrice);
                }
                else
                {
                    double totalPrice = 1.55 * quantity;
                    Console.WriteLine(totalPrice);
                }

            }
            
        }
       
    }
}
