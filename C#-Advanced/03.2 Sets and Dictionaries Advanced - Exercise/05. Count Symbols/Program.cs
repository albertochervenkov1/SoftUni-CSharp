using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            SortedDictionary<char, int> dic = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char charachter = text[i];
                if (dic.ContainsKey(charachter))
                {
                    dic[charachter]++;
                }
                else
                {
                    dic.Add(charachter, 1);
                }
            }
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
