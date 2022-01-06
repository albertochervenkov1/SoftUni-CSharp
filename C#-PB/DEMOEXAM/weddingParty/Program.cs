using System;

namespace weddingParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double couvertPrice = (double)guests * 20;

            if (couvertPrice <= budget)
            {
                double sumLeft = budget - couvertPrice;
                double fireworks = sumLeft * 0.4;
                sumLeft -= fireworks;
                Console.WriteLine($"Yes! {Math.Round(fireworks)} lv are for fireworks and {Math.Round(sumLeft)} lv are for donation.");
            }
            else if (couvertPrice > budget)
            {
                double sumLeft = couvertPrice - budget;
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {Math.Round(sumLeft)} lv more.");
            }
        }
    }
}
