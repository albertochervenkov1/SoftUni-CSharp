using System;

namespace _04._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int a = 0;
            int e = 0;
            int si = 0;
            int o = 0;
            int u = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]=='a')
                {
                    a++;
                }
                if (text[i]=='e')
                {
                    e += 2;
                }
                if (text[i] =='i')
                {
                    si += 3;
                }
                if (text[i] == 'o')
                {
                    o+= 4;
                }
                if (text[i] == '5')
                {
                    u+= 5;
                }
            }
            double totalSum = a + e + si + o + u;
            Console.WriteLine(totalSum);
        }
    }
}
