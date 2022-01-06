using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Trainer
    {
        public Trainer(string name)
        {
            this.Name = name;
            this.NumberOfBagdes = 0;
            this.Pokemons = new List<Pokemon>();
            
        }
        

        public string  Name { get; set; }
        public int NumberOfBagdes { get; set; }
        public List<Pokemon> Pokemons { get; set; }


    }
}
