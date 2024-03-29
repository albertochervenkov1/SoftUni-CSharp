﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Beverages
{
    public class Coffee : HotBeverage
    {
        private const decimal DefaultPrice = 3.50M;
        private const double DefaultMillilters = 50;
        public Coffee(string name,double caffeine) 
            : base(name, DefaultPrice, DefaultMillilters)
        {
            this.Caffeine = caffeine;
            
        }
        public double Caffeine { get; set; }
    }
}
