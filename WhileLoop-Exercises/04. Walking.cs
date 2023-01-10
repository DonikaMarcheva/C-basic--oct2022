using System;

namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int target = 10000;
            string input;
            int steps;
            



            while (target > 0)
            {
                input = Console.ReadLine();
                if ((input = Console.ReadLine()) == "Going Home")
                {
                    steps = int.Parse(input);
                    target -= steps;

                   
                    
                        Console.WriteLine($"{target} more steps to reach goal");
                    
                    break;
                }
             
                steps = int.Parse(input);
                target -= steps;
            }
            Console.WriteLine("Goal reached! Good job!");
            Console.WriteLine($"{Math.Abs(target)} steps over the goal!");

        }
    }
}
