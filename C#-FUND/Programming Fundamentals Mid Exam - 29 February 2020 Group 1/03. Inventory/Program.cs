using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                string command = Console.ReadLine();
                if (command=="Craft!")
                {
                    break;
                }
                string[] splitted=command.Split(" - ");
                if (splitted[0]=="Collect")
                {
                    if (items.Contains(splitted[1]))
                    {

                    }
                    else
                    {
                        items.Add(splitted[1]);
                    }
                }
                else if (splitted[0]=="Drop")
                {
                    items.Remove(splitted[1]);
                }
                else if (splitted[0]=="Combine Items")
                {
                    string[] commandSplitted=splitted[1].Split(":");
                    for (int i = 0; i < items.Count; i++)
                    {
                        if (items[i] == commandSplitted[0])
                        {
                            int index = items.IndexOf(commandSplitted[0]);
                            if (index>=0)
                            {
                                items.Insert(index + 1, commandSplitted[1]);
                            }
                            
                        }
                        
                    }
                }
                else if (splitted[0]=="Renew")
                {
                    if (items.Contains(splitted[1]))
                    {
                        items.Remove(splitted[1]);
                        items.Add(splitted[1]);
                    }
                    
                }
            }
            Console.WriteLine(string.Join(", ",items));
        }
    }
}
