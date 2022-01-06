using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Nikulden_s_meals
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string command = Console.ReadLine();
            var dic = new Dictionary<string, List<string>>();
            short unlikedMeals = 0;

            while (command!="Stop")
            {
                if (command.Contains("Like"))
                {
                    string[] splitted = command.Split("-",StringSplitOptions.RemoveEmptyEntries);
                    string guest = splitted[1];
                    string meal = splitted[2];
                    if (dic.ContainsKey(guest))
                    {
                        if (dic[guest].Contains(meal))
                        {
                            
                        }
                        else
                        {
                            dic[guest].Add(meal);
                        }
                    }
                    else
                    {
                        dic.Add(guest, new List<string>());
                        dic[guest].Add(meal);
                    }
                }
                else if (command.Contains("Unlike"))
                {
                    string[] splitted = command.Split("-");
                    string guest = splitted[1];
                    string meal = splitted[2];

                    if (dic.ContainsKey(guest))
                    {
                        if (dic[guest].Contains(meal))
                        {
                            dic[guest].Remove(meal);
                            Console.WriteLine($"{guest} doesn't like the {meal}.");
                            unlikedMeals++;
                        }
                        else
                        {
                            Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                            
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                        
                    }
                }
                command = Console.ReadLine();
            }
            //dic.OrderByDescending(k => k.Value.Count).ThenBy(k => k.Key);
            foreach (var item in dic.OrderByDescending(n => n.Value.Count).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{item.Key}: {string.Join(", ",item.Value)}");
            }
            Console.WriteLine($"Unliked meals: {unlikedMeals}");
        }
    }
}
