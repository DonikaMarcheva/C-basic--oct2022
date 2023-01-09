using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name=Console.ReadLine();
            double totalMarks = 0;
            int badMarksCount = 0;
            int gradeNum = 1;

            while (gradeNum<=12)
            {
                double mark=double.Parse(Console.ReadLine());
                totalMarks += mark;

                if (mark<4)
                {
                    badMarksCount++;
                    
                    if(badMarksCount>1)
                    {
                        Console.WriteLine($"{name} has been excluded at {gradeNum} grade");
                        return;
                    }
                }
                else
                {
                    gradeNum++;
                }
            }
            double averageGrade=totalMarks/(12+badMarksCount);
            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
        }
    }
}
