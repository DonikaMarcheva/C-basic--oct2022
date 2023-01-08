using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1=0;
            int p2=0;
            int p3=0;
            int p4=0;
            int p5=0;
            int people;

            for (int i = 1; i <=n; i++)
            {
                people = int.Parse(Console.ReadLine());
                if (people <=5 )
                {
                    p1 += people;
                }
                else if (people <=12 )
                {
                    p2 += people;
                }
                else if (people <= 25)
                {
                    p3 += people;
                }
                else if (people <= 40)
                {
                    p4 += people;
                }
                else
                {
                    p5+=people;
                }
            }
            int sumPeople = p1 + p2 + p3 + p4 + p5;
            
            Console.WriteLine($"{(double)p1 / sumPeople * 100:f2}%");
            Console.WriteLine($"{(double)p2 / sumPeople * 100:f2}%");
            Console.WriteLine($"{(double)p3 / sumPeople * 100:f2}%");
            Console.WriteLine($"{(double)p4 / sumPeople * 100:f2}%");
            Console.WriteLine($"{(double)p5 / sumPeople * 100:f2}%");


        }
    }
}
