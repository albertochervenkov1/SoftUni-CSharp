using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Flower_Wreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] liliesArr = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(byte.Parse).ToArray();
            Stack<byte> lilies = new Stack<byte>(liliesArr);
            byte[] rosesArr= Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(byte.Parse).ToArray();
            Queue<byte> roses = new Queue<byte>(rosesArr);

            int wreatahCounter = 0;
            int sum = 0;
            int operationsCount = Math.Min(roses.Count(), lilies.Count());
            while (true)
            {
                if (lilies.Count == 0 || roses.Count == 0)
                {
                    break;
                }
                byte currentLilie=lilies.Peek();
                byte currentRose=roses.Peek();
                if (currentLilie+currentRose==15)
                {
                    wreatahCounter++;
                    lilies.Pop();
                    roses.Dequeue();
                }
                else if (currentLilie+currentRose>15)
                {
                    lilies.Pop();
                    currentLilie -= 2;
                    lilies.Push(currentLilie);
                }
                else if (currentLilie+currentRose<15)
                {
                    sum += currentLilie + currentRose;
                    lilies.Pop();
                    roses.Dequeue();
                }
            }
            while (sum>=15)
            {
                if (sum>=15)
                {
                    wreatahCounter++;
                    sum -= 15;
                }
            }

            if (wreatahCounter>=5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreatahCounter} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5-wreatahCounter} wreaths more!");
            }
            
        }
    }
}
