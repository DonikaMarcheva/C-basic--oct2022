using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int points=int.Parse(Console.ReadLine());
            string position;
            int winnerPosition = 0;
            int winnedPoints=0;

            for (int i = 1; i <=n; i++)
            {
                position = Console.ReadLine();

                if (position=="W")
                {
                    points += 2000;
                    winnerPosition++;
                    winnedPoints += 2000;
                }
                else if (position=="F")
                {
                    points += 1200;
                    winnedPoints += 1200;
                }
                else
                {
                    points += 720;
                    winnedPoints+=720;
                }
            }
            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Floor((double)winnedPoints/ n)}");

            Console.WriteLine($"{(double)winnerPosition / n * 100:f2}%");
        }
    }
}
