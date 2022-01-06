using System;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, Product>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input=="buy")
                {
                    break;
                }
                string[] splitedInput = input.Split();
                string name = splitedInput[0];
                double price = double.Parse(splitedInput[1]);
                int quantity = int.Parse(splitedInput[2]);

                Product product = new Product(name, price, quantity);

                if (dic.ContainsKey(name))
                {
                    dic[name].Price = price;
                    dic[name].Quantity += quantity;
                }
                else
                {
                    dic.Add(name, product);
                }
            }
            foreach (var item in dic)
            {
                string keym = item.Key;
                double totalPrice = item.Value.Price*item.Value.Quantity;
                Console.WriteLine($"{keym} -> {totalPrice:F2}");
            }

            
        }
    }
    class Product
    {
        string name;
        double price;
        double quantity;

        public Product(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
        public double Price 
        {
            get { return price; }
            set
            {
                price = value;
            }
        }
        public double Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
            }
        }
    }
}
