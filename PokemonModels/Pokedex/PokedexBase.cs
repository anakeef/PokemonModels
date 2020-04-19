using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace PokemonModels.Pokedex
{
    public abstract class PokedexBase : IPokedex
    {


        protected PokedexBase()
        {
            //constructor
        }

        public abstract Task<SpeciesInformation> GetSpeciesInformation();
    }

}
