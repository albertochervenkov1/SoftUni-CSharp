using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            double brdni = double.Parse(Console.ReadLine());
            double brsladkari = double.Parse(Console.ReadLine());

            //menu
            double torti = double.Parse(Console.ReadLine());
            double gofreti = double.Parse(Console.ReadLine());
            double pancakes = double.Parse(Console.ReadLine());

            //profit
            double priceoftorti = torti * 45;
            double priceofgofreti = gofreti * 5.80;
            double priceofpancakes = pancakes * 3.20;

            double totalprice = (priceoftorti + priceofgofreti + priceofpancakes)*brsladkari;
            double total = brdni * totalprice;
            double totaltotal = total-total*1/8;

            Console.WriteLine($"{totaltotal:F2}");


        }
    }
}
