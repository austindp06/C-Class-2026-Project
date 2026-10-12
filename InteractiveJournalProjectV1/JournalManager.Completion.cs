using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveJournalProjectV1
{
    public partial class JournalManager
    {
        public double GetCompletionPercentage(List<Creature> creatureCatalog)
        {
            // Calculate the percentage of the catalog discovered.
            if (creatureCatalog.Count == 0)
            {
                return 0;
            }
            return (double)(discoveredCreatures.Count / (double)(creatureCatalog.Count) * 100);
            // Later add some text to say something like "X% of creatures discovered"
        }

        public int GetRemainingCreatures(Biome biome, List<Creature> creatureCatalog)
        {
            // Count undiscovered creatures native to the specified biome.
            throw new NotImplementedException();
        }

        public List<Creature> SortDiscoveredCreatures(
            List<Creature> creatures, string sortOption)
        {
            // Sort by discovery order, rarity, or biome.
            throw new NotImplementedException();
        }
    }
}
