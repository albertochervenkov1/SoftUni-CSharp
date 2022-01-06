using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Console.WriteLine(arr.Count());
            Console.WriteLine(arr.Sum());
        }
    }
}
