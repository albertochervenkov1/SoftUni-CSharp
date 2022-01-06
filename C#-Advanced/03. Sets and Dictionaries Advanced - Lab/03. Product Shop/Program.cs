using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> dic = new SortedDictionary<string, Dictionary<string, double>>();

            string[] command = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
            while (command[0]!="Revision")
            {
                string shop = command[0];
                string product = command[1];
                double price = double.Parse(command[2]);

                if (dic.ContainsKey(shop))
                {
                    dic[shop].Add(product, price);
                }
                else
                {
                    dic.Add(shop, new Dictionary<string, double>());
                    dic[shop].Add(product, price);
                }

                command = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
            }
           
           
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var val in item.Value)
                {
                    Console.WriteLine($"Product: {val.Key}, Price: {(val.Value)}");

                }
            }
        }
    }
}
