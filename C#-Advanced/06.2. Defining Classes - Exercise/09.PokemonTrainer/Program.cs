using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        //"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            var trainers = new List<Trainer>();
            while (input[0]!="Tournament")
            {
                string trainerName = input[0];
                string pokemonName = input[1];
                string pokemonElement = input[2];
                int pokemonHealth = int.Parse(input[3]);
                var trainer = trainers.FirstOrDefault(x => x.Name == trainerName);
                if (trainer!=null)
                {
                    trainer.Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                    
                }
                else
                {
                    var newTrainer = new Trainer(trainerName);
                    newTrainer.Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                    trainers.Add(newTrainer);
                }
                input = Console.ReadLine().Split();
            }
            string command = Console.ReadLine();
            while (command!="End")
            {
                for (int i = 0; i < trainers.Count; i++)
                {
                    if (!trainers[i].Pokemons.Any(x=>x.Element==command))
                    {
                        foreach (var item in trainers[i].Pokemons)
                        {
                            item.Health -= 10;

                        }
                    }
                    else
                    {
                        trainers[i].NumberOfBagdes++;
                    }
                }
                command = Console.ReadLine();
            }

            foreach (var item in trainers)
            {
                item.Pokemons.RemoveAll(x => x.Health <= 0);
            }
            var newList = trainers.OrderByDescending(x => x.NumberOfBagdes).ToList();
            foreach (var item in newList)
            {
                Console.WriteLine($"{item.Name} {item.NumberOfBagdes} {item.Pokemons.Count}");
            }
        }
       
	}
        
	

	
    
}
