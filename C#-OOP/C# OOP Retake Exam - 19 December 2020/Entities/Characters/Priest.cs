using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Inventory;

namespace WarCroft.Entities.Characters
{
    //has 50 Base Health, 25 Base Armor, 40 Ability Points, and a Backpack as a bag.
    public class Priest : Character,IHealer
    {
        private const double PriestHealth = 50;
        private const double PriestArmor = 25;
        private const double AbilityPoints = 40;
        public Priest(string name) 
            : base(name, PriestHealth, PriestArmor, AbilityPoints, new Backpack())
        {
        }

        public void Heal(Character character)
        {
            this.EnsureAlive();
            if (character.IsAlive==false)
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }
            character.Health += AbilityPoints;
        }
    }
}
