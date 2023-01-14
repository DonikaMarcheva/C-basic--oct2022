using System;

namespace _04._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int n4 = 0;
            int n5 = 0;
            int people = 0;



            for (int i = 1; i <= n; i++)
            {
             
               people = int.Parse(Console.ReadLine());
                 if (people<=5)
                {
                    n1+=people;
                }
                 else if (people<=12)
                {
                    n2 += people;
                }
                 else if (people<=25)
                {
                    n3 += people;
                }
                 else if (people<=40)
                {
                    n4 += people;
                }
                 else
                {
                    n5 += people;
                }

            }
            people = n1 + n2 + n3 + n4 + n5;
            Console.WriteLine($"{((double)n1 / people * 100.0):f2}%");
            Console.WriteLine($"{((double)n2 / people * 100.0):f2}%");
            Console.WriteLine($"{((double)n3 / people * 100.0):f2}%");
            Console.WriteLine($"{((double)n4 / people * 100.0):f2}%");
            Console.WriteLine($"{((double)n5 / people * 100.0):f2}%");
        }
    }
}
