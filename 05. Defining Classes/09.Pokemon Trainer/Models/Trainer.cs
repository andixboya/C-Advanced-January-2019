
namespace PokeTrainer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class Trainer
    {
        private string name;
        private int numberOfBadges;
        private List<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.Name = name;
            this.NumberOfBadges = 0;
            this.pokemons = new List<Pokemon> { };
            
        }

        public string Name { get => name; set => name = value; }
        public int NumberOfBadges { get => numberOfBadges; set => numberOfBadges = value; }
        public IReadOnlyCollection<Pokemon> Pokemons { get => pokemons.AsReadOnly(); }

        public void AddPokemon(Pokemon pokemon)
        {
            if (!this.pokemons.Any(p=> p.Name==pokemon.Name))
            {
                this.pokemons.Add(pokemon);
            }
        }


        public bool HasAnyPokemonsWithElement(string element)
        {
            if (pokemons.Any(p=> p.Element==element))
            {
                return true;
            }

            return false;
        }

        public void RecieveBadge()
        {
            this.numberOfBadges++;
        }

        public void PokemonesLoseHP()
        {
            foreach (var poke in pokemons)
            {
                poke.Health -= 10;

            }

        }

        public void ClearDeadPokemons()
        {
            pokemons = pokemons.Where(p => p.IsAlive).ToList();
        }


    }
}
