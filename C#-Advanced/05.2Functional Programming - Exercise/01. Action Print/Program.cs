using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            var list = names.Select(names => names).ToList();

            Action<List<string>> printNames = n => Console.WriteLine(string.Join(Environment.NewLine, n));
            printNames(list);

            //foreach (var item in names)
            //{
            //    Console.WriteLine("Sir " + item);
            //}
        }
    }
}