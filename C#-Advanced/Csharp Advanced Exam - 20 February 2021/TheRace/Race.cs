using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> data;
        public Race(string name,int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            data = new List<Racer>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return data.Count; } }

        public void Add(Racer Racer) 
        {
            if (this.Count<this.Capacity)
            {
                data.Add(Racer);
            }
        }
        public bool Remove(string name)
        {
            Racer pl = data.FirstOrDefault(p => p.Name == name);
            if (pl == null)
            {
                return false;
            }
            data.Remove(pl);
            return true;
        }
        public Racer GetOldestRacer()
        {
            return data.OrderByDescending(p => p.Age).FirstOrDefault();
        }
        public Racer GetRacer(string name) 
        {
            Racer racer = data.FirstOrDefault(r => r.Name == name);
            return racer;
        }

        public Racer GetFastestRacer()
        {
            return data.OrderByDescending(p => p.Car.Speed).FirstOrDefault();
        }
        public string Report() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Racers participating at {this.Name}:");
            foreach (var item in data)
            {
                sb.AppendLine($"Racer: {item.Name}, {item.Age} ({item.Country})");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
