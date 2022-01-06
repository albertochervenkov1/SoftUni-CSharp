using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] length = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = length[0];
            int m = length[1];
            HashSet<int> hash1 = new HashSet<int>();
            HashSet<int> hash2 = new HashSet<int>();

            int z = n + m;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                hash1.Add(num);
            }
            for (int i = 0; i < m; i++)
            {
                int num = int.Parse(Console.ReadLine());
                hash2.Add(num);
            }

            hash1.IntersectWith(hash2);

            Console.WriteLine(string.Join(" ",hash1));
            


            
        }
    }
}
