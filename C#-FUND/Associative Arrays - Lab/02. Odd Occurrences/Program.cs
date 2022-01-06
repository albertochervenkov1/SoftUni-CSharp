using System;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().Split();

            var dict = new Dictionary<string, int>();

            foreach (var item in word)
            {
                string wordInLowerCase = item.ToLower();

                if (dict.ContainsKey(wordInLowerCase))
                {
                    dict[wordInLowerCase]++;
                }
                else
                {
                    dict.Add(wordInLowerCase, 1);
                }
            }
            foreach (var item in dict)
            {
                if (item.Value%2!=0)
                {
                    Console.Write($"{item.Key} ");
                }
               
            }
        }
    }
}
