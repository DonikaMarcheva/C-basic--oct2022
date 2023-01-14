using System;

namespace _06._Tournament_of_Christmas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sport;
            int days=int.Parse(Console.ReadLine());
            string result;
            int counterWin = 0;
            int counterLose = 0;
            int allWin = 0;
            int allLose = 0;
            double money=0;

            for (int i = 1; i <= days; i++)
            {
                while ((sport=Console.ReadLine()) != "Finish")
                {
                    result = Console.ReadLine();

                    if (result == "win")
                    {
                        counterWin++;
                        allWin++;
                    }
                    else
                    {
                        counterLose++;
                        allLose++;
                    }

                }
                money += counterWin * 20;
                if (counterWin>counterLose)
                {
                    money += 0.1 * counterWin * 20;
                }
                counterWin = 0;
                counterLose = 0;
            }
            if (allWin>allLose)
            {
                money += 0.2 * money;
                Console.WriteLine($"You won the tournament! Total raised money: {money:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {money:f2}");
            }
        }
    }
}
