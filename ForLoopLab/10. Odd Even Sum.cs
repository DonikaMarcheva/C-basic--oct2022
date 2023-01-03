using System;

namespace _10._Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumEven = 0;
            int sumOdd= 0;

            for (int i = 1; i <= n; i++)
            {
                int a = int.Parse(Console.ReadLine());

                if(i%2==0)
                {
                    sumEven+=a;
                }
                else
                {
                    sumOdd += a;
                }
            }
            if (sumEven==sumOdd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumOdd}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumEven - sumOdd)}");
            }
        }
    }
}
