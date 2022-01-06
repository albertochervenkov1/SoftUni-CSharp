using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> words = Console.ReadLine().Split().ToList();
            string words = Console.ReadLine();

            var dic = new Dictionary<char, int>();

            for (int i = 0; i < words.Length; i++)
            {
                char symbol = words[i];
                if (symbol==' ')
                {
                    continue;
                }

                if (dic.ContainsKey(symbol))
                {
                    dic[symbol]++;
                }
                else
                {
                    dic.Add(symbol, 1);
                }
            }
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
