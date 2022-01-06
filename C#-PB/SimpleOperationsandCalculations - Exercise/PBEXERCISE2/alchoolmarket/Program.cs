using System;

namespace alchoolmarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricewhiskeylv = double.Parse(Console.ReadLine());
            double quantitybeer = double.Parse(Console.ReadLine());// quantity beer in l
            double quantitywine = double.Parse(Console.ReadLine());// quantity wine in l
            double quantitygrape = double.Parse(Console.ReadLine());// quantity grape in l
            double quantitywhiskey = double.Parse(Console.ReadLine());// quantity whiskey in l

            double pricegrape = pricewhiskeylv / 2;
            double pricewine = pricegrape - (0.4 * pricegrape);
            double pricebeer= pricegrape - (0.8 * pricegrape);
            double totalgrape = quantitygrape * pricegrape;
            double totalwine = quantitywine * pricewine;
            double totalbeer = quantitybeer * pricebeer;
            double totalwhiskey = quantitywhiskey * pricewhiskeylv;
            double total = totalbeer + totalgrape + totalwhiskey + totalwine;
            Console.WriteLine($"{total:F2}");

        }
    }
}
