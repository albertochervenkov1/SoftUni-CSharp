using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private const int nameMinLength= 1;
        private const int nameMaxLength= 15;
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name,Dough dough)
        {
            Name = name;
            this.dough = dough;
            toppings = new List<Topping>();
        }

        public string Name 
        {
            get => this.name;
            private set 
            {
                if (value.Length<nameMinLength||value.Length>nameMaxLength)
                {
                    throw new ArgumentException($"Pizza name should be between {nameMinLength} and {nameMaxLength} symbols.");
                }
                name = value;
            }
        }
        public void AddTopping(Topping topping)
        {
            if (toppings.Count==10)
            {
                throw new InvalidOperationException("Number of toppings should be in range [0..10].");
            }
            toppings.Add(topping);
        }

        public double GetCalories()
        {
            return dough.GetCalories() + toppings.Sum(t => t.GetCalories());
        }
    }
}
