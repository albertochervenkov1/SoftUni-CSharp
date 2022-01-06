using System;
using System.Collections.Generic;

namespace ClassroomProject
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Classroom classroom = new Classroom(1);
            Student student = new Student("Pesho", "Birata", "FVS");
            Student studentTwo = new Student("Alberto", "Chervenkov", "Informatika");
            
            Console.WriteLine(student);
            string register = classroom.RegisterStudent(student);
            string registerTwo = classroom.RegisterStudent(studentTwo);
            Console.WriteLine(register);
            Console.WriteLine(registerTwo);
            string subjectInfo = classroom.GetSubjectInfo("FVS");
            Console.WriteLine(subjectInfo);
            Console.WriteLine(classroom.GetStudent("Pesho", "Birata"));

        }
    }
}
