using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double excursionPrice=double.Parse(Console.ReadLine());
            double availableMoney=double.Parse(Console.ReadLine());
            int daysCounter = 0;
            int spendCounter = 0;

            string action=string.Empty;
            double money;

            while (availableMoney<excursionPrice)
            {
                action=Console.ReadLine();
                money = double.Parse(Console.ReadLine());
                daysCounter++;
                if (action == "spend")
                {
                    spendCounter++;
                    if (availableMoney < money)
                    {
                        availableMoney = 0;
                    }
                    else
                    {
                        availableMoney -= money;
                    }

                    if (spendCounter == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(daysCounter);
                        return;
                    }
                }
                else
                {
                    availableMoney += money;
                    spendCounter = 0;
                }


            }
            Console.WriteLine($"You saved the money for {daysCounter} days.");
        }
    }
}
