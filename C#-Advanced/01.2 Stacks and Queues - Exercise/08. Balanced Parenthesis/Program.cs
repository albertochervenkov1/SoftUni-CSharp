using System;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> open = new Stack<char>();

            string input = Console.ReadLine();
            bool isValid = true;
            foreach (var item in input)
            {
                if (item=='('||item=='{'||item=='[')
                {
                    open.Push(item);
                }
                else
                {
                    bool isFirstValid = item == ')' && open.Pop()=='(';
                    bool isFirstValid2 = item == '}' && open.Pop() == '{';
                    bool isFirstValid3 = item == ']' && open.Pop() == '[';
                    if (!isFirstValid&&!isFirstValid2&&!isFirstValid3)
                    {
                        isValid = false;
                        break;
                    }
                }
            }
            if (isValid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
