using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string pattern = @"(={1}|\/{1})(?<cityName>[A-Z][a-z]{2,})\1";
            string input = Console.ReadLine();
            int points = 0;
            MatchCollection mtchs = Regex.Matches(input, pattern);
            var list = mtchs.ToList();

            var matches = new List<string>();
            
            for (int i = 0; i < list.Count; i++)
            {
                string tempString = list[i].ToString();

                tempString = tempString.Trim(new char[] { '=', '/' });
                matches.Add(tempString);

                points += tempString.Length;
            }
            if (mtchs.Count>0)
            {
                Console.Write($"Destinations: " + string.Join(", ",matches));
            }
            else
            {
                Console.Write("Destinations:");
            }

            Console.WriteLine();
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}
