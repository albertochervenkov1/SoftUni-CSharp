using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ranges = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int start = ranges[0];
            int end = ranges[1];
            string input = Console.ReadLine();

            Func<int, int, List<int>> func = (s, e) =>
            {
                  List<int> nums = new List<int>();
                  for (int i = s; i <= e; i++)
                  {
                      nums.Add(i);
                  }
                  return nums;
            };

            List<int> numbers = func(start,end);

            Predicate<int> pred = n => true;
            if (input=="odd")
            {
                pred = n => n % 2 == 1;
            }
            else if(input=="even")
            {
                pred = n => n % 2 == 0;
            }

            Console.WriteLine(string.Join(" ",Mywhere(numbers,pred)));

            
        }
        static List<int> Mywhere(List<int> numbers, Predicate<int> pred) 
        {
            List<int> newNumbers = new List<int>();

            foreach (var item in numbers)
            {
                if (pred(item))
                {
                    newNumbers.Add(item);
                }
            }
            return newNumbers;
        }
        
    }
}
