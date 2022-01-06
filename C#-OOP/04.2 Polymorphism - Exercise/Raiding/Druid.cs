using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Druid : BaseHero
    {
        private const int power = 80;
        public Druid(string name) 
            : base(name, 80)
        {
            
        }
        public override string CastAbility()
        {
            return $"{base.CastAbility()} healed for {Power}";
        }

    }
}
