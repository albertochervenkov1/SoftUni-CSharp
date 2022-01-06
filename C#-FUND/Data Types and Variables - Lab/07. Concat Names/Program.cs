using System;

namespace _07._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string stName = Console.ReadLine();
            string ndName = Console.ReadLine();
            string delimiter = Console.ReadLine();

            Console.WriteLine($"{stName}{delimiter}{ndName}");
        }
    }
}
