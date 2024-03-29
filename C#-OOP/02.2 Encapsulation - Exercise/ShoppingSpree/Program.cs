﻿using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class Program
    {
        public static void Main(string[] args)
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

                var personName = parts[0];
                var productName = parts[1];

                var person = people[personName];
                var product = products[productName];
                
                try
                {
                    person.AddProduct(product);
                    Console.WriteLine($"{personName} bought {productName}");
                }
                catch (InvalidOperationException ex)
                {

                    Console.WriteLine(ex.Message);
                }

                
            }
            foreach (var person in people.Values)
            {
                Console.WriteLine(person);
            }
        }
        private static Dictionary<string, Person> ReadPeople() 
        {
            var result = new Dictionary<string, Person>();
            var parts = Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in parts)
            {
                var perosnData = item.Split('=', StringSplitOptions.RemoveEmptyEntries);
                var name = perosnData[0];
                var money = decimal.Parse(perosnData[1]);
                result[name] = new Person(name, money);
            }
            return result;
        }
        private static Dictionary<string, Product> ReadProducts() 
        {
            var result = new Dictionary<string, Product>();
            var parts = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in parts)
            {
                var productData = item.Split('=', StringSplitOptions.RemoveEmptyEntries);
                var name = productData[0];
                var cost = decimal.Parse(productData[1]);
                result[name] = new Product(name, cost);
            }
            return result;
        }
    }
}
