﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            products = new List<Product>();
        }

        public string Name 
        {
            get => this.name;
            private set 
            {
                Validator.ThrowIfStringIsNullOrEmpty(value, "Name cannot be empty");
                name = value;
            }
        }
        public decimal Money 
        {
            get => this.money;
            private set 
            {
                Validator.ThrowIfValueIsNegative(value, "Money cannot be negative");
                money = value;
            }
        }

        public void AddProduct(Product product)
        {
            if (product.Cost>this.Money)
            {
                throw new InvalidOperationException($"{Name} can't afford {product.Name}");
            }
            else
            {
                products.Add(product);
                Money -= product.Cost;
            }
            
        }
        public override string ToString()
        {
            if (products.Count==0)
            {
                return $"{this.name} - Nothing bought";
            }
            return $"{Name} - {string.Join(", ",products.Select(p=>p.Name))}";

        }
    }
}
