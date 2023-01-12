using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie;
            string ticket;
            int studentCount = 0;
            int standartCount = 0;
            int kidCount = 0;
            int freeSeat;
            int allTickets = 0;
            

            while ((movie = Console.ReadLine()) != "Finish")
            {
                freeSeat = int.Parse(Console.ReadLine());
                studentCount = 0;
                standartCount = 0;
                kidCount = 0;

                while ((ticket = Console.ReadLine()) != "End")
                {
                    if (ticket == "Finish")
                    {
                        Console.WriteLine($"{movie} - 100.00% full");
                        break;
                    }
                    else if (ticket == "student")
                    {
                        studentCount++;
                    }

                    else if (ticket == "standard")
                    {
                        standartCount++;
                    }
                    else if (ticket == "kid")
                    {
                        kidCount++;
                    }          
                  
                }
                Console.WriteLine($"{movie} - {((studentCount + standartCount + kidCount) / (double)freeSeat * 100):f2}% full");
                allTickets = studentCount + standartCount + kidCount;
                
            }
            Console.WriteLine($"Total tickets: {allTickets}");
            Console.WriteLine($"{(studentCount / (double)allTickets * 100):f2}% student tickets.");
            Console.WriteLine($"{(standartCount / (double)allTickets * 100):f2}% standart tickets.");
            Console.WriteLine($"{(kidCount / (double)allTickets * 100):f2}% kid tickets.");

        }
    }
}
