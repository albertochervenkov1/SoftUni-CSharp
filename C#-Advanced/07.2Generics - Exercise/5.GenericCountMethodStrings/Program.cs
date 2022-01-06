using System;
using System.Collections.Generic;

namespace SwapInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<string>> list = new List<Box<string>>();

            for (int i = 0; i < n; i++)
            {
                Box<string> input = new Box<string>(Console.ReadLine());
                list.Add(input);
            }
            string value = Console.ReadLine();
            Box<string> boxValue = new Box<string>(value);
            GetGreater(list, boxValue);
            Console.WriteLine(GetGreater(list,boxValue));
            
        }
        private static int GetGreater<T>(List<Box<T>> boxes,Box<T> box)
            where T:IComparable
        {
            int count = 0;
            foreach (var item in boxes)
            {
                int compare = item.Value.CompareTo(box.Value);
                if (compare>0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
