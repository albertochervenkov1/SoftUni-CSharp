using System;
using System.Collections.Generic;
using System.Text;

namespace _2.GenericBoxofInteger
{
    public class Box<T>
    {
        public Box(T value)
        {
            this.Value = value;
        }
        public T  Value{ get; set; }

        public override string ToString()
        {
            Type type = this.Value.GetType();
            string fullName = type.FullName;
            return $"{fullName}: {this.Value}";
        }
    }
}
