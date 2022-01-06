using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(repeat(text, n));
        }
        static string repeat(string text, int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += text;
            }
            return result;

        }
    }
}
