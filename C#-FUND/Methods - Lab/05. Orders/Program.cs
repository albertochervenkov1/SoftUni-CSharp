using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            calculations(product, quantity);

        }
        
        static void calculations(string product, int quantity)
        {
            double totalPrice = 0;
            switch (product)
            {
                case "water":
                    totalPrice = 1.00 * quantity;
                    break;
                case "coke":
                    totalPrice = 1.40 * quantity;
                    break;
                case "coffee":
                    totalPrice = 1.50 * quantity;
                    break;
                case "snacks":
                    totalPrice = 2.00 * quantity;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
