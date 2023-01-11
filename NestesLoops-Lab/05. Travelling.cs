using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money;
            string destination;
            
            while ((destination = Console.ReadLine()) != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                
              while ((money = double.Parse(Console.ReadLine()))< budget)
                {
                    budget-=money;
                    
                }

                Console.WriteLine($"Going to {destination}!");
            }
            

        }
    }
}
