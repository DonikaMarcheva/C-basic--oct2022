using System;

namespace _07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int number= int.MaxValue;

            while((input = Console.ReadLine()) != "Stop")
            {
               int n= int.Parse(input);

                if (n<number)
                {
                    number = n;
                }
            }
            Console.WriteLine(number);
        }
    }
}
