using System;
using System.Collections.Generic;
using System.Linq;
namespace _0.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();
            var newNames = names.Where(name => name.Length <= n).ToList();
            Action<List<string>> print = names => Console.WriteLine(string.Join(Environment.NewLine, names));
            print(newNames);




        }
       
    }
}

