using System;

namespace weedingDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            double ballonsCounter = 0;
            double flowersCounter = 0;
            double candlesCounter = 0;
            double ribbonCounter = 0;
            double totalMoneySpend = 0;

            int numBallons = 0;
            int numFlowers = 0;
            int numCandles = 0;
            int numRibbon = 0;
            

            bool commandStop = false;
            while (budget>0)
            {
                string typeStock = Console.ReadLine();
                int numofStock = int.Parse(Console.ReadLine());
                if (typeStock=="balloons")
                {
                    ballonsCounter = numofStock * 0.1;
                    totalMoneySpend += ballonsCounter;
                    budget -= ballonsCounter;
                    numBallons += numofStock;
                }
                else if (typeStock=="flowers")
                {
                    flowersCounter = numofStock * 1.5;
                    totalMoneySpend += flowersCounter;
                    budget -= flowersCounter;
                    numFlowers += numofStock;
                }
                else if (typeStock=="candles")
                {
                    candlesCounter = numofStock * 0.5;
                    totalMoneySpend += candlesCounter;
                    budget -= candlesCounter;
                    numCandles += numofStock;
                }
                else if (typeStock=="ribbon")
                {
                    ribbonCounter = numofStock * 2;
                    totalMoneySpend += ribbonCounter;
                    budget -= ribbonCounter;
                    numRibbon += numofStock;
                }
                else if (typeStock=="stop")
                {
                    commandStop = true;
                    break;
                }
            }
            if (commandStop)
            {
                Console.WriteLine($"Spend money: {totalMoneySpend}");
                Console.WriteLine($"Money left: {budget-totalMoneySpend}");
                Console.WriteLine($"Purchased decoration is {numBallons} ballons, {numRibbon} m ribbon, {numFlowers} flowers and {numCandles} candles.");
            }
            else
            {
                Console.WriteLine("All money spent!");
                Console.WriteLine($"Purchased decoration is {numBallons} ballons, {numRibbon} m ribbon, {numFlowers} flowers and {numCandles} candles.");
            }
        }
    }
}
