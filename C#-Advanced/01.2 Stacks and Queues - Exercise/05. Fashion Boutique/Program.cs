using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> clothes = new Stack<int>(arr);

            int boxCapacity = int.Parse(Console.ReadLine());
            int currentRackCapacity = boxCapacity;
            int racksCount = 1;

            while (clothes.Any())
            {
                int clothesToRemove = clothes.Pop();
                currentRackCapacity -= clothesToRemove;

                if (currentRackCapacity<0)
                {
                    racksCount++;
                    currentRackCapacity = boxCapacity - clothesToRemove;
                }
            }
            Console.WriteLine(racksCount);
            



        }
    }
}
