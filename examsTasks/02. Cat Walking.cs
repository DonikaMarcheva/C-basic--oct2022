using System;

namespace _02._Cat_Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutes=int.Parse(Console.ReadLine());
            int walkings=int.Parse(Console.ReadLine()); 
            int calories=int.Parse(Console.ReadLine());

            int burnedCalories = minutes * walkings * 5;

            if (burnedCalories >= 0.5*calories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {minutes * walkings * 5}.");
                
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {minutes * walkings * 5}.");
            }
        }
    }
}
