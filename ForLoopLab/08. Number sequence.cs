using System;

namespace _08._Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a=int.MinValue;
            int b=int.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num>a)
                {
                    a = num;
                    
                }
                if (num<b)
                {
                    b = num;
                   
                }

            }
            Console.WriteLine($"Max number: {a}");
            Console.WriteLine($"Min number: {b}");
        }
    }
}
