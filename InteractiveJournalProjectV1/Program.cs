using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveJournalProjectV1
{
    class Program
    {
        static List<Creature> creatureCatalog = new List<Creature>()
        {
            new Beast("Wolf", "A common canine that hunts in packs.", new List<Biome> { Biome.Forest, Biome.Plains }, Rarity.Common),
            new Beast("Squirrel", "A small rodent that gathers nuts and seeds.", new List<Biome> { Biome.Forest }, Rarity.Common),
            new Beast("Bison", "A large herbivore that roams the plains in packs. They will charge if threatened.", new List<Biome> { Biome.Plains }, Rarity.Uncommon),
            new Beast("Prairie Dog", "A small burrowing rodent that lives in colonies. They tend to be highly skittish and thus hard to spot, let alone catch.", new List<Biome> { Biome.Plains }, Rarity.Rare),
            new Legendary("Sasquatch", "A mysterious giant of the wilderness feared by local villagers.", new List<Biome> { Biome.Forest }, Rarity.Legendary),
        };

        static void Main()
        {
            // Create the creature selector.
            // Create the exploration manager and inject the selector.
            // Create the journal manager.
            // Display the main menu and handle the user's selection.
        }

        static void SearchCreatures()
        {
            // Search the existing creature catalog.
        }

        static void ViewBiomes()
        {
            bool viewing = true;
            while (viewing)
            {
                Console.Clear();
                Console.WriteLine("======");
                Console.WriteLine("BIOMES");
                Console.WriteLine("======");
                Console.WriteLine();
                Console.WriteLine("1.) Plains");
                Console.WriteLine("2.) Forest");
                Console.WriteLine("3.) Desert");
                Console.WriteLine("4.) Tundra");
                Console.WriteLine("5.) Cliffs");
                Console.WriteLine("6.) Rainforest");
                Console.WriteLine("7.) Swamp");
                Console.WriteLine("8.) Freshwater");
                Console.WriteLine("0.) Return");
                Console.WriteLine();
                Console.Write("Select a biome: ");
                string choice = Console.ReadLine();
                //Some old logic is still sitting in the cases. Address later
                switch (choice)
                {
                    case "1":
                        ViewBiome(Biome.Plains);
                        break;
                    case "2":
                        ViewBiome(Biome.Forest);
                        break;
                    case "3":
                        ViewBiome(Biome.Desert);
                        break;
                    case "4":
                        ViewBiome(Biome.Tundra);
                        break;
                    case "5":
                        ViewBiome(Biome.Cliffs);
                        break;
                    case "6":
                        ViewBiome(Biome.Rainforest);
                        break;
                    case "7":
                        ViewBiome(Biome.Swamp);
                        break;
                    case "8":
                        ViewBiome(Biome.Freshwater);
                        break;
                    case "0":
                        viewing = false;
                        break;
                    default:
                        Console.WriteLine("\nInvalid selection.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void ViewJournal()
        {
            // Display completion percentage and discovered creatures.
        }
    }
}