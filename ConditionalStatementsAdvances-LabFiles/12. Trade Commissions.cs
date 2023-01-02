using System;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            if (town =="Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine($"{(5 / 100.0 * sales):f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine($"{(7 / 100.0 * sales):f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine($"{(8 / 100.0 * sales):f2}");
                }
                else if (sales > 10000)
                {
                    Console.WriteLine($"{(12 / 100.0 * sales):f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }

                }
                else if (town=="Varna")
                {
                    if (sales >= 0 && sales <= 500)
                    {
                        Console.WriteLine($"{(4.5 / 100.0 * sales):f2}");
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        Console.WriteLine($"{(7.5 / 100.0 * sales):f2}");
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        Console.WriteLine($"{(10 / 100.0 * sales):f2}");
                    }
                    else if (sales > 10000)
                    {
                        Console.WriteLine($"{(13 / 100.0 * sales):f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                    }
                    else if (town=="Plovdiv")
                    {
                        if (sales >= 0 && sales <= 500)
                        {
                            Console.WriteLine($"{(5.5 / 100.0 * sales):f2}");
                        }
                        else if (sales > 500 && sales <= 1000)
                        {
                            Console.WriteLine($"{(8 / 100.0 * sales):f2}");
                        }
                        else if (sales > 1000 && sales <= 10000)
                        {
                            Console.WriteLine($"{(12 / 100.0 * sales):f2}");
                        }
                        else if (sales > 10000)
                        {
                            Console.WriteLine($"{(14.5 / 100.0 * sales):f2}");
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
            }
                    else 
            { 
                Console.WriteLine("error"); 
            }
        }
    }
}
