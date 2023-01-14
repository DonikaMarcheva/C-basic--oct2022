using System;

namespace _03._Energy_Booster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit=Console.ReadLine();
            string set =Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double priceSmall;
            double priceBig;
            double finalPrice;

            // : "Watermelon", "Mango", "Pineapple" или "Raspberry"
            switch (fruit)
            {
                case "Watermelon":
                    if (set == "small")
                    {
                        priceSmall = 2 * 56;
                        finalPrice = priceSmall * quantity;
                    }
                    else
                    {
                        priceBig = 5 * 28.70;
                        finalPrice = priceBig * quantity;
                    }
                    break;

                case "Mango":
                    if (set == "small")
                    {
                        priceSmall = 2 * 36.66;
                        finalPrice = priceSmall * quantity;
                    }
                    else
                    {
                        priceBig = 5 * 19.60;
                        finalPrice = priceBig * quantity;
                    }
                    break;

                case "Pineapple":
                    if (set == "small")
                    {
                        priceSmall = 2 * 42.10;
                        finalPrice = priceSmall * quantity;
                    }
                    else
                    {
                        priceBig = 5 * 24.80;
                        finalPrice = priceBig * quantity;
                    }
                    break;

                default:
                    if (set == "small")
                    {
                        priceSmall = 2 * 20;
                        finalPrice = priceSmall * quantity;
                    }
                    else
                    {
                        priceBig = 5 * 15.20;
                        finalPrice = priceBig * quantity;
                    }
                    break;
            }
            if (finalPrice >= 400 && finalPrice <= 1000)
            {
                finalPrice = finalPrice * (1 - 0.15);
            }
            else if (finalPrice > 1000)
            {
                finalPrice = finalPrice*0.5;
            }
            Console.WriteLine($"{finalPrice:f2} lv.");



        }
    }
}
