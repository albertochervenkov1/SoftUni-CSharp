﻿using System;

using WarCroft.Constants;
using WarCroft.Entities.Inventory;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Characters.Contracts
{
	public abstract class Character
	{
		private string name;
		private double health;
		private double armor;

		protected Character(string name, double health, double armor, double abilityPoints, Bag bag)
		{
			Name = name;
			Health = health;
			Armor = armor;
			AbilityPoints = abilityPoints;
			Bag = bag;
		}

		public string Name
		{
			get => this.name;
			private set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException(ExceptionMessages.CharacterNameInvalid);
				}
				this.name = value;
			}
		}
		public double BaseHealth { get; private set; }
		public double Health
		{
			get => this.health;
			set
			{
				if (value > 0 && value <= this.BaseHealth)
				{
					this.health = value;
				}
			}
		}
		public double BaseArmor { get; private set; }
		public double Armor
		{
			get => this.armor;
			private set
			{
				if (value > 0)
				{
					this.armor = value;
				}
			}
		}
		public double AbilityPoints { get; private set; }
		public IBag Bag { get; private set; }
		public bool IsAlive { get; set; } = true;

		protected void EnsureAlive()
		{
			if (!this.IsAlive)
			{
				throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
			}
		}

		public void TakeDamage(double hitPoints)
		{
			this.EnsureAlive();
			if (this.armor >= hitPoints)
			{
				this.armor -= hitPoints;///!!!
			}
			else
			{
				hitPoints -= this.armor;
				this.armor = 0;
				if (this.health > hitPoints)
				{
					this.health -= hitPoints;
				}
				else
				{
					this.health = 0;
					this.IsAlive = false;
				}
			}
		}
		public void UseItem(Item item)
		{
			EnsureAlive();
			item.AffectCharacter(this);
		}
		public override string ToString()
		{
			var status = string.Empty;

			if (this.IsAlive)
			{
				status = "Alive";
			}
			else
			{
				status = "Dead";
			}
			return $"{this.Name} - HP: {this.Health}/{ this.BaseHealth}, AP: {this.Armor}/{this.BaseArmor}, Status: {status}";
		}
	}
}