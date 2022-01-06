using System;

namespace _03._Wedding_Investment
{
    class Program
    {
        static void Main(string[] args)
        {
            string contractTime = Console.ReadLine();
            string typeContract = Console.ReadLine();
            string dessert = Console.ReadLine();
            int numMonths = int.Parse(Console.ReadLine());

            double priceperMonth = 0;


            switch (contractTime)
            {
                case"one":
                    if (typeContract=="Small")
                    {
                        priceperMonth = 9.98;
                        
                    }
                    
                    else if (typeContract=="Middle")
                    {
                        priceperMonth = 18.99;

                    }
                    else if (typeContract=="Large")
                    {
                        priceperMonth = 25.98;
                        
                    }
                    else if (typeContract=="ExtraLarge")
                    {
                        priceperMonth = 35.99;
                        
                    }
                    break;
                case "two":
                    if (typeContract == "Small")
                    {
                        priceperMonth = 8.58;

                    }

                    else if (typeContract == "Middle")
                    {
                        priceperMonth = 17.09;

                    }
                    else if (typeContract == "Large")
                    {
                        priceperMonth = 23.59;

                    }
                    else if (typeContract == "ExtraLarge")
                    {
                        priceperMonth = 31.79;

                    }
                    break;


                default:
                    break;
            }
            if (dessert=="yes")
            {
                if (priceperMonth<=10.00)
                {
                    priceperMonth += 5.50;
                }
                else if (priceperMonth<=30.00)
                {
                    priceperMonth += 4.35;
                }
                else if (priceperMonth>30.00)
                {
                    priceperMonth += 3.85;
                }
            }

            double totalSum = numMonths * priceperMonth;
            if (contractTime=="two")
            {
                double sale = totalSum * 0.0375;
                totalSum -= sale;
            }
            Console.WriteLine($"{totalSum:F2} lv.");

        }
    }
}
