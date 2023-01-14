using System;

namespace _1.Birthday_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rent= double.Parse(Console.ReadLine());

            double cake = 0.2 * rent;
            double drinks = cake * (1 - 0.45);
            double animator = 1 / 3.0 * rent;
            Console.WriteLine(rent+cake+drinks+animator);   
        }
    }
}
