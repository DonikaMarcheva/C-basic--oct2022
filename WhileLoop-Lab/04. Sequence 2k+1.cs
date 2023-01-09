using System;

namespace _04._Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            int n = int.Parse(Console.ReadLine());

            while (k<=n)
            {
                Console.WriteLine(k);
                k = k * 2 + 1;
            }
        }
    }
}
