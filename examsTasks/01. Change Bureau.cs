using System;

namespace _01._Change_Bureau
{
    internal class Program
    {
        static void Main(string[] args)
        {
//            •	1 биткойн = 1168 лева.
//            •	1 китайски юан = 0.15 долара.
//            •	1 долар = 1.76 лева.
//            •	1 евро = 1.95 лева.

            int bitcoins=int.Parse(Console.ReadLine());
            double chinaUan=double.Parse(Console.ReadLine());
            double comision=double.Parse(Console.ReadLine());

            double uanInUSD = chinaUan * 0.15;
            double usdInLv = uanInUSD * 1.76;
            double allCurrency = (1168 * bitcoins + usdInLv) / 1.95;
            double money = allCurrency * (1 - comision/100);
            Console.WriteLine($"{money:f2}");




        }
    }
}
