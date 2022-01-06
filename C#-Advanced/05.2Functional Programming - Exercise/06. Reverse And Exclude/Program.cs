using System;
using System.Collections.Generic;
using System.Linq;
namespace _0.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            numbers.Reverse();
            numbers = numbers.Where(num => num % n != 0).ToList();

            Action<List<int>> print = n => Console.WriteLine(string.Join(" ", n));
            print(numbers);


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
