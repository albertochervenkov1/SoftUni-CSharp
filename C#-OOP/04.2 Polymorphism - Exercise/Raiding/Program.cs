using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<BaseHero> heroes = new List<BaseHero>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                string typeHero = Console.ReadLine();

                try
                {
                    BaseHero hero = CreateHero(typeHero, name);

                    heroes.Add(hero);
                }
                catch (Exception ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
            double bossPower = double.Parse(Console.ReadLine());

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
            }

            int sum = heroes.Sum(h => h.Power);

            if (sum >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
        public static BaseHero CreateHero(string heroType, string heroName)
        {
            BaseHero baseHero;

            if (heroType == "Druid")
            {
                baseHero = new Druid(heroName);
            }
            else if (heroType == "Paladin")
            {
                baseHero = new Paladin(heroName);
            }
            else if (heroType == "Rogue")
            {
                baseHero = new Rogue(heroName);
            }
            else if (heroType == "Warrior")
            {
                baseHero = new Warrior(heroName);
            }
            else
            {
                throw new ArgumentException("Invalid hero!");
            }

            return baseHero;
        }
    }
}
