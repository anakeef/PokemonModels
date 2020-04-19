using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonModels.Pokedex
{
    public abstract class SpeciesInformation
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public string Category { get; set; }
        public string Abilities { get; set; }
    }

    public class SpeciesType : SpeciesInformation
    {
        public PokemonType Type1 { get; set; }
        public PokemonType Type2 { get; set; }
        public PokemonType Type3 { get; set; }
        public PokemonType Weakness1 { get; set; }
        public PokemonType Weakness2 { get; set; }
        public PokemonType Weakness3 { get; set; }
        public PokemonType Weakness4 { get; set; }
    }

    public class SpeciesWeakness : SpeciesInformation
    {
        public PokemonType Weakness1 { get; set; }
        public PokemonType Weakness2 { get; set; }
        public PokemonType Weakness3 { get; set; }
        public PokemonType Weakness4 { get; set; }




    }
}
