using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, IBuyer> buyersByName = new Dictionary<string, IBuyer>();
           
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split();
                if (parts.Length == 4)
                {
                    string name = parts[0];
                    int age = int.Parse(parts[1]);
                    string id = parts[2];
                    string birthDate = parts[3];
                    buyersByName[name] = new Citizen(name, age, id, birthDate);
                }
                else if (parts.Length==3)
                {
                    string name = parts[0];
                    int age = int.Parse(parts[1]);
                    string group = parts[2];
                    buyersByName[name] = new Rebel(name, age, group);
                }
            }
            while (true)
            {
                string command = Console.ReadLine();

                if (command=="End")
                {
                    break;
                }
                if (!buyersByName.ContainsKey(command))
                {
                    continue;
                }
                IBuyer buyer = buyersByName[command];
                buyer.BuyFood();

            }

            var sum = buyersByName.Values.Sum(b => b.Food);
            Console.WriteLine(sum);
            
            
            
        }
    }
}
