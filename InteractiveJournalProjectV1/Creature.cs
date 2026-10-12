using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveJournalProjectV1
{
    public enum Biome
    {
        Plains, Forest, Desert, Tundra, Cliffs, Rainforest, Swamp, Freshwater
    }

    public enum Rarity
    {
        Common, Uncommon, Rare, Legendary
    }

    public abstract class Creature
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Biome> Biomes { get; set; }
        public Rarity Rarity { get; set; }

        public Creature(string name, string description, List<Biome> biomes, Rarity rarity)
        {
            Name = name;
            Description = description;
            Biomes = biomes;
            Rarity = rarity;
        }

        public abstract string GetDescription();
    }

    public sealed class Beast : Creature
    {
        public Beast(string name, string description, List<Biome> biomes, Rarity rarity)
            : base(name, description, biomes, rarity)
        {
        }

        public override string GetDescription()
        {
            return $"A normal beast from these lands.\n{Description}";
        }
    }

    public sealed class Legendary: Creature
    {
        public Legendary(string name, string description, List<Biome> biomes, Rarity rarity)
            : base(name, description, biomes, rarity)
        {
        }
        public override string GetDescription()
        {
            return $"A legendary creature of myth and legend.\n{Description}";
        }
    }

    public interface IJournalEntry
    {
        string GetJournalEntry();
    }

    public delegate bool CreatureFilter(Creature creature);
}
