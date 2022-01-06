using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] splitted = Console.ReadLine().Split();
                string name = splitted[0];
                int age = int.Parse(splitted[1]);

                Person currPerson = new Person(name, age);
                family.AddMember(currPerson);
            }
            Person oldest = family.GetOldestMembers();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}
