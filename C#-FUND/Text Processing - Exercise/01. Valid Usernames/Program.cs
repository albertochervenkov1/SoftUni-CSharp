
using System;
using System.Collections.Generic;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            bool notValid = false;
            List<string> list = new List<string>();

            for (int i = 0; i < usernames.Length; i++)
            {
                notValid = false;
                if (usernames[i].Length>=3 && usernames[i].Length<=16)
                {
                    for (int j = 0; j < usernames[i].Length; j++)
                    {
                        string user = usernames[i];
                        char ch = user[j];
                        
                        if (char.IsLetterOrDigit(ch) || ch == '-' || ch == '_')
                        {
                            continue;
                        }
                        else
                        {
                            notValid = true;
                            break;
                        }


                    }
                    if (notValid==false)
                    {
                        list.Add(usernames[i]);
                    }
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);

            }

            
        }
    }
}
