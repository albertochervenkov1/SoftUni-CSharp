﻿using PersonInfo.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo.Models
{
    public class Rebel : IRebel
    {
        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            
            Group = group;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public int Food { get;  set; }

        public string Group { get; private set; }

        public void BuyFood()
        {
            Food += 5;
        }
    }
}
