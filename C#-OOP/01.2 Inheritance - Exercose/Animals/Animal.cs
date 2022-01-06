﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private int age;
        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public string Name { get; set; }
        public int Age 
        {
            get => age;
            set 
            {
                if (value<0)
                {
                    throw new ArgumentException("Invalid Input!");
                }
                this.age = value;
            }
        }
        public string Gender { get; set; }

        public virtual string ProduceSound() 
        {
            return string.Empty;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.GetType().Name);
            sb.AppendLine($"{Name} {Age} {Gender}");
            return sb.ToString().TrimEnd();
        }


    }
}
