﻿
using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> hash = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                hash.Add(input);
            }
            foreach (var item in hash)
            {
                Console.WriteLine(item);
            }
        }
    }
}
