using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input;
            double personalGrade;
            double gradeOfPresentation=0.0;
            double grade = 0;
            int counter = 0;


            while ((input=Console.ReadLine())!= "Finish")
            {
                counter++;
                for (int i = 1; i <= n; i++)
                {
                    personalGrade = double.Parse(Console.ReadLine());
                    gradeOfPresentation += personalGrade;
                }
                
                Console.WriteLine($"{input} - {(gradeOfPresentation/ n):f2}.");
                grade +=gradeOfPresentation;
                gradeOfPresentation = 0;
               
            }
            Console.WriteLine($"Student's final assessment is {(grade /(counter*n)):f2}.");
        }
    }
}
