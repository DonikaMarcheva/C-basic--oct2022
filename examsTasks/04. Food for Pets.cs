using System;

namespace _04._Food_for_Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days=int.Parse(Console.ReadLine());
            double food=double.Parse(Console.ReadLine());
            double cookies=0.0;
            double allCookies = 0;
            double allFoodDog = 0;
            double allFoodCat = 0;
            double eatenFood = 0;
            int counter = 0;

            for (int i = 1; i <= days; i++)
            {
               int foodDog = int.Parse(Console.ReadLine());
               int foodCat= int.Parse(Console.ReadLine()); 
                allFoodDog+=foodDog;
                allFoodCat+=foodCat;
                counter++;

                if (counter%3==0)
                {
                    cookies= 0.1*(foodDog+foodCat);
                    allCookies += cookies;
                }
                eatenFood=allFoodDog+allFoodCat;
            }
            Console.WriteLine($"Total eaten biscuits: {Math.Round(allCookies)}gr.");
            Console.WriteLine($"{((allFoodDog + allFoodCat) / food*100):f2}% of the food has been eaten.");
            Console.WriteLine($"{(allFoodDog/eatenFood*100):f2}% eaten from the dog.");
            Console.WriteLine($"{(allFoodCat/eatenFood*100):f2}% eaten from the cat.");
        }
    }
}
