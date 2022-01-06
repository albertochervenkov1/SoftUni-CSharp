using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine();
            word = word.ToLower();

            string exp = Console.ReadLine();

            int index = exp.IndexOf(word);

            while (index>=0)
            {
                exp = exp.Remove(index, word.Length);
                index = exp.IndexOf(word);
            }
            Console.WriteLine(exp);
            

        }
    }
}
