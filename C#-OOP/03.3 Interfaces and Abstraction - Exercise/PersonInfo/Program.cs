using PersonInfo.Contracts;
using PersonInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Dictionary<string, List<IBuyer>> dic = new Dictionary<string, List<IBuyer>>();
            
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split();
                string name = parts[0];
                int age = int.Parse(parts[1]);
                if (parts.Length==4)
                {
                    string id = parts[2];
                    string birthDate = parts[3];

                    dic[name].Add(new Citizen(name, age, id, birthDate));
                }
                else
                {
                    string group = parts[2];
                    dic[name].Add(new Rebel(name, age, group));
                }
            }

            while (true)
            {
                string line = Console.ReadLine();
                if (line=="End")
                {

                    break;
                }
                if(dic.ContainsKey(line))
                {
                    continue;
                }
                IBuyer buyer = (IBuyer)dic[line];
                buyer.BuyFood();
                

            }
            var total = dic.Values.Sum(b => b.);
        }
    }
}
