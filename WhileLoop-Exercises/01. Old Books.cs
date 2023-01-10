using System;
using static System.Reflection.Metadata.BlobBuilder;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            string name;
            int counter = 0;

            while ((name=Console.ReadLine()) != "No More Books")
            {

                if (book ==name)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    return;
                }
                else
                {
                    counter++;
                }
                
            }
            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {counter} books.");

        }
    }
}
