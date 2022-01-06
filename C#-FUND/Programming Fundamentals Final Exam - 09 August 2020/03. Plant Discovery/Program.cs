
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace _03._Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dic = new Dictionary<string, List<double>>();
           
            for (int i = 0; i < n; i++)
            {
                string plants = Console.ReadLine();
                string[] splittedPlants = plants.Split("<->");
                string plant = splittedPlants[0];
                int rarity = int.Parse(splittedPlants[1]);
                dic.Add(plant, new List<double>());
                dic[plant].Add(rarity);

            }
            string input = Console.ReadLine();

            while (input != "Exhibition")
            {
                if (input.Contains("Rate") || input.Contains("Update")||input.Contains("Reset"))
                {
                    if (input.Contains("Rate"))
                    {
                        input = input.Remove(0, 6);
                        string[] splittedInput = input.Split(" - ");
                        string plant = splittedInput[0];
                        int rating = int.Parse(splittedInput[1]);

                        if (dic.ContainsKey(plant))
                        {
                            dic[plant].Add(rating);


                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                    }
                    if (input.Contains("Update"))
                    {
                        input = input.Remove(0, 8);
                        string[] splittedInput = input.Split(" - ");
                        string plant = splittedInput[0];
                        int rating = int.Parse(splittedInput[1]);

                        if (dic.ContainsKey(plant))
                        {
                            dic[plant].RemoveAt(0);
                            dic[plant].Insert(0, rating);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }



                    }
                    if (input.Contains("Reset"))
                    {
                        input = input.Remove(0, 7);
                        string[] splittedInput = input.Split(" - ");
                        string plant = splittedInput[0];
                        if (dic.ContainsKey(plant))
                        {
                            dic[plant].RemoveRange(1, dic[plant].Count-1);
                            
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine("error");
                }
                
                
                
               
                input = Console.ReadLine();
            }

            Dictionary<string, List<double>> averageDict = new Dictionary<string, List<double>>();
            foreach (var item in dic)
            {
                double average = 0.0;
                for (int i = 1; i < item.Value.Count; i++)
                {
                    average += item.Value[i];
                }
                if (average > 0)
                {
                    average = average / (item.Value.Count - 1);
                }
                averageDict.Add(item.Key, new List<double> { item.Value[0], average });
            }


            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in averageDict.OrderByDescending(w => w.Value[0]).ThenByDescending(t => t.Value[1]))
            {
                double num = item.Value[1];
                
                
                Console.WriteLine($" - {item.Key}; Rarity: {item.Value[0]}; Rating: {num:F2}");

            }



        }
    }
}
