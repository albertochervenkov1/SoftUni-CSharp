﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Foods
{


    public class Cake : Dessert
    {
        private const decimal DefaultPrice = 5;
        private const double DefaultGrams = 250;
        private const double DefaultCalories = 1000;
        public Cake(string name) 
            : base(name, DefaultPrice, DefaultGrams, DefaultCalories)
        {
        }
    }
}
