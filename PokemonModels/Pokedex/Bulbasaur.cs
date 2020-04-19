using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PokemonModels.Pokedex
{
    [PokemonType(PokemonType.Grass)]
    class Bulbasaur : PokedexBase
    {
        //add logger


        public Bulbasaur() : base()
        {
            //constructor
        }

        public override async Task<SpeciesInformation> GetSpeciesInformation()
        {
            return new SpeciesType
            {
                Name = "Bulbasaur",
                Category = "Seed",
                Abilities = "Overgrow",
                Type1 = PokemonType.Grass,
                Type2 = PokemonType.Poison,
                Weakness1 = PokemonType.Fire,
                Weakness2 = PokemonType.Flying,
                Weakness3 = PokemonType.Ice,
                Weakness4 = PokemonType.Psychic

            };

        }
    }
}
