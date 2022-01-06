using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<day>[0-9]{2})(?<separator>.)(?<month>[A-Za-z]{3})\k<separator>(?<year>\d{4})";

            Regex regx = new Regex(pattern);

            string input = Console.ReadLine();

            var matches = regx.Matches(input);

            foreach (Match item in matches)
            {
                //Console.WriteLine(item.Value);
                Console.WriteLine($"Day: {item.Groups["day"]}, Month: {item.Groups["month"]}, Year: {item.Groups["year"]}");
            }
        }
    }
}
