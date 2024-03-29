﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            
            Stack<string> expression = new Stack<string>(input.Reverse());
            while (expression.Count>1)
            {
                int leftNum = int.Parse(expression.Pop());
                string sign = expression.Pop();
                int rightNum = int.Parse(expression.Pop());

                if (sign=="+")
                {
                    expression.Push((leftNum + rightNum).ToString());
                }
                else if (sign=="-")
                {
                    expression.Push((leftNum - rightNum).ToString());
                }
            }
            Console.WriteLine(expression.Pop());
        }
    }
}
