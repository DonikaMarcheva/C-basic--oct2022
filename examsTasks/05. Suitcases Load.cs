using System;
using System.Diagnostics.Tracing;

namespace _05._Suitcases_Load
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double trunk= double.Parse(Console.ReadLine());
            int counter= 0; 
            string input;
            double suitcase;
            while((input=Console.ReadLine()) != "End")
            {
                suitcase = double.Parse(input);
                trunk-=suitcase;
                counter++;
                if (counter % 3 ==0)
                {
                    trunk -= 0.1 * suitcase;
                }
                if (trunk <= 0)
                {
                    Console.WriteLine("No more space!");
                    Console.WriteLine($"Statistic: {counter-1} suitcases loaded.");
                    return;
                }

            }
            Console.WriteLine("Congratulations! All suitcases are loaded!");
            Console.WriteLine($"Statistic: {counter} suitcases loaded.");
        }
    }
}
