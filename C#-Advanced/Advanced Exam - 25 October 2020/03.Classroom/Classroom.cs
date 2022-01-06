using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        public List<Student> students;
        public Classroom(int capacity)
        {
            this.Capacity = capacity;
            students = new List<Student>();
            
        }
        
       
        public int Capacity { get; set; }
        public int Count { get { return students.Count; } }
        
        public  string  RegisterStudent(Student student)
        {
            if (this.Count<this.Capacity)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
                
            }
            else
            {
                return $"No seats in the classroom";
            }
        }
        public string DismissStudent(string firstName, string lastName)
        {
            Student currStudent = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
            if (students.Contains(currStudent))
            {
                students.Remove(currStudent);
                return $"Dismissed student {firstName} {lastName}";
            }
            else
            {
                return $"Student not found";
            }
        }
        public string GetSubjectInfo(string subject)
        {
            Student currSubjeect = students.FirstOrDefault(s => s.Subject == subject);
            if (currSubjeect!=null)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine("Students:");
                foreach (var item in students.Where(s=>s.Subject==subject))
                {
                    sb.AppendLine($"{item.FirstName} {item.LastName}").ToString().TrimEnd();
                }
                return sb.ToString().Trim();
            }
            else
            {
                return "No students enrolled for the subject";
            }
        }
        public int GetStudentsCount()
        {
            return students.Count();
        }
        public string GetStudent(string firstName, string lastName)
        {
            Student currStudent = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
            
            //if (students.Contains(currStudent))
            //{
            //    return $"Student: First Name = {firstName}, Last Name = {lastName}, Subject = {currStudent.Subject}";
            //}
            return $"Student: First Name = {firstName}, Last Name = {lastName}, Subject = {currStudent.Subject}";

        }

    }
}
