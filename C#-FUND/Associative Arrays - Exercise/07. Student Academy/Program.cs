using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentGrades = new Dictionary<string,List<double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (studentGrades.ContainsKey(name))
                {
                    studentGrades[name].Add(grade);
                }
                else
                {
                    studentGrades.Add(name, new List<double>());
                    studentGrades[name].Add(grade);
                }

            }
            var averageGrade = new Dictionary<string, double>();
            foreach (var item in studentGrades)
            {
                averageGrade.Add(item.Key, item.Value.Average());
            }
            
            foreach (var item in averageGrade.Where(s => s.Value >= 4.50).OrderByDescending(st => st.Value))
            {

                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }
        }
    }
}
