using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double people = double.Parse(Console.ReadLine());
            string typeofgroup= Console.ReadLine();
            string day = Console.ReadLine();
            double totalprice = 0;
            double discount = 0;

            double price = 0;

            switch (day)
            {
                case "Friday":
                    if (typeofgroup=="Students")
                    {
                        price = 8.45*people;
                        totalprice = price;

                    }
                    else if (typeofgroup=="Business")
                    {
                        price = 10.90*people;
                        totalprice = price;

                    }
                    else if (typeofgroup=="Regular")
                    {
                        price = 15*people;
                        totalprice = price;
                    }
                    break;
                case "Saturday":
                    if (typeofgroup == "Students")
                    {
                        price = 9.80*people;
                        totalprice = price;

                    }
                    else if (typeofgroup == "Business")
                    {
                        price = 15.60*people;
                        totalprice = price;

                    }
                    else if (typeofgroup == "Regular")
                    {
                        price = 20*people;
                        totalprice = price;
                    }
                    break;
                case "Sunday":
                    if (typeofgroup == "Students")
                    {
                        price = 10.46*people;
                        totalprice = price;

                    }
                    else if (typeofgroup == "Business")
                    {
                        price = 16*people;
                        totalprice = price;

                    }
                    else if (typeofgroup == "Regular")
                    {
                        price = 22.50*people;
                        totalprice = price;
                    }
                    break;


                default:
                    break;
            }
            

            switch (typeofgroup)
            {
                case "Students":
                    if (people>=30)
                    {
                        discount = price * 15 / 100;
                        totalprice = price - discount;
                    }
                    break;
                case "Business":
                    if (people>=100)
                    {
                        double totprice = people * price;
                        double pricefor10 = price * 10;
                        totalprice = totprice - pricefor10
                        ;

                    }
                    break;
                case "Regular":
                    if (people>=10&&people<=20)
                    {
                        discount = price * 5 / 100;
                        totalprice = price - discount;
                    }
                    break;

                default:
                    break;
            }

            Console.WriteLine($"Total price: {totalprice:F2}");




        }
    }
}
