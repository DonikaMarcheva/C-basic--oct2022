using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            double number = double.MinValue;

            while ((input=Console.ReadLine())!= "Stop")
            {
                double n= double.Parse(input);

                if (n > number)
                {
                    number=n;
                }
            }
            Console.WriteLine(number);
        }
    }
}
