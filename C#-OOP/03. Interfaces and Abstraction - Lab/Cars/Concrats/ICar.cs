using System;
using System.Collections.Generic;
using System.Text;

namespace Cars.Concrats
{
    public interface ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string Start();
        public string Stop();
    }
}
