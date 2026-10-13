using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveBestiaryProject
{
    class Program
    {
        static List<Creature> creatureCatalog = new List<Creature>()
        {
            // Order catalog by 2 standards: biome, then rarity. Overlap cases can be placed in the order they are added to the list and stay within Common category.
            // Try to stay consistent. So long as each biome has at least 5 common, 3 uncommon, 2 rare, 1 legendary.

            // Forest Biome
            new Beast("Wolf", "A common canine that hunts in packs.", new List<Biome> { Biome.Forest, Biome.Plains }, Rarity.Common),
            new Beast("Squirrel", "A small rodent that gathers nuts and seeds.", new List<Biome> { Biome.Forest }, Rarity.Common),
            new Legendary("Sasquatch", "A mysterious giant of the wilderness feared by local villagers.", new List<Biome> { Biome.Forest }, Rarity.Legendary),

            // Plains Biome
            new Beast("Bison", "A large herbivore that roams the plains in packs. They will charge if threatened.", new List<Biome> { Biome.Plains }, Rarity.Uncommon),
            new Beast("Prairie Dog", "A small burrowing rodent that lives in colonies. They tend to be highly skittish and thus hard to spot, let alone catch.", new List<Biome> { Biome.Plains }, Rarity.Rare),

            // Desert Biome


            // Tundra Biome
            new Beast("Caribou", "A large herbivore that is normally docile unless threatened.", new List<Biome> { Biome.Tundra }, Rarity.Uncommon),
            new Beast("Artic Wolf", "A large carnivore that hunts in packs. They are highly territorial and will attack if provoked.", new List<Biome> { Biome.Tundra }, Rarity.Rare),

            // Cliffs Biome


            // Rainforest Biome


            // Swamp Biome
            

            // Freshwater Biome
        };

        static void Main()
        {
            Console.Clear();
            Console.WriteLine("=========");
            Console.WriteLine("BESTIARY");
            Console.WriteLine("=========");
            Console.WriteLine();
            Console.WriteLine("1.) Search Creatures");
            Console.WriteLine("2.) Add Creature");
            Console.WriteLine("3.) View Biomes");
            Console.WriteLine("4.) Exit");
            Console.WriteLine();
            bool running = true;
            while (running)
            {
                Console.Write("Select an option: ");
                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Search creatures Placeholder Text");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Discover creature Placeholder Text");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("View biomes Placeholder Text.");
                        // ViewBiomes();
                        break;
                    case "4":
                        Console.WriteLine("Exiting the Bestiary.");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("\nInvalid selection.");
                        Console.ReadKey();
                        break;
                }
            }
            
        }
        static void SearchCreatures()
        {
            Console.Clear();
            // Create the creature selector.
            // Create the exploration manager and inject the selector.
            // Create the journal manager.
            // Display the main menu and handle the user's selection.
        }

        //static void SearchCreatures()
        //{
        //    // Search the existing creature catalog.
        //}



        //static void ViewBiomes()
        //{
        //    bool viewing = true;
        //    while (viewing)
        //    {
        //        Console.Clear();
        //        Console.WriteLine("======");
        //        Console.WriteLine("BIOMES");
        //        Console.WriteLine("======");
        //        Console.WriteLine();
        //        Console.WriteLine("1.) Plains");
        //        Console.WriteLine("2.) Forest");
        //        Console.WriteLine("3.) Desert");
        //        Console.WriteLine("4.) Tundra");
        //        Console.WriteLine("5.) Cliffs");
        //        Console.WriteLine("6.) Rainforest");
        //        Console.WriteLine("7.) Swamp");
        //        Console.WriteLine("8.) Freshwater");
        //        Console.WriteLine("0.) Return");
        //        Console.WriteLine();
        //        Console.Write("Select a biome: ");
        //        string choice = Console.ReadLine();
        //        //Some old logic is still sitting in the cases. Address later...
        //        switch (choice)
        //        {
        //            case "1":
        //                ViewBiomes(Biome.Plains);
        //                break;
        //            case "2":
        //                ViewBiomes(Biome.Forest);
        //                break;
        //            case "3":
        //                ViewBiomes(Biome.Desert);
        //                break;
        //            case "4":
        //                ViewBiomes(Biome.Tundra);
        //                break;
        //            case "5":
        //                ViewBiomes(Biome.Cliffs);
        //                break;
        //            case "6":
        //                ViewBiomes(Biome.Rainforest);
        //                break;
        //            case "7":
        //                ViewBiomes(Biome.Swamp);
        //                break;
        //            case "8":
        //                ViewBiomes(Biome.Freshwater);
        //                break;
        //            case "0":
        //                viewing = false;
        //                break;
        //            default:
        //                Console.WriteLine("\nInvalid selection.");
        //                Console.ReadKey();
        //                break;
        //        }
        //}


            static void ViewJournal()
        {
            // Display completion percentage and discovered creatures.
            Console.WriteLine("Fetching journal data...");
            // Place async here to simulate tiny delay.
        }
    }
}