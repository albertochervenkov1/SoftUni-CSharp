using System;

namespace _02._Christmas_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double cenaFantasy = 14.9;
            double cenaHorror = 9.80;
            double cenaRomantic = 4.30;

            double moneyforEarn = double.Parse(Console.ReadLine());
            int numFantasy = int.Parse(Console.ReadLine());
            int numHorror = int.Parse(Console.ReadLine());
            int numRomantic = int.Parse(Console.ReadLine());

            double moneyEarned = (numFantasy * cenaFantasy) + (numHorror*cenaHorror) + (numRomantic*cenaRomantic);
            double DDS = moneyEarned * 0.2;
            double moneyEarnedDDS = moneyEarned - DDS;

            if (moneyEarnedDDS>moneyforEarn)
            {
                double diff = moneyEarnedDDS - moneyforEarn;
                double moneyForS = diff * 0.1;
                double moneyForSellers = Math.Floor(moneyForS);
                double mnf = diff-moneyForSellers;

                double moneyForDonation = moneyforEarn + mnf;
                Console.WriteLine($"{moneyForDonation:F2} leva donated.");
                Console.WriteLine($"Sellers will receive {moneyForSellers} leva.");
            }
            else
            {
                double moneyNeeded = moneyforEarn - moneyEarnedDDS;
                Console.WriteLine($"{moneyNeeded:F2} money needed."
);
            }
        }
    }
}
