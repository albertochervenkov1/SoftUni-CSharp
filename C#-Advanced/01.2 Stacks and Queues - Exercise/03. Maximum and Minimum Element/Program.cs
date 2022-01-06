using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> st = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int command = nums[0];
                int num = 0;
                if (nums.Length>1)
                {
                     num=nums[1];

                }
               
                if (command==1)
                {
                    st.Push(num);
                }
                if (st.Any())
                {
                    if (command == 2)
                    {
                        st.Pop();
                    }
                    else if (command == 3)
                    {
                        Console.WriteLine(st.Max());
                    }
                    else if (command == 4)
                    {
                        Console.WriteLine(st.Min());
                    }
                }
                
            }
            Console.WriteLine(string.Join(", ",st));
        }
    }
}
