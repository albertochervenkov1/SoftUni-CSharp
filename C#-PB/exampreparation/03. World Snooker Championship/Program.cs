using System;

namespace _03._World_Snooker_Championship
{
    class Program
    {
        static void Main(string[] args)
        {
            string stage = Console.ReadLine();
            string typeOfTickets = Console.ReadLine();
            int numOfTickets = int.Parse(Console.ReadLine());
            char photo = char.Parse(Console.ReadLine());

            double pricetotalTickets = 0;
            double priceForPhoto = 40;

            switch (stage)
            {
                case "Quarter final":
                    if (typeOfTickets=="Standart")
                    {
                        pricetotalTickets = 55.50 * numOfTickets;
                    }
                    
                    else if (typeOfTickets == "Premium")
                    {
                        pricetotalTickets = 105.20 * numOfTickets;
                    }
                    else if (typeOfTickets == "VIP")
                    {
                        pricetotalTickets = 118.90 * numOfTickets;
                    }
                    break;
                case "Semi final":
                    if (typeOfTickets == "Standart")
                    {
                        pricetotalTickets = 75.88 * numOfTickets;
                    }

                    else if (typeOfTickets == "Premium")
                    {
                        pricetotalTickets = 125.22 * numOfTickets;
                    }
                    else if (typeOfTickets == "VIP")
                    {
                        pricetotalTickets = 300.40 * numOfTickets;
                    }
                    break;
                case "Final":
                    if (typeOfTickets == "Standart")
                    {
                        pricetotalTickets = 110.10 * numOfTickets;
                    }

                    else if (typeOfTickets == "Premium")
                    {
                        pricetotalTickets = 160.66 * numOfTickets;
                    }
                    else if (typeOfTickets == "VIP")
                    {
                        pricetotalTickets = 400 * numOfTickets;
                    }
                    break;
                default:
                    break;
            }
            if (pricetotalTickets>4000)
            {
                double otstupka = pricetotalTickets * 25 / 100;
                double priceWithSale = pricetotalTickets - otstupka;
                priceForPhoto = 0;
                Console.WriteLine($"{priceWithSale:F2}");
            }
            else if (pricetotalTickets>2500)
            {
                double otstupka = pricetotalTickets * 10 / 100;
                double priceWithSale = pricetotalTickets - otstupka;
                
                if (photo=='Y')
                {
                    priceForPhoto *= numOfTickets;
                }
                else
                {
                    priceForPhoto = 0;
                }
               
                double totatalPrice = priceWithSale + priceForPhoto;
                Console.WriteLine($"{totatalPrice:F2}");
            }
            else if(pricetotalTickets<=2500)
            {
                if (photo == 'Y')
                {
                    priceForPhoto *= numOfTickets;
                }
                else
                {
                    priceForPhoto = 0;
                }
                double totalprice = pricetotalTickets + priceForPhoto;
                Console.WriteLine($"{totalprice:F2}");
            }
           
            

        }
    }
}
