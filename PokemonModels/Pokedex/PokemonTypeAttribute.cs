using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonModels.Pokedex
{
    public interface IDiscriminatorAttribute<T>
    {
        T Discriminator { get; }
    }
        
    [AttributeUsage(AttributeTargets.Class)]
    public class PokemonTypeAttribute : Attribute, IDiscriminatorAttribute<PokemonType>
    {
        public PokemonTypeAttribute(PokemonType pokemonType)
        {
            Discriminator = pokemonType;
        }

        public PokemonType Discriminator { get;  }
    }
}
