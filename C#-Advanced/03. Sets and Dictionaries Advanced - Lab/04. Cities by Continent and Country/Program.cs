using System;
using System.Collections.Generic;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> dic = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!dic.ContainsKey(continent))
                {

                    dic.Add(continent, new Dictionary<string, List<string>>());
                    dic[continent].Add(country, new List<string>());
                    dic[continent][country].Add(city);
                }
                else if (!dic[continent].ContainsKey(country))
                {
                    dic[continent].Add(country, new List<string>());
                    dic[continent][country].Add(city);
                }
                else
                {
                    dic[continent][country].Add(city);

                    
                }
                
            }
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var val in item.Value)
                {
                    Console.Write($"  {val.Key} -> ");
                    Console.Write(string.Join(", ",val.Value));
                    Console.WriteLine();
                }
            }
        }

        
    }
}
