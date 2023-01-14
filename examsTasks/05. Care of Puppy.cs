using System;

namespace _05._Care_of_Puppy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int food=int.Parse(Console.ReadLine());
            string input;
            int food2;
            int eatenFood = 0;

            while ((input=Console.ReadLine()) != "Adopted")
            {
                food2 = int.Parse(input);
                eatenFood += food2;
            }
            if (eatenFood <=(1000 * food))
            {
                Console.WriteLine($"Food is enough! Leftovers: {1000*food - eatenFood} grams.");
            }
            else if (eatenFood > (1000 * food))
            {
                Console.WriteLine($"Food is not enough. You need {eatenFood - 1000*food} grams more.");
            }
        }
    }
}
