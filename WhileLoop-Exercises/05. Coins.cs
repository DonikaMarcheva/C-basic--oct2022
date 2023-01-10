using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 лв=200 монети
            //1 лв= 100 монети
            //50 ст.=50 монети
            //20 ст.=20 монети
            //10 ст=10 монети
            //5 ст=5 монети
            //2 ст=2 монети
            // 1 ст = 1 монета

            double money=double.Parse(Console.ReadLine());
            double coins = 100 * money;
            int coinsCounter = 0;

            while (coins>0)
            {
                if (coins/200>=1)
                {
                    coinsCounter += (int)coins / 200;
                    coins = coins % 200;
                }
                else if (coins/100>=1)
                {
                    coinsCounter += (int)coins / 100;
                    coins= coins % 100;
                }
                else if (coins/50>=1)
                {
                    coinsCounter += (int)coins / 50;
                    coins = coins % 50;
                }
                else if (coins/20>=1)
                {
                    coinsCounter += (int)coins / 20;
                    coins = coins % 20;
                }
                else if (coins/10>=1)
                {
                    coinsCounter +=(int)coins / 10;
                    coins = coins % 10;
                }
                else if (coins/5>=1)
                {
                    coinsCounter += (int)coins / 5;
                    coins = coins % 5;
                }
                else if (coins/2>=1)
                {
                    coinsCounter +=(int)coins / 2;
                    coins = coins % 2;
                }
                else
                {
                    coinsCounter += (int)coins;
                    break;
                }
            }
            Console.WriteLine(coinsCounter);
        }
    }
}
