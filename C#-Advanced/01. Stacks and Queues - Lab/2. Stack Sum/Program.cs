using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> st = new Stack<int>(nums);
            string input = Console.ReadLine().ToLower();
            while (input!="end")
            {
                string[] splitted = input.Split();
                if (splitted[0]=="add")
                {
                    int firstNum = int.Parse(splitted[1]);
                    int secondNum = int.Parse(splitted[2]);
                    st.Push(firstNum);
                    st.Push(secondNum);
                }
                else if (splitted[0]=="remove")
                {
                    int num = int.Parse(splitted[1]);
                    if (st.Count>=num)
                    {
                        for (int i = 0; i < num; i++)
                        {
                            st.Pop();
                        }
                    }
                }
                input = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Sum: {st.Sum()}");
        }
    }
}
