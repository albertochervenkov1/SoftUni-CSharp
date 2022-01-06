using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engineList = new List<Engine>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                string power =(input[1]);
                if (input.Length==2)
                {
                    engineList.Add(new Engine(model, power));
                }
                else if (input.Length==3)
                {
                    int displacement;
                    bool isDisplacement = int.TryParse(input[2], out displacement);
                    if (isDisplacement)
                    {
                        engineList.Add(new Engine(model, power, displacement));
                    }
                    else
                    {
                        string efficiency = input[2];
                        engineList.Add(new Engine(model, power, efficiency));
                    }
                }
                else if (input.Length==4)
                {
                    int displacement = int.Parse(input[2]);
                    string efficiency = input[3];
                    engineList.Add(new Engine(model, power, displacement, efficiency));
                }

            }

            int m = int.Parse(Console.ReadLine());
            List<Car> carList = new List<Car>();
            for (int i = 0; i < m; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[0];
                string engineModel = tokens[1];
                Engine engine = new Engine(null, null);

                foreach (Engine eng in engineList)
                {
                    if (eng.Model == engineModel)
                    {
                        engine = eng;
                    }
                }

                if (tokens.Length == 2)
                {
                    carList.Add(new Car(model, engine));
                }
                else if (tokens.Length == 3)
                {
                    int weight;
                    bool isWeight = int.TryParse(tokens[2], out weight);
                    if (isWeight)
                    {
                        carList.Add(new Car(model, engine, weight));
                    }
                    else
                    {
                        string color = tokens[2];
                        carList.Add(new Car(model, engine, color));
                    }
                }
                else if (tokens.Length == 4)
                {
                    int weight = int.Parse(tokens[2]);
                    string color = tokens[3];
                    carList.Add(new Car(model, engine, weight, color));
                }
            }

            foreach (Car item in carList)
            {
                Console.WriteLine($"{item.Model}:");
                Console.WriteLine($"  {item.Engine.Model}:");
                Console.WriteLine($"    Power: {item.Engine.Power}");
                Console.WriteLine("    Displacement: {0}", item.Engine.Displacement == 0 ? "n/a" : item.Engine.Displacement.ToString());
                Console.WriteLine("    Efficiency: {0}", item.Engine.Efficiency);
                Console.WriteLine("  Weight: {0}", item.Weight == 0 ? "n/a" :item.Weight.ToString());
                Console.WriteLine("  Color: {0}", item.Color);
            }
        }
    }
}
