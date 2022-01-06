using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Hero
    {
        public int HP { get; set; }
        public int MP { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string heroName = input[0];
                int hp = int.Parse(input[1]);
                int mp = int.Parse(input[2]);
                Hero hero = new Hero() { HP = hp, MP = mp };
                heroes.Add(heroName, hero);

            }
            string command = Console.ReadLine();
            while (command!="End")
            {
                if (command.Contains("CastSpell"))
                {
                    string[] splitted = command.Split(" - ");
                    string name = splitted[1];
                    int mpNeeded = int.Parse(splitted[2]);
                    string spellName = splitted[3];

                    heroes[name].MP -= mpNeeded;
                    if (heroes[name].MP-mpNeeded>=0)
                    {
                        
                        Console.WriteLine($"{name} has successfully cast {spellName} and now has {heroes[name].MP} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (command.Contains("TakeDamage"))
                {
                    string[] splitted = command.Split(" - ");
                    string name = splitted[1];
                    int damage = int.Parse(splitted[2]);
                    string attacker = splitted[3];

                    heroes[name].HP -= damage;
                    if (heroes[name].HP > 0)
                    {

                        Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {heroes[name].HP} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} has been killed by {attacker}!");
                    }
                }
                else if (command.Contains("Recharge"))
                {
                    string[] splitted = command.Split(" - ");
                    string name = splitted[1];
                    int amount = int.Parse(splitted[2]);

                    if (heroes[name].MP + amount > 200)
                    {
                        amount = 200 - heroes[name].MP;
                    }
                    heroes[name].MP += amount;
                    Console.WriteLine($"{name} recharged for {amount} MP!");
                   
                }
                else if (command.Contains("Heal"))
                {
                    string[] splitted = command.Split(" - ");
                    string name = splitted[1];
                    int amount = int.Parse(splitted[2]);

                    if (heroes[name].HP + amount > 100)
                    {
                        amount = 100 - heroes[name].HP;
                    }
                    heroes[name].HP += amount;
                    Console.WriteLine($"{name} healed for {amount} HP!");

                }
                command = Console.ReadLine();
            }

            var sortedHeroes = heroes.OrderByDescending(h => h.Value.HP).ThenBy(h => h.Key);

            foreach (var item in sortedHeroes)
            {
                if (item.Value.HP>0)
                {
                    Console.WriteLine(item.Key);
                    Console.WriteLine($"  HP: {  item.Value.HP  }");
                    Console.WriteLine($"  MP: { item.Value.MP}");
                }
                


            }

        }
    }
}
