using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+([+359]+)([- ])2(\2)([0-9]{3})(\2)([0-9]{4})\b";
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            var matches = regex.Matches(input);
            List<string> phoneNumbers = new List<string>();

            foreach (Match item in matches)
            {
                phoneNumbers.Add(item.Value);
            }
            Console.WriteLine(string.Join(", ",phoneNumbers));
        }
    }
}
