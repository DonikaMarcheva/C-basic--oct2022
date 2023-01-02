using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            int minutesE = examHour * 60 + examMinute;
            int minutesA = arrivalHour * 60 + arrivalMinute;

            //.“Late”, ако студентът пристига по-късно от часа на изпита.
            if (minutesE - minutesA<0)
            {
                Console.WriteLine("Late");
                //.ако закъснява под 1 час
                if (minutesA- minutesE <=59)
                {
                    Console.WriteLine($"{minutesA - minutesE} minutes after the start");
                }
                //.ако закъснява над кръгъл час и под 9 мин
                else if (minutesA-minutesE>59 && (minutesA - minutesE)%60 <= 9)
                {
                    Console.WriteLine($"{(minutesA - minutesE) / 60}:0{(minutesA - minutesE) % 60} hours after the start");
                }
                //.ако закъснява над кръгъл час и над 10 мин вкл.
                else
                {
                    Console.WriteLine($"{(minutesA - minutesE) / 60}:{(minutesA - minutesE) % 60} hours after the start");
                }
            }
            else if (minutesE-minutesA<=30)
            {
                Console.WriteLine("On time");
                if (minutesE % minutesA >0 && minutesE % minutesA <= 9)
                {
                    Console.WriteLine($"{minutesE - minutesA} minutes before the start");
                }
                else if (minutesE % minutesA > 9)
                {
                    Console.WriteLine($"{minutesE - minutesA} minutes before the start");
                }
            }
            else
            {
                Console.WriteLine("Early");
                //.ако подранява до час
                if (minutesE- minutesA <=59)
                {
                    Console.WriteLine($"{minutesE - minutesA} minutes before the start");
                }
                //. ако подранява над кръгъл час и под 9 мин
                else if (minutesE - minutesA >59 && (minutesE - minutesA)%60 <= 9)
                {
                    Console.WriteLine($"{(minutesE - minutesA) / 60}:0{(minutesE - minutesA) % 60} hours before the start");
                }
                //.ако подранява над кръгъл час и над 10 мин
                
                else
                {
                    Console.WriteLine($"{(minutesE - minutesA) / 60}:{(minutesE - minutesA)%60} hours before the start");
                }

            } 
            
                                                        
            
        }
        }
    }


