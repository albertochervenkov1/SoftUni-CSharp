using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Inventory;

namespace WarCroft.Entities.Characters
{
    public class Warrior : Character,IAttacker
    {
        private const double WarriorHealth = 100;
        private const double WarriorArmor = 50;
        private const double AbilityPoints = 40;
        public Warrior(string name) 
            : base(name, WarriorHealth, WarriorArmor, AbilityPoints, new Satchel())
        {
        }

        public void Attack(Character character)
        {
            this.EnsureAlive();
            if (character.IsAlive == false)
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }
            if (Name==character.Name)
            {
                throw new InvalidOperationException(ExceptionMessages.CharacterAttacksSelf);
            }
            character.TakeDamage(AbilityPoints);
        }
    }
}
