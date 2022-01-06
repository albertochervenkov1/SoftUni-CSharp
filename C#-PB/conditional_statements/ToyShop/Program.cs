using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricetrip = double.Parse(Console.ReadLine());//cena na eksurziqta
            int brpuzzle = int.Parse(Console.ReadLine());// broika na puzelite
            int brdolls = int.Parse(Console.ReadLine());// broika na kuklite
            int brbears = int.Parse(Console.ReadLine());// broika na mechetata
            int brminions = int.Parse(Console.ReadLine());// broika na mionionite
            int brtrucks = int.Parse(Console.ReadLine());// broika na kamionite
            //ceni na igrachkite

            double pricepuzzle = brpuzzle*2.60;
            double pricedolls = brdolls*3;
            double pricebears = brbears*4.10;
            double priceminions = brminions*8.20;
            double pricetrucks = brtrucks*2;

            double totaltoys = brpuzzle + brdolls + brbears + brminions + brtrucks;
            double toysprice = pricebears + pricedolls + priceminions + pricepuzzle + pricetrucks;

            if (totaltoys>=50)
            {
                double sale=toysprice * 25 / 100;
                 toysprice = toysprice - sale;
                
               

            }
            double rentcost = toysprice * 0.10;
            toysprice = toysprice - rentcost;

            if (toysprice>=pricetrip)
            {
                double difference = toysprice - pricetrip;
                Console.WriteLine($"Yes! {difference:F2} lv left.");
            }
            else
            {
                double difference = pricetrip - toysprice;
                Console.WriteLine($"Not enough money! {difference:F2} lv needed.");
            }
           
           
            
        }
    }
}
