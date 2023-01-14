using System;

namespace _03._Fitness_Card
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            int age=int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double price;


            //Gym	Boxing	Yoga	Zumba	Dances	Pilates
            switch (sport)
            {
                case "Gym":
                    if (sex == "m")
                        price = 42;
                    else
                        price = 35;
                    break;
                case "Boxing":
                    if (sex == "m")
                        price = 41;
                    else
                        price = 37;
                    break;
                case "Yoga":
                    if (sex == "m")
                        price = 45;
                    else
                        price = 42;
                    break;
                case "Zumba":
                    if (sex == "m")
                        price = 34;
                    else
                        price = 31;
                    break;
                case "Dances":
                    if (sex ==" m")
                        price = 51;
                    else
                        price = 53;
                    break;
                default:
                    if (sex == "m")
                        price = 39;
                    else
                        price = 37;
                    break;
            }
            if (age <= 19)
            {
                price = price * (1 - 0.2);
            }

            if (money>=price)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${(price - money):f2} more.");
            }
        }
    }
}
