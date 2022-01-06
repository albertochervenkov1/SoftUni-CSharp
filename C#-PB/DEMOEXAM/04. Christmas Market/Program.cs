using System;

namespace _04._Christmas_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            int productCounter = 0;
            double priceProduct = 0;
            bool commandFinish = false;
            double totalMoneySpent = 0;
            double missingmoney = 0;


            while (budget>0)
            {
                
                
               
                string product = Console.ReadLine();
                



                if (product=="Star")
                {
                    priceProduct = 5.69;
                    productCounter++;
                    budget -= priceProduct;
                    totalMoneySpent += priceProduct;
                }
                else if (product=="Angel")
                {
                    priceProduct = 8.49;
                    productCounter++;
                    budget -= priceProduct;
                    totalMoneySpent += priceProduct;
                }
                else if (product=="Lights")
                {
                    priceProduct = 11.20;
                    productCounter++;
                    budget -= priceProduct;
                    totalMoneySpent += priceProduct;

                }
                else if (product=="Wreath")
                {
                    priceProduct = 15.50;
                    productCounter++;
                    budget -= priceProduct;
                    totalMoneySpent += priceProduct;
                }
                else if (product=="Candle")
                {
                    priceProduct = 3.59;
                    productCounter++;
                    budget -= priceProduct;
                    totalMoneySpent += priceProduct;

                }
                if (productCounter % 3 == 0)
                {
                    double sale = priceProduct * 0.3;
                    priceProduct -= sale;
                    totalMoneySpent -= sale;

                }
                if (budget < 0)
                {
                    totalMoneySpent -= priceProduct;
                    missingmoney = priceProduct - budget;

                    break;
                    
                }
                else if (product=="Finish")
                {
                    commandFinish = true;
                    break;
                }
                
                
                





            }
            if (commandFinish)
            {

                Console.WriteLine("Congratulations! You bought everything!");
                Console.WriteLine($"{productCounter} items -> {totalMoneySpent:F2}lv spent."
);
            }
            else if (budget<=0)
            {
                
                Console.WriteLine($"Not enough money! You need 0.68lv more.");

                Console.WriteLine($"{productCounter-1} items -> {totalMoneySpent:F2}lv spent.");
            }
        }
    }
}
