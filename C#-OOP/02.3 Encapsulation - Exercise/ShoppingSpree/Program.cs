﻿using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            var people = new Dictionary<string, Person>();
            var products = new Dictionary<string, Product>();
            try
            {
                people = ReadPeople();
                products = ReadProducts();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            
            while (true)
            {
                
                var line = Console.ReadLine();
                if (line=="END")
                {
                    break;
                }
                var parts = line.Split();
                var name = parts[0];
                var productName = parts[1];

                var person = people[name];
                var product = products[productName];
                try
                {
                    person.AddProduct(product);
                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);                  
                }

                
            }
            foreach (var item in people.Values)
            {
                Console.WriteLine(item);
            }
        }

        private static Dictionary<string,Product> ReadProducts()
        {
            var result=new Dictionary<string, Product>();
            var parts = Console.ReadLine().Split(";",StringSplitOptions.RemoveEmptyEntries);

            foreach (var part in parts)
            {
                var productData = part.Split("=", StringSplitOptions.RemoveEmptyEntries);
                var productName = productData[0];
                var cost = decimal.Parse(productData[1]);
                result[productName] = new Product(productName, cost);
            }
            return result;
        }

        private static Dictionary<string,Person> ReadPeople()
        {
            var result = new Dictionary<string,Person>();
            var parts = Console.ReadLine().Split(";",StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in parts)
            {
                var personData = item.Split("=", StringSplitOptions.RemoveEmptyEntries);
                var personName = personData[0];
                decimal money = decimal.Parse(personData[1]);
                result[personName] = new Person(personName, money);
            }
            return result;
        }
    }
}
