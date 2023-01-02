using System;

namespace _02._Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gradus = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            string outfit = "";
            string shoes = string.Empty;

            if (time == "Morning")
            {
                //. Outfit = Sweatshirt Shoes = Sneakers
                if (gradus <=18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                //.Outfit = Shirt       Shoes = Moccasins
                else if (gradus <=24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                //.Outfit = T-Shirt     Shoes = Sandals
                else if (gradus >=25)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }

            else if (time == "Afternoon")
            {
                //. Outfit = Shirt     Shoes = Moccasins
                if (gradus <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                //. Outfit = T-Shirt   Shoes = Sandals
                else if (gradus <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                //. Outfit = Swim Suit Shoes = Barefoot
                else if (gradus >= 25)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }

            else
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }

            Console.WriteLine($"It's {gradus} degrees, get your {outfit} and {shoes}.");
        }
    }
}
