using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList :List<string>
    {
        private Random random;
        public RandomList()
        {
            random = new Random();
        }
        public void add(string st) 
        {
            base.Add(st);
        }
        public string RandomString() 
        {
            return this[random.Next(0, this.Count)];
        }
    }
}
