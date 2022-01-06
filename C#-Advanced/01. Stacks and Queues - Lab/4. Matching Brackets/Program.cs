using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var expression = Console.ReadLine();
            Stack<int> st = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i]=='(')
                {
                    st.Push(i);
                }
                else if (expression[i]==')')
                {
                    int startIndex = st.Pop();
                    Console.WriteLine(expression.Substring(startIndex, i-startIndex+1));
                }
            }
        }
    }
}
