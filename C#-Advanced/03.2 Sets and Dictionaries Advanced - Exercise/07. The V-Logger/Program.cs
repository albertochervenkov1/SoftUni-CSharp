using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, SortedSet<string>>> app = new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            string input = Console.ReadLine();

            while (input!= "Statistics")
            {
                string[] splittedInput = input.Split();
                string vloggerName = splittedInput[0];
                string command = splittedInput[1];
                if (command=="joined")
                {
                    if (!app.ContainsKey(vloggerName))
                    {
                        app.Add(vloggerName, new Dictionary<string, SortedSet<string>>());
                        app[vloggerName].Add("following", new SortedSet<string>());
                        app[vloggerName].Add("followers", new SortedSet<string>());
                    }
                    
                }
                else if (command=="followed")
                {
                    string secondVlogger = splittedInput[2];
                    if (app.ContainsKey(vloggerName)&&app.ContainsKey(secondVlogger)&&vloggerName!=secondVlogger)
                    {
                        app[vloggerName]["following"].Add(secondVlogger);
                        app[secondVlogger]["followers"].Add(vloggerName);
                    }
                    
                    
                }

                input = Console.ReadLine();
            }
            
            Console.WriteLine($"The V-Logger has a total of {app.Keys.Count} vloggers in its logs.");
            Dictionary<string, Dictionary<string, SortedSet<string>>> sortedData =app.OrderByDescending(k => k.Value["followers"].Count)
                .ThenBy(k => k.Value["following"].Count).ToDictionary(k=>k.Key, k=>k.Value);
            int counter = 0;

            foreach (KeyValuePair<string,Dictionary<string,SortedSet<string>>> item in sortedData)
            {
                int followersCount = item.Value["followers"].Count;
                int followingCount = item.Value["following"].Count;
                Console.WriteLine($"{++counter}. {item.Key} : {followersCount} followers, {followingCount} following");
                if (counter==1)
                {
                    foreach (string follower in item.Value["followers"])
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                
            }
            
        }
    }
}
