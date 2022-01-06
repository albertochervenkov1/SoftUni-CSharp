using System;

namespace _01._Rent
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            int percentComission = int.Parse(Console.ReadLine());
            double priceRent = double.Parse(Console.ReadLine());

            double firstPeriod = 0;
            double secondPeriod = 0;

            if (months%2==0)
            {
                firstPeriod = months / 2;
                secondPeriod = months / 2;



            }
            else
            {
                firstPeriod = (months - 1) / 2;
                secondPeriod = firstPeriod + 1;
            }
            
            
            double rentFP = firstPeriod * priceRent;
            double rentSP = secondPeriod * priceRent;
           
            
             double rentSPSale = priceRent - (priceRent * 0.2);
            double totalSP = rentSPSale * secondPeriod;
            
            double total = totalSP + rentFP;
             double totalBroker = (total * percentComission)/100;
           
            double totaltotal = totalBroker + total;
            Console.WriteLine($"Total: {totaltotal:F2}");
        }
    }
}
