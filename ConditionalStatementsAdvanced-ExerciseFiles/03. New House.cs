using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0.0;

            //."Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
                if (flower == "Roses")
            {
                price = 5*quantity;
                if (quantity > 80)
                {
                    price -= 0.1*price;
                }
            }
                else if (flower == "Dahlias")
            {
                price = 3.80 * quantity;
                if (quantity>90)
                {
                    price -= price * 0.15;
                }
            }
                else if (flower == "Tulips")
            {
                price = 2.80 * quantity;
                if (quantity>80)
                {
                    price -= price * 0.15;
                }
            }
                else if (flower == "Narcissus")
            {
                price = 3 *quantity;
                if (quantity<120)
                {
                    price += price * 0.15;
                }
             
            }
            else
            {
                price = 2.50 *quantity;
                if (quantity<80)
                {
                    price += price * 0.20;
                }
            }
            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {(budget-price):f2} leva left.");
                    }
            else
            {
                Console.WriteLine($"Not enough money, you need {(price-budget):f2} leva more.");
            }
        }
    }
}
