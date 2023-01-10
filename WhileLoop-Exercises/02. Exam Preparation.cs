using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int badGrades=int.Parse(Console.ReadLine());
            int counterBadGrades = 0;
            int problemsSolved = 0;
            int sumOfGrades = 0;
            string lastProblem=string.Empty;
            

            while(badGrades>counterBadGrades)
            {
                string name = Console.ReadLine();
               
                if (name == "Enough")
                {
                   
                    Console.WriteLine($"Average score: {(double)sumOfGrades / problemsSolved:f2}");
                    Console.WriteLine($"Number of problems: {problemsSolved}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    return;
                }
                
                int grade=int.Parse(Console.ReadLine());
                problemsSolved++;
                sumOfGrades += grade;
                lastProblem = name;
                

                if (grade<=4)
                {
                    counterBadGrades++;
                }
                
            }
            Console.WriteLine($"You need a break, {counterBadGrades} poor grades.");
        }
    }
}
