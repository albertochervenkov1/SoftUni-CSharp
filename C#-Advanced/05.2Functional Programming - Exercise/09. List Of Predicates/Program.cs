using System;
using System.Collections.Generic;
using System.Linq;
namespace _0.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            List<int> deviders = Console.ReadLine().Split().Select(int.Parse).ToList();


            Func<int, int, bool> predicate = (num, d) => num % d == 0;
            for (int i = 1; i <= range; i++)
            {
                if (deviders.All(d => predicate(i, d)))
                {
                    Console.Write(i + " ");
                }
            }




        }

       
        
    }
}
