using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, int>();
            while (true)
            {
                string material = Console.ReadLine();
                
                if (material=="stop")
                {
                    break;
                }
                int quantities = int.Parse(Console.ReadLine());
                if (dic.ContainsKey(material))
                {
                    dic[material] += quantities;
                }
                else
                {
                    dic.Add(material, quantities);
                }
            }
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
