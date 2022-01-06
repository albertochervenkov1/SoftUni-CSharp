using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private const int minWeight= 1;
        private const int maxweight = 50;
        private string name;
        private int weight;

        public Topping(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name
        {
            get => this.name;
            private set 
            {
                var valueAsLower = value.ToLower();
                if (valueAsLower != "meat" && valueAsLower != "veggies" && valueAsLower != "cheese" && valueAsLower != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.name = value;
            }
        }
        public int Weight 
        {
            get => this.weight;
            private set 
            {
                if (value<minWeight||value>maxweight)
                {
                    throw new ArgumentException($"{Name} weight should be in the range [{minWeight}..{maxweight}].");
                }
                this.weight = value;
            }
        }
        public double GetCalories()
        {
            var modifier = GetModifier();
            return Weight *2 * modifier;
        }

        private double GetModifier()
        {
            var toppingToLower = name.ToLower();
            if (toppingToLower=="meat")
            {
                return 1.2;
            }
            else if (toppingToLower=="veggies")
            {
                return 0.8;
            }
            else if (toppingToLower=="cheese")
            {
                return 1.1;
            }
            return 0.9;
        }
    }
}
