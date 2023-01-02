using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char op = char.Parse(Console.ReadLine());
            

            if (op == '+' || op == '-' || op == '*')
            {
                int result = 0;
                if (op == '+')
                {
                    result = n1 + n2;
                }
                else if (op == '-')
                {
                    result = n1 - n2;
                }
                else
                {
                    result = n1 * n2;
                }
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} {op} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {op} {n2} = {result} - odd");
                }
            }
            else 
            {
               
                if (n2==0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else if (op =='/')
                {
                    
                    Console.WriteLine($"{n1} / {n2} = {(double)n1/n2:f2}");
                }
                else
                {
                   Console.WriteLine($"{n1} % {n2} = {n1%n2}");
                }
            }
        }
    }
}
