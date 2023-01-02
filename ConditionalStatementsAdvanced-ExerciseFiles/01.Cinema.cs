using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            

            if (type == "Premiere")
            {
                double income = rows * columns * 12.00;
                Console.WriteLine($"{rows * columns * 12.00:f2} leva");
            }
            else if (type == "Normal")
            {
                double income = rows * columns * 7.50;
                Console.WriteLine($"{income:f2} leva");
            }
            else
            {
                double income = rows * columns * 5.0;
                Console.WriteLine($"{income:f2} leva");
            }
        }
    }
}
