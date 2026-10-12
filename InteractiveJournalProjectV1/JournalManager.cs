using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveJournalProjectV1
{
    public partial class JournalManager
    {
        private List<Creature> discoveredCreatures = new List<Creature>();
        private List<Creature> creatureCatalog;
        public JournalManager(List<Creature> catalog)
        {
            creatureCatalog = catalog;
        }

        public void RecordDiscovery(Creature creature)
        {
            // Record the creature if it has not already been discovered. Otherwise, state that you already found it.
            if (!discoveredCreatures.Contains(creature))
            {
                discoveredCreatures.Add(creature);
                Console.WriteLine("Creature discovery successfully recorded.");
            }
            else
            {
                Console.WriteLine("This creature has already been discovered. No updates made.");
            }
        }

        public List<Creature> GetDiscoveredCreatures()
        {
            // Return discovered creatures in discovery order.
            return discoveredCreatures;
        }
    }
}