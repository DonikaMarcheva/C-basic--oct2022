using System;

namespace _03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int currNum ;
            int sumPrime = 0;
            int sumNonPrime = 0;

            while ((input =Console.ReadLine()) != "stop")
            {
               currNum=int.Parse(input);

                if (currNum <0)
                {
                    Console.WriteLine("Number is negative.");

                  
                    continue;
                }
                
                bool isPrime = true;
                for (int i = 2; i < currNum; i++)
                {
                    if (currNum%i==0)
                    {
                        isPrime = false;
                        break;
                    }
                   
                }
                if (isPrime)
                {
                    sumPrime+=currNum;
                }
                else
                {
                    sumNonPrime+=currNum;
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}"); 
        }
    }
}
