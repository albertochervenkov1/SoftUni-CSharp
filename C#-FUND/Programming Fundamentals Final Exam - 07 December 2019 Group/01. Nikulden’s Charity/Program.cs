using System;

namespace _01._Nikulden_s_Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string command = Console.ReadLine();
            while (command!="Finish")
            {
                if (command.Contains("Replace"))
                {
                    string[] splitted = command.Split();
                    string oldChar = splitted[1];
                    string newChar = splitted[2];
                    text = text.Replace(oldChar, newChar);
                    Console.WriteLine(text);
                }
                else if (command.Contains("Cut"))
                {
                    string[] splitted = command.Split();
                    int startIndex = int.Parse(splitted[1]);
                    int endIndex = int.Parse(splitted[2]);
                    if (startIndex>text.Length-1||startIndex<=0||endIndex>text.Length-1||endIndex<=0)
                    {
                        Console.WriteLine("Invalid indexes!");

                    }
                    else
                    {
                        text = text.Remove(startIndex, endIndex);
                        Console.WriteLine(text);
                    }
                   

                    

                }
                else if (command.Contains("Make"))
                {
                    if (command.Contains("Upper"))
                    {
                        text = text.ToUpper();
                    }
                    else if (command.Contains("Lower"))
                    {
                        text = text.ToLower();
                    }
                    Console.WriteLine(text);
                }
                else if (command.Contains("Check"))
                {
                    string[] splitted = command.Split();
                    string str = splitted[1];

                    if (text.Contains(str))
                    {
                        Console.WriteLine($"Message contains {str}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {str}");
                    }
                }
                else if (command.Contains("Sum"))
                {
                    string[] splitted = command.Split();
                    int startIndex = int.Parse(splitted[1]);
                    int endIndex = int.Parse(splitted[2]);
                    if (startIndex > text.Length - 1 || startIndex <= 0 || endIndex > text.Length - 1 || endIndex <= 0)
                    {
                        Console.WriteLine("Invalid indexes!");

                    }
                    else
                    {
                        int sum = 0;
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            sum += text[i];
                        }
                        Console.WriteLine(sum);
                    }
                }
                

                command = Console.ReadLine();
            }
            
        }
    }
}
