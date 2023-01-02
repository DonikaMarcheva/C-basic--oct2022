using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string feedback = Console.ReadLine();

            double priceRoomPerNight = 18.0;
            double priceApartmentPerNight = 25;
            double pricePresidentApPerNight = 35;
            double price = 0.0;

            if (typeOfRoom =="apartment")
            {
                if(days<10)
                {
                    priceApartmentPerNight-=0.3*priceApartmentPerNight;
                }
                else if (days<15)
                {
                    priceApartmentPerNight -= 0.35 * priceApartmentPerNight;
                }
                else
                {
                    priceApartmentPerNight -= 0.50 * priceApartmentPerNight;
                }
                price = priceApartmentPerNight * (days - 1);
            }
            else if (typeOfRoom == "president apartment")
            {
                if (days < 10)
                {
                    pricePresidentApPerNight -= 0.1 * pricePresidentApPerNight;
                }
                else if (days < 15)
                {
                    pricePresidentApPerNight -= 0.15 * pricePresidentApPerNight;
                }
                else
                {
                    pricePresidentApPerNight -= 0.2 * pricePresidentApPerNight;
                }
                price = pricePresidentApPerNight * (days - 1);
            }
            else
            {
               price=priceRoomPerNight * (days - 1);
            }
            if (feedback=="positive")
            {
                price += 0.25 * price;
            }
            else
            {
                price -= 0.1 * price;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
