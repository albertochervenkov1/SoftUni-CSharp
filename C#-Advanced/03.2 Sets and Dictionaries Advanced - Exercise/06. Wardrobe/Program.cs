using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new[] {" -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];
                string[] allClothing = input.Skip(1).ToArray(); 
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                    
                }
                Dictionary<string, int> currentClothing = wardrobe[color];
                foreach (var item in allClothing)
                {
                    
                    if (!currentClothing.ContainsKey(item))
                    {
                        currentClothing.Add(item, 0);
                    }
                    currentClothing[item]++;
                }
            }
            string[] searchData = Console.ReadLine().Split();

            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var val in item.Value)
                {
                    if (searchData[0]==item.Key&&searchData[1]==val.Key)
                    {
                        Console.WriteLine($"* {val.Key} - {val.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {val.Key} - {val.Value}");
                    }
                }
            }
        }
    }
}
