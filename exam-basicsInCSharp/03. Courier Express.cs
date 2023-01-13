using System;

namespace _03._Courier_Express
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            string serviceType = Console.ReadLine();
            int km = int.Parse(Console.ReadLine());
            double price=0;
            double extraPay;
            double extraPaykm;
            double extra;


            if (serviceType == "standard")
            {
                if (weight < 1)
                {
                    price = 0.03 * km;
                }
                else if (weight < 10)
                    price = 0.05 * km;
                else if (weight < 40)
                    price = 0.10 * km;
                else if (weight < 90)
                    price = 0.15 * km;
                else if (weight < 150)
                {
                    price = 0.20 * km;
                }
                Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {price:f2} lv.");
            }
            //•	За пратки по - леки от 1 кг – на килограм по 80 % от съответната цена на километър
            //•	От 1 кг до 10  кг – на килограм по 40 % от съответната цена на километър
            //•	От 10 кг вкл. до 40 кг – на килограм по 5 % от съответната цена на километър
            //•	От 40 кг вкл. до 90  кг – на килограм по 2 % от съответната цена на километър
            //•	От 90 кг вкл. до 150 кг – на килограм по 1 % от съответната цена на километър

            else
            {
                if (weight < 1)
                {
                    price = 0.03 * km;
                    extraPaykm = 0.800 * 0.03;
                    extraPay =  extraPaykm * weight;
                    extra = extraPay* km;
                    price += extra;
                }

                else if (weight < 10)
                {
                    price = 0.05 * km;
                    extraPaykm = 0.400 * 0.05;
                    extraPay = extraPaykm * weight;
                    extra = extraPay * km;
                    price += extra;
                }
                else if (weight < 40)
                {
                    price = 0.10 * km;
                    extraPaykm = (5.000 / 100) * 0.100;
                    extraPay =  extraPaykm* weight;
                    extra = extraPay * km;
                    price += extra;
                }
                else if (weight < 90)
                {
                    price = 0.15 * km;
                    extraPaykm = (2.000 / 100) * 0.15;
                    extraPay =  extraPaykm* weight;
                    extra = extraPay * km;
                    price += extra;
                }
                else if (weight < 150)
                {
                    price = 0.20 * km;
                    extraPaykm = (1.000 / 100) * 0.20;
                    extraPay =  extraPaykm* weight;
                    extra = extraPay * km;
                    price += extra;
                }
                Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {price:f2} lv.");

            }

        }
    }
}
