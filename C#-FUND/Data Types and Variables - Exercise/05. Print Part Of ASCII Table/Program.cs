using System;
using System.Threading;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            while (start<=end)
            {
                Console.Write((char)start + " ");
                start++;
            }
            
            
        }
    }
}
