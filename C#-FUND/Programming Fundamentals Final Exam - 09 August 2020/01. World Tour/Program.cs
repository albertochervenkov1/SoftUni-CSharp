using System;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input = Console.ReadLine();
            while (input!="Travel")
            {
                
                if (input.Contains("Add Stop"))
                {
                    string[] splittedInput = input.Split(":");
                    int index = int.Parse(splittedInput[1]);
                    string str = splittedInput[2];
                    if (text.Length>index)
                    {
                        text = text.Insert(index, str);
                        
                    }
                    Console.WriteLine(text);
                }
                if (input.Contains("Remove"))
                {
                    string[] splittedInput = input.Split(":");
                    int startIndex = int.Parse(splittedInput[1]);
                    int endIndex = int.Parse(splittedInput[2]);


                    if (text.Length > endIndex)
                    {
                        text = text.Remove(startIndex, endIndex+1-startIndex);
                    }
                    Console.WriteLine(text);


                }
                if (input.Contains("Switch"))
                {
                    string[] splittedInput = input.Split(":");
                    string oldString = splittedInput[1];
                    string newString = splittedInput[2];

                    if (text.Contains(oldString))
                    {
                        text = text.Replace(oldString, newString);
                        
                    }
                    Console.WriteLine(text);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {text}");
        }
    }
}
