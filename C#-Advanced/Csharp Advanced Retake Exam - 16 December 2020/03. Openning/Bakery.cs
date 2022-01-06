using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        public List<Employee> data;
        public Bakery(string name,int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            data = new List<Employee>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return data.Count; } }

        public void Add(Employee employee)
        {
            if (this.Count<this.Capacity)
            {
                data.Add(employee);
            }
        }

        public bool Remove(string name)
        {
            Employee current = data.FirstOrDefault(s => s.Name==name);
            if (data.Contains(current))
            {
                return true;
            }
            return false;
        }

        public Employee  GetOldestEmployee()
        {
            int maxAge = int.MinValue;
            foreach (Employee type in data)
            {
                if (type.Age > maxAge)
                {
                    maxAge = type.Age;
                }
            }
            Employee current = data.FirstOrDefault(s => s.Age == maxAge);
            return current;
        }
        public Employee GetEmployee(string name)
        {
            Employee current = data.FirstOrDefault(s => s.Name == name);
            return current;
        }

        public StringBuilder Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Employees working at Bakery {this.Name}:");
            foreach (var item in data)
            {
                sb.Append(item);
                sb.AppendLine();
            }
            return sb;
        }


    }
}
