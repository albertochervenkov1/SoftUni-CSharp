﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> newList = new List<int>();

            if (list1.Count > list2.Count)
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    newList.Add(list1[i]);
                    if (i<list2.Count)
                    {
                        newList.Add(list2[i]);

                    }
                }
            }
            else
            {
                for (int i = 0; i < list2.Count; i++)
                {
                    
                    if (i < list1.Count)
                    {
                        newList.Add(list1[i]);

                    }
                    newList.Add(list2[i]);
                }
            }
            Console.WriteLine(string.Join(" ",newList));

        }
    }
}
