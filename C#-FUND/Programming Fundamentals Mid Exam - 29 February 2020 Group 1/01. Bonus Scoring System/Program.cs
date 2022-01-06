using System;
using System.ComponentModel.DataAnnotations;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            

            byte studentsCount = byte.Parse(Console.ReadLine());
            byte lecturesCount = byte.Parse(Console.ReadLine());
            byte initialBonus = byte.Parse(Console.ReadLine());

            double tempTotalBonus = double.MinValue;
            byte student = 0;

            for (int i = 1; i <= studentsCount; i++)
            {
                double attendance = double.Parse(Console.ReadLine());  //{total bonus} = {student attendances} / {course lectures} * (5 + {additional bonus})
                double attendenceLectures = (double)(attendance / lecturesCount);
                double bonus = (5 + initialBonus);
                double totalBonus = (attendenceLectures * bonus);
                
                if (totalBonus>tempTotalBonus)
                {
                    tempTotalBonus = totalBonus;
                    student = (byte)attendance;
                }


            }
            Console.WriteLine($"Max Bonus: {Math.Abs(tempTotalBonus)}.");
            Console.WriteLine($"The student has attended {student} lectures.");

        }
    }
}
