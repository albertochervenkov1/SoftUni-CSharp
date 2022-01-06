using System;
using System.Linq;
using System.Security.Cryptography;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                while ((i + 1 < text.Length) && (text[i] == text[i + 1]))
                {
                    text = text.Remove(i + 1, 1);

                }
            }

            Console.WriteLine(text);
        }
    }
}
