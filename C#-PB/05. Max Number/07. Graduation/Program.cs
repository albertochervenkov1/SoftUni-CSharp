using System;

namespace _07._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double grades = 0;
            double sum =0;
            while (grades<=12)
            {
                double grade = double.Parse(Console.ReadLine());
                
                if (grade>=4.00)
                {
                    sum += grade;
                }
                

            }
            double average = sum / 12;
            Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
           
        }
    }
}
