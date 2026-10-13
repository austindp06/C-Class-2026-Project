using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveBestiaryProject
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
                Console.WriteLine($"{creature.Name} has been added to your journal.");
                // If we commit to the user-generated IJournal log, put it here
            }
            else
            {
                Console.WriteLine("This creature has already been discovered. No updates made.");
            }
        }

        public List<Creature> GetDiscoveredCreatures()
        {
            // Return discovered creatures in discovery order. For other ordering, consult SortDiscoveredCreatures().
            return discoveredCreatures;
        }
    }
}