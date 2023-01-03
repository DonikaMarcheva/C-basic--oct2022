using System;

namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumA = 0;
            int sumB = 0;

            for (int i = 1; i <= 2*n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (i<=n)
                {
                   sumA+=a;
                }
                else
                {
                    sumB += a;
                }
            }
            if (sumA==sumB)
            {
                Console.WriteLine($"Yes, sum = {sumA}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumA - sumB)}");
            }
            
        }

    }
}
