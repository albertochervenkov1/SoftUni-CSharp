using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\', StringSplitOptions.RemoveEmptyEntries);

            string name = input[input.Length-1];
            string[] splittedName = name.Split(".");
            string fileType = splittedName[1];

            Console.WriteLine($"File name: {splittedName[0]}");
            Console.WriteLine($"File extension: {splittedName[1]}");
        }
    }
}
