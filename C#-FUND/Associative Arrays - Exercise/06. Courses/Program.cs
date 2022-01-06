using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="end")
                {
                    break;
                }
                string courseName = input.Split(" : ")[0];
                string studentName= input.Split(" : ")[1];

                if (courses.ContainsKey(courseName))
                {
                    courses[courseName].Add(studentName);
                }
                else
                {
                    courses.Add(courseName, new List<string>());
                    courses[courseName].Add(studentName);
                }

            }
            foreach (var item in courses.OrderByDescending(c =>c.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                List<string> students = item.Value;
                students.Sort();
                foreach (var sd in students)
                {
                    Console.WriteLine($"-- {sd}");
                }
            }
        }
    }
}
