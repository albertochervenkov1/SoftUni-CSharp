using System;

namespace _01._Christmas_Sweets
{
    class Program
    {
        static void Main(string[] args)
        {
           

            double cenaBaklava = double.Parse(Console.ReadLine());
            double cenaMuffins = double.Parse(Console.ReadLine());
            double kgChtolen = double.Parse(Console.ReadLine());
            double kgSweets = double.Parse(Console.ReadLine());
            double kgbiscuits = double.Parse(Console.ReadLine());

            double cenaChtolen = cenaBaklava + cenaBaklava * 0.6;
            double sumChtolen = cenaChtolen * kgChtolen;
            

            double cenaSweets = cenaMuffins + cenaMuffins * 0.8;
            
            double sumSweets = cenaSweets * kgSweets;
            //Console.WriteLine(sumSweets);
            double sumBiscuits = kgbiscuits * 7.50;

            double total = sumChtolen + sumSweets + sumBiscuits;
            Console.WriteLine($"{total:F2}");

        }
    }
}
