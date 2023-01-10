using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int roomSize = a * b * c;
            string input;

            while (roomSize > 0)
            {
                input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }
                int boxes = int.Parse(input);
                roomSize -= boxes;

            }

            if (roomSize < 0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(roomSize)} Cubic meters more.");

            }

            else
            {
                Console.WriteLine($"{roomSize} Cubic meters left.");
            }


        }
    }
}
