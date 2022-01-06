using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine()); // amount of money Ivan Cho has
            double students = double.Parse(Console.ReadLine()); // count of students
            double priceLightsabers = double.Parse(Console.ReadLine()); // price of lightsabers for a single sabre
            double priceRobes = double.Parse(Console.ReadLine()); // price of robes for a single robe
            double priceBelts = double.Parse(Console.ReadLine()); // price of belts for a single belt

            double beltsSale = 0;

            double totalPrice = 0;

            double students1 = Math.Ceiling((students * 0.1) + students);
            if (students>=6)
                
            {
                beltsSale = students / 6;
            }
            
            totalPrice = (students1 * priceLightsabers) + (priceBelts * (students-beltsSale)) + (students * priceRobes);



            if (totalPrice<=budget)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalPrice-budget:F2}lv more.");
            }


            
        }
    }
}
