using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            Regex regex = new Regex(patern);
            string input = Console.ReadLine();

            var matches = regex.Matches(input);

            foreach (Match item in matches)
            {
                Console.Write(item.Value + " ");
            }
        }
    }
}
