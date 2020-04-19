using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PokemonModels.Pokedex
{
    public interface IPokedex 
    {
        Task<SpeciesInformation> GetSpeciesInformation();
    }
}
