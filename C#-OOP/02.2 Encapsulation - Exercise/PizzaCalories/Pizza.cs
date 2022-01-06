using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private const int minName = 1;
        private const int maxName = 15;
        private Dough dough;
        private List<Topping> toppings;


        public Pizza(string name,Dough dough)
        {
            this.Name = name;
            this.dough = dough;
            this.toppings = new List<Topping>();
        }
        public string Name 
        {
            get => this.name;
            private set 
            {
                if (value.Length < minName || value.Length > maxName)
                {
                    throw new ArgumentException($"Pizza name should be between {minName} and {maxName} symbols.");
                }
                this.name = value;
            }
        }

        

        public void AddTopping(Topping topping) 
        {
            if (toppings.Count==10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            toppings.Add(topping);
        }

        public double GetCalories() 
        {
            return this.dough.GetCalories() + this.toppings.Sum(c => c.GetCalories());
        }
    }
}
