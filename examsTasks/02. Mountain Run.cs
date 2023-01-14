using System;

namespace _02._Mountain_Run
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record=double.Parse(Console.ReadLine());
            double distance=double.Parse(Console.ReadLine());   
            double timeForM=double.Parse(Console.ReadLine());

            double delay = Math.Floor(distance / 50) * 30.0;

            double time = distance * timeForM + delay;

            if (time<record)
            {
                Console.WriteLine($" Yes! The new record is {time:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {(time - record):f2} seconds slower.");
            }
        }
    }
}
