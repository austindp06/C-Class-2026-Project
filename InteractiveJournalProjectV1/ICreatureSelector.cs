using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveJournalProjectV1
{
    public interface ICreatureSelector
    {
        Creature SelectRandom(List<Creature> availableCreatures);
    }
}