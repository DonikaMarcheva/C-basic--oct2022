using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=int.Parse(Console.ReadLine());
            int b= int.Parse(Console.ReadLine());
            string input;

            int pieces = a * b;
            

            while ((input=Console.ReadLine()) != "STOP")
            {
                int piecesForGuests = int.Parse(input);
                pieces -= piecesForGuests;
                
                if (pieces<=0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
                    return;
                }
            }
            Console.WriteLine($"{pieces} pieces are left.");
        }
    }
}
