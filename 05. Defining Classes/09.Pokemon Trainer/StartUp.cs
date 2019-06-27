

namespace PokeTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using PokeTrainer.Models;

    public class StartUp
    {
        public static void Main(string[] args)
        {

            Dictionary<string, Trainer> trainersByName = new Dictionary<string, Trainer> { };

            string input = Console.ReadLine();

            while (input!="Tournament")
            {
                string[] partitions = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                //this is unique!
                string trainerName = partitions[0];
                string pokeName = partitions[1];
                string pokeElement = partitions[2];
                int pokeHealth = int.Parse(partitions[3]);


                Pokemon currentPoke = new Pokemon(pokeName, pokeElement, pokeHealth);

                

                if (!trainersByName.ContainsKey(trainerName))
                {
                    Trainer trainer = new Trainer(trainerName);
                    trainer.AddPokemon(currentPoke);

                    trainersByName.Add(trainer.Name, trainer);
                }

                else
                {
                    var currentTrainer = trainersByName.Select(t => t.Value).FirstOrDefault(t => t.Name == trainerName);

                    if (!currentTrainer.Pokemons.Any(p=> p.Name==currentPoke.Name))
                    {
                        currentTrainer.AddPokemon(currentPoke);
                    }

                }

                input = Console.ReadLine();
            }

            string element = Console.ReadLine();

            while (element!="End")
            {

                foreach (var kvp in trainersByName)
                {
                    var trainer = kvp.Value;

                    if (trainer.HasAnyPokemonsWithElement(element))
                    {
                        trainer.RecieveBadge();
                    }
                    else
                    {
                        trainer.PokemonesLoseHP();
                        trainer.ClearDeadPokemons();
                    }
                }

                element = Console.ReadLine();
            }

            List<Trainer> trainers = trainersByName.Select(t => t.Value).OrderByDescending(t => t.NumberOfBadges).ToList();

            foreach (var trainer in trainers)
            {

                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");

            }



        }
    }
}
