using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> list = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] person = Console.ReadLine().Split();
                string name = person[0];
                int age = int.Parse(person[1]);

                Person guy = new Person(name, age);
                list.Add(guy);

            }
            var newList = list.Where(p => p.Age > 30).OrderBy(p=>p.Name).ToList();
            foreach (var item in newList)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }
    }
}
