using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> filter = text => char.IsUpper(text[0]);
            string[] text = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            var arr = text.Where(filter);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }
    }
}
