using System;
using System.Linq;

namespace _01._Sort_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            arr = arr.Where(x => x % 2 == 0).OrderBy(x=>x).ToArray();
            Console.WriteLine(string.Join(", ",arr));
        }
    }
}
