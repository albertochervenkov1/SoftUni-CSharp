using System;
using System.Linq;

namespace _01.Username
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string command = Console.ReadLine();
            while (command!="Sign Up")
            {
                string[] splitted = command.Split();
                if (command.Contains("Case"))
                {
                    if (splitted[1]=="lower")
                    {
                        text = text.ToLower();
                    }
                    else
                    {
                        text = text.ToUpper();
                    }
                    Console.WriteLine(text);
                }
                if (command.Contains("Reverse"))
                {
                    int startIndex = int.Parse(splitted[1]);
                    int endIndex = int.Parse(splitted[2]);
                    if (startIndex>=0&&startIndex<text.Length-1||endIndex>=0&&endIndex<text.Length-1)
                    {
                        string tempText = "";
                        tempText = text.Substring(startIndex, endIndex);
                        char[] cArray = tempText.ToCharArray();
                        string reverse = String.Empty;
                        for (int i = cArray.Length - 1; i > -1; i--)
                        {
                            reverse += cArray[i];
                        }
                        Console.WriteLine(reverse);
                        
                    }
                    
                    //text = text.Substring(startIndex, endIndex);


                }
                if (command.Contains("Cut"))
                {
                    string str = splitted[1];
                    if (text.Contains(str))
                    {
                        int startIndex = text.IndexOf(str);
                        int endIndex = str.Length;
                        
                        text = text.Remove(startIndex,endIndex);
                       
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine($"The word {text} doesn't contain {str}.");
                    }
                }
                if (command.Contains("Replace"))
                {
                    string ch = splitted[1];
                    string charToReplace = "*";
                    text=text.Replace(ch, charToReplace);
                    Console.WriteLine(text);
                }
                if (command.Contains("Check"))
                {
                    string ch = splitted[1];

                    if (text.Contains(ch))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {ch}.");
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
