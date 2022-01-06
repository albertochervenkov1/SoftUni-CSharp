using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            String text = Console.ReadLine();

            List<int> nums = new List<int>();
            List<char> letters = new List<char>();
            List<char> chars = new List<char>();

            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];

                if (char.IsDigit(ch))
                {
                    nums.Add(ch);
                    text.Remove(ch);
                }
                else if (char.IsLetter(ch))
                {
                    letters.Add(ch);
                    text.Remove(ch);
                }
                else if (!char.IsLetterOrDigit(ch))
                {
                    chars.Add(ch);
                }
                
            }
            Console.WriteLine(string.Join("",nums));
            Console.WriteLine(string.Join("",letters));
            Console.WriteLine(text);
        }
    }
}
