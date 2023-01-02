using System;
using System.Diagnostics.CodeAnalysis;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceStudio = 0.0;
            double priceAp = 0.0;

            switch (month)
            {
                case "May":
                case "October":
                    priceStudio = 50;
                    priceAp = 65;
                    break;
                case "June":
                case "September":
                    priceStudio = 75.20;
                    priceAp = 68.70;
                    break;
                default:
                    priceStudio = 76;
                    priceAp = 77;
                    break;
            }
                    if (nights >7 && nights<14)
                    {
                        priceStudio-=0.05*priceStudio;
                    }
                    else if (nights>14)
                    {
                        priceAp-=0.1*priceAp;
                        if (month == "June" || month =="September")
                        {
                            priceStudio -= 0.2 * priceStudio;
                        }
                        else if (month =="May" || month == "October" )
                        {
                            priceStudio -= 0.3 * priceStudio;

                        }

                    }
                    Console.WriteLine($"Apartment: {nights*priceAp:f2} lv.");
            Console.WriteLine($"Studio: {nights * priceStudio:f2} lv.");


            }
        }
    }

