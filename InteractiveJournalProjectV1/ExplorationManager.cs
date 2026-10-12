using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveJournalProjectV1
{
    public class ExplorationManager
    {
        private ICreatureSelector selector;

        public Biome CurrentBiome { get; private set; }

        public ExplorationManager(ICreatureSelector selector)
        {
            this.selector = selector;

            // Set the starting biome.
        }

        public void MoveBiome(Biome biome)
        {
            // Update the current biome.
        }

        public async Task<Creature> DiscoverCreatureAsync(List<Creature> creatureCatalog)
        {
            // Filter the catalog to creatures native to CurrentBiome.
            // Wait briefly using await Task.Delay(...).
            // Use selector to select a creature from the eligible list.
            throw new NotImplementedException();
        }
    }
}