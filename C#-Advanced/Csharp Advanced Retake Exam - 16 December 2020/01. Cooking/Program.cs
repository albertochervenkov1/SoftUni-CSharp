using System;
using System.Collections.Generic;
using System.Linq;

namespace Cooking
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] liquidsArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> liquids = new Queue<int>(liquidsArr);

            int[] ingridientsArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> ingridients = new Stack<int>(ingridientsArr);

            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("Bread", 0);
            dic.Add("Cake", 0);
            dic.Add("Pastry", 0);
            dic.Add("Fruit Pie", 0);

            while (true)
            {
                if (ingridients.Count == 0||liquids.Count==0)
                {
                    break;
                }
              
                
                int currLiquid = liquids.Peek();
                int currIngridient = ingridients.Peek();

                if (currLiquid + currIngridient == 25)
                {
                    if (dic.ContainsKey("Bread"))
                    {
                        dic["Bread"]++;
                    }
                    
                    liquids.Dequeue();
                    ingridients.Pop();
                }
                else if (currLiquid + currIngridient == 50)
                {

                    if (dic.ContainsKey("Cake"))
                    {
                        dic["Cake"]++;
                    }
                    
                    liquids.Dequeue();
                    ingridients.Pop();
                }
                else if (currLiquid + currIngridient == 75)
                {

                    if (dic.ContainsKey("Pastry"))
                    {
                        dic["Pastry"]++;
                    }
                    
                    liquids.Dequeue();
                    ingridients.Pop();
                }
                else if (currLiquid + currIngridient == 100)
                {

                    if (dic.ContainsKey("Fruit Pie"))
                    {
                        dic["Fruit Pie"]++;
                    }
                    
                    liquids.Dequeue();
                    ingridients.Pop();
                }
                else
                {
                    liquids.Dequeue();
                    ingridients.Pop();
                    ingridients.Push(currIngridient += 3);
                    

                }

            }
            if (!dic.ContainsValue(0))
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquids.Count>0)
            {
                Console.WriteLine($"Liquids left: "+ string.Join(", ", liquids));
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (ingridients.Count>0)
            {
                Console.WriteLine($"Ingredients left: "+ string.Join(", ",ingridients));
            }
            else
            {
                Console.WriteLine("Ingredients left: none");
            }

            var newDic = dic.OrderBy(k => k.Key);
            foreach (var item in newDic)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}