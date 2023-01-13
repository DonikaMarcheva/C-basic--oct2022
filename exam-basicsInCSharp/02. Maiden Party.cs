using System;

namespace _02._Maiden_Party
{
    internal class Program
    {
        static void Main(string[] args)
         {
//            •	Любовно послание -0.60 лв.
//            •	Восъчна роза -7.20 лв.
//            •	Ключодържател - 3.60 лв.
//            •	Карикатура - 18.20 лв.
//            •	Късмет изненада -22 лв.

            double priceParty= double.Parse(Console.ReadLine());
            int love= int.Parse(Console.ReadLine());
            int roses= int.Parse(Console.ReadLine());
            int keysHandle= int.Parse(Console.ReadLine());
            int caricatures=int.Parse(Console.ReadLine());
            int luckSurprice= int.Parse(Console.ReadLine());

            int quantity = love + roses + keysHandle + caricatures + luckSurprice;
            double profit=0.6*love+7.2*roses+3.6*keysHandle+18.2*caricatures+22*luckSurprice;

            if (quantity>=25)
            {
                profit-=0.35*profit;
            }
            double hosting=0.1*profit;
            profit -= hosting;

            if (profit>=priceParty)
            {
                Console.WriteLine($"Yes! {(profit - priceParty):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(priceParty - profit):f2} lv needed.");
            }

        }
    }
}
