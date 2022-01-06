using PersonInfo.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo.Models
{
    public class Citizen : ICitizen
    {
        public Citizen(string name, int age, string id, string birthDate)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthDate = birthDate;
            
        }

        public string BirthDate { get; private set; }

        public string Id { get; private set; }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public int Food { get;  set; }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
