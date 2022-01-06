using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var parking = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                List<string> list = Console.ReadLine().Split().ToList();

                string info = list[0];
                string username = list[1];
                

                if (info=="register")
                {
                    string number = list[2];
                    if (parking.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {number}");
                    }
                    else
                    {
                        parking.Add(username, number);
                        Console.WriteLine($"{username} registered {number} successfully");
                    }
                }
                else if (info=="unregister")
                {
                    if (parking.ContainsKey(username))
                    {
                        parking.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }
            foreach (var item in parking)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
