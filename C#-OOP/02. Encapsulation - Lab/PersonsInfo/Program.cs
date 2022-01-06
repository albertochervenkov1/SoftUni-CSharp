using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> list = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));

                list.Add(person);

            }

            var parcentage = decimal.Parse(Console.ReadLine());
            list.ForEach(p => p.IncreaseSalary(parcentage));
            list.ForEach(p => Console.WriteLine(p.ToString()));

        }
        
    }
}
