using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var company = new SortedDictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input=="End")
                {
                    break;

                }
                string name = input.Split(" -> ")[0];
                string id= input.Split(" -> ")[1];

                if (company.ContainsKey(name))
                {
                    List<string> ids = company[name];
                    if (!ids.Contains(id))
                    {
                        company[name].Add(id);
                    }
                }
                else
                {
                    company.Add(name, new List<string>());
                    company[name].Add(id);
                }
            }
            foreach (var item in company)
            {
                Console.WriteLine(item.Key);
                foreach (var id in item.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
