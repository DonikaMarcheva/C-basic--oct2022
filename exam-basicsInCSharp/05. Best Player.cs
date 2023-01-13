using System;

namespace _05._Best_Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string player=string.Empty;
            string input;
            int bestScore = int.MinValue;

            while ((input = Console.ReadLine()) != "END")
            {
                
               int  score = int.Parse(Console.ReadLine());
                if (score > bestScore)
                {
                    bestScore = score;
                    player = input;
                }
                
                if (score>=10)
                    break;
            }
                Console.WriteLine($"{player} is the best player!");

                if (bestScore < 3)
                    Console.WriteLine($"He has scored {bestScore} goals.");
                else if (bestScore >= 3)
                    Console.WriteLine($"He has scored {bestScore} goals and made a hat-trick !!!");
               

            
        }
    }
}