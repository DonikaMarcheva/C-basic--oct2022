using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = string.Empty;
            string destination = string.Empty;
            double spentMoney = 0.00;

            switch (season)
            {
                case "summer":
                    place = "Camp";
                    break;
                case "winter":
                    place = "Hotel";
                    break;
                default:
                    break;
            }

                    if (budget<=100)
                    {
                        if (season == "summer")
                        {
                            spentMoney = 0.3 * budget;
                        }
                        else
                        {
                            spentMoney = 0.7 * budget;
                        }
                        destination = "Bulgaria";


                    }
                    else if (budget <= 1000)
                    {
                        if (season == "summer")
                        {
                            spentMoney = 0.4 * budget;
                        }
                        else
                        {
                            spentMoney = 0.8 * budget;
                        }
                        destination = "Balkans";

                    }
                    else
                    {
                        spentMoney = 0.90 * budget;
                        destination = "Europe";
                place = "Hotel";
                    }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {spentMoney:f2}");
                   

            }
        }
    }

