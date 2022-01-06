using System;

namespace PizzaCalories
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var pizzaName = Console.ReadLine().Split()[1];

            var doughData = Console.ReadLine().Split();
            var flourtype = doughData[1];
            var bakingTechnique = doughData[2];
            var weight = int.Parse(doughData[3]);
            try
            {
                Dough dough = new Dough(flourtype, bakingTechnique, weight);
                Pizza pizza = new Pizza(pizzaName, dough);
                while (true)
                {
                    var line = Console.ReadLine();

                    if (line == "END")
                    {
                        break;
                    }
                    var parts = line.Split();

                    var toppingName = parts[1];
                    var toppingWeight = int.Parse(parts[2]);

                    Topping topping = new Topping(toppingName, toppingWeight);

                    pizza.AddTopping(topping);
                }
                Console.WriteLine($"{pizzaName} - {pizza.GetCalories():f2} Calories.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }

            

            
        }
    }
}
