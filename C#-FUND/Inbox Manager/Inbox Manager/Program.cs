using System;
using System.Collections.Generic;
using System.Linq;

namespace Inbox_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var dic = new Dictionary<string, List<string>>();
            int usersCount = 0;
            while (input!="Statistics")
            {
                string[] splittedInput = input.Split("->",StringSplitOptions.RemoveEmptyEntries);
                string username = splittedInput[1];

                if (input.Contains("Add"))
                {
                    if (dic.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} is already registered");
                    }
                    else
                    {
                        dic.Add(username, new List<string>());
                        usersCount++;

                    }
                }
                if (input.Contains("Send"))
                {
                    string email = splittedInput[2];
                    dic[username].Add(email);
                }
                if (input.Contains("Delete"))
                {
                    if (dic.ContainsKey(username))
                    {
                        dic.Remove(username);
                        usersCount--;
                    }
                    else
                    {
                        Console.WriteLine($"{username} not found!");
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Users count: {usersCount}");

            foreach (var item in dic.OrderByDescending(n => n.Value.Count).ThenBy(n => n.Key))
            {
                Console.WriteLine(item.Key);
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine($" - {item.Value[i]}");
                }
            }
        }
    }
}
