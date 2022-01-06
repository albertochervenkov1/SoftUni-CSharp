using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> evenNumbersList = new List<int>();
            Queue<int> evenNumbers = new Queue<int>(arr);

            while (evenNumbers.Count>0)
            {
                int num = evenNumbers.Peek();
                if (num%2!=0)
                {
                    evenNumbers.Dequeue();
                }
                else
                {
                    evenNumbers.Dequeue();
                    evenNumbersList.Add(num);
                }
                
            }
            Console.Write(string.Join(", ", evenNumbersList));

        }
    }
}
