using System;
using System.Collections.Generic;
using System.Linq;
namespace _0.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> party = Console.ReadLine().Split().ToList();

            string[] command = Console.ReadLine().Split(";");
            while (command[0]=="Print")
            {
                if (command[0]=="Add filter")
                {

                }
            }
        }
        static void AddFilter(string[] command,List<string> party) 
        {
            switch (command[1])
            {
                case "Starts With":
                    char ch = char.Parse(command[2]);
                    party.Where(x => x.StartsWith(ch));
                    break;
                        
                default:
                    break;
            }
        }
        
       
    }
}
