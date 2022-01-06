using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> firstLootBox = new Queue<int>(firstArr);

            int[] secondArr= Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> secondToolBox = new Stack<int>(secondArr);

            List<int> summedItems = new List<int>();
            bool firstEmpty = false;
            bool secondEmpty = false;
            while (true)
            {
                if (firstLootBox.Count<=0||secondToolBox.Count<=0)
                {
                    if (firstLootBox.Count<=0)
                    {
                        firstEmpty = true;
                    }
                    else
                    {
                        secondEmpty = true;
                    }
                    break;
                }
                int firstItem = firstLootBox.Peek();
                int secondItem = secondToolBox.Peek();
                int sum=firstItem+secondItem;
                if (sum%2==0)
                {
                    summedItems.Add(firstLootBox.Dequeue());
                    summedItems.Add(secondToolBox.Pop());
                }
                else
                {
                    firstLootBox.Enqueue(secondToolBox.Pop());
                }
            }

            int sumItems = summedItems.Sum();

            if (firstEmpty==true)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (sumItems>=100)
            {
                Console.WriteLine($"Your loot was epic! Value: {sumItems}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {sumItems}");
            }
            

        }
    }
}
