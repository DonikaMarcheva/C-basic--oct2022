using System;

namespace _04._Grandpa_Stavri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            double rakia;
            double degrees;
            double allRakia = 0;
            double allDegrees=0;
            double averageDegrees;
           

            for (int i = 1; i <=n; i++)
            {
                rakia = double.Parse(Console.ReadLine());
                degrees = double.Parse(Console.ReadLine());
                allRakia += rakia;
                allDegrees+=rakia*degrees;
            }
            averageDegrees = allDegrees/allRakia;
            Console.WriteLine($"Liter: {allRakia:f2}");
            Console.WriteLine($"Degrees: {averageDegrees:f2}");

            if (averageDegrees<38)
            {
                Console.WriteLine("Not good, you should baking!");

            }
            else if (averageDegrees<42)
            {
                Console.WriteLine("Super!");
            }
            else
            {
                Console.WriteLine("Dilution with distilled water!");
            }



        }
    }
}
