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
    new Beast("Gray Wolf", "A common canine that hunts in packs, bringing down prey far larger than itself.", new List<Biome> { Biome.Forest, Biome.Plains }, Rarity.Common),
    new Beast("White-tailed Deer", "A wary browser that flashes its white tail as a warning before it bolts.", new List<Biome> { Biome.Forest }, Rarity.Common),
    new Beast("Black Bear", "An opportunistic omnivore that forages for berries, grubs, and anything left unguarded.", new List<Biome> { Biome.Forest }, Rarity.Common),
    new Beast("Red Fox", "A cunning solitary hunter that pounces on prey hidden beneath leaves or snow.", new List<Biome> { Biome.Forest }, Rarity.Common),
    new Beast("Great Horned Owl", "A silent nocturnal hunter with piercing yellow eyes and crushing talons.", new List<Biome> { Biome.Forest }, Rarity.Common),
    new Beast("Dire Wolf", "A heavier, more powerful relative of the wolf, built for overpowering big game.", new List<Biome> { Biome.Forest }, Rarity.Uncommon),
    new Beast("Cave Bear", "A hulking prehistoric bear that dens in the deep forest caves. Best left undisturbed.", new List<Biome> { Biome.Forest }, Rarity.Uncommon),
    new Beast("Megaloceros", "A giant deer whose antlers can span over three meters from tip to tip.", new List<Biome> { Biome.Forest }, Rarity.Uncommon),
    new Mythic("White Hart", "A pure white stag said to appear before a great quest or turning point. Hunters swear it cannot be caught, though some say it is simply a rare pale deer.", new List<Biome> { Biome.Forest }),
    new Mythic("Wolpertinger", "A small antlered hare with wings, spoken of by woodsmen and tavern-goers alike. Most who claim to have seen one were seeing a hare with an unusual growth on its head.", new List<Biome> { Biome.Forest }),
    new Legendary("Sasquatch", "A mysterious giant of the wilderness feared by local villagers. Known only from massive footprints and distant calls.", new List<Biome> { Biome.Forest }),

    // Plains Biome
    new Beast("Bison", "A large herbivore that roams the plains in herds. They will charge if threatened.", new List<Biome> { Biome.Plains }, Rarity.Common),
    new Beast("Prairie Dog", "A small burrowing rodent that lives in colonies. They tend to be highly skittish and thus hard to spot, let alone catch.", new List<Biome> { Biome.Plains }, Rarity.Common),
    new Beast("Pronghorn", "The fastest runner of the grasslands, able to outpace nearly any predator over long distances.", new List<Biome> { Biome.Plains }, Rarity.Common),
    new Beast("Coyote", "A clever, adaptable scavenger-hunter that roams alone or in loose family packs.", new List<Biome> { Biome.Plains }, Rarity.Common),
    new Beast("Red-tailed Hawk", "A broad-winged raptor that circles high above the grass, watching for small prey.", new List<Biome> { Biome.Plains }, Rarity.Common),
    new Beast("Aurochs", "The colossal wild ancestor of cattle, with forward-curving horns and a notorious temper.", new List<Biome> { Biome.Plains }, Rarity.Uncommon),
    new Beast("Giant Short-faced Bear", "A towering, long-legged bear built to run down prey and drive other predators off their kills.", new List<Biome> { Biome.Plains }, Rarity.Uncommon),
    new Beast("Glyptodont", "An armored, cart-sized relative of the armadillo whose spiked tail can shatter bone.", new List<Biome> { Biome.Plains }, Rarity.Uncommon),
    new Mythic("Jackalope", "A swift antlered hare said to mimic human voices at dusk. Likely a rabbit afflicted with horn-like growths, made famous by storytellers.", new List<Biome> { Biome.Plains }),
    new Mythic("Ghost Stallion", "A pale horse seen running with wild herds on moonlit nights, leaving no hoofprints. Perhaps only a white mustang glimpsed in poor light.", new List<Biome> { Biome.Plains }),
    new Legendary("Thunderbird", "A sky-spirit so vast that its wingbeats make thunder and its eyes flash lightning.", new List<Biome> { Biome.Plains }),

    // Desert Biome
    new Beast("Fennec Fox", "A tiny nocturnal fox whose enormous ears shed heat and hear prey moving beneath the sand.", new List<Biome> { Biome.Desert }, Rarity.Common),
    new Beast("Dromedary Camel", "A hardy one-humped traveler that can go days without water.", new List<Biome> { Biome.Desert }, Rarity.Common),
    new Beast("Sidewinder Rattlesnake", "A pit viper that moves in looping sideways motions across loose dunes.", new List<Biome> { Biome.Desert }, Rarity.Common),
    new Beast("Deathstalker Scorpion", "A small, pale scorpion carrying one of the most potent venoms of its kind.", new List<Biome> { Biome.Desert }, Rarity.Common),
    new Beast("Gila Monster", "A slow, beaded lizard with a venomous bite and a grip that won't let go.", new List<Biome> { Biome.Desert }, Rarity.Common),
    new Beast("Megalania", "A giant prehistoric monitor lizard that ambushes prey from rocky outcrops.", new List<Biome> { Biome.Desert }, Rarity.Uncommon),
    new Beast("Titanotylopus", "A towering ancient camel that once crossed arid lands in great caravans.", new List<Biome> { Biome.Desert }, Rarity.Uncommon),
    new Beast("Teratornis", "An enormous scavenging bird that rides the thermals in search of the dead and dying.", new List<Biome> { Biome.Desert }, Rarity.Uncommon),
    new Mythic("Mongolian Death Worm", "A crimson worm said to spit acid and kill with a single jolt. Nomads may have mistaken a burrowing sand boa or worm lizard for something far deadlier.", new List<Biome> { Biome.Desert }),
    new Mythic("Chupacabra", "A spined predator blamed for draining livestock of blood. Most sightings trace back to coyotes stricken with severe mange.", new List<Biome> { Biome.Desert }),
    new Legendary("Sphinx", "A lion-bodied guardian with a human face that poses riddles to travelers and devours those who fail.", new List<Biome> { Biome.Desert }),

    // Tundra Biome
    new Beast("Arctic Fox", "A small fox whose coat turns from brown to white with the seasons.", new List<Biome> { Biome.Tundra }, Rarity.Common),
    new Beast("Caribou", "A large herbivore that is normally docile unless threatened. Travels in vast migrating herds.", new List<Biome> { Biome.Tundra }, Rarity.Common),
    new Beast("Musk Ox", "A shaggy grazer whose herd forms a horned defensive ring against predators.", new List<Biome> { Biome.Tundra }, Rarity.Common),
    new Beast("Snowy Owl", "A white daytime hunter that glides low and silent over the snow.", new List<Biome> { Biome.Tundra }, Rarity.Common),
    new Beast("Arctic Hare", "A thick-furred hare that digs through snow to reach buried plants.", new List<Biome> { Biome.Tundra }, Rarity.Common),
    new Beast("Woolly Mammoth", "A shaggy giant with curved tusks used to sweep snow off frozen grass.", new List<Biome> { Biome.Tundra }, Rarity.Uncommon),
    new Beast("Woolly Rhinoceros", "A heavily furred rhino with a flattened front horn for clearing snow.", new List<Biome> { Biome.Tundra }, Rarity.Uncommon),
    new Beast("Homotherium", "A long-legged, scimitar-toothed cat built to hunt young mammoths.", new List<Biome> { Biome.Tundra }, Rarity.Uncommon),
    new Mythic("Amarok", "A gigantic lone wolf said to hunt anyone foolish enough to travel the ice at night. Perhaps an unusually large wolf, its size growing with each retelling.", new List<Biome> { Biome.Tundra }),
    new Mythic("Ijiraq", "A shapeshifting spirit that lures wanderers away, leaving them unable to recall the encounter. Snow blindness and exhaustion may explain much.", new List<Biome> { Biome.Tundra }),
    new Legendary("Wendigo", "An emaciated, insatiable spirit of winter and hunger that grows larger with every meal.", new List<Biome> { Biome.Tundra }),

    // Cliffs Biome
    new Beast("Mountain Goat", "A sure-footed climber that walks narrow ledges where nothing else dares.", new List<Biome> { Biome.Cliffs }, Rarity.Common),
    new Beast("Bighorn Sheep", "Rams with massive curled horns that clash in head-on battles echoing across the peaks.", new List<Biome> { Biome.Cliffs }, Rarity.Common),
    new Beast("Golden Eagle", "A powerful raptor that nests on high crags and hunts the slopes below.", new List<Biome> { Biome.Cliffs, Biome.Plains }, Rarity.Common),
    new Beast("Peregrine Falcon", "The fastest animal alive, diving at prey at over 300 km/h.", new List<Biome> { Biome.Cliffs }, Rarity.Common),
    new Beast("Rock Hyrax", "A small, social mammal that suns itself on rocky ledges and shrieks at danger.", new List<Biome> { Biome.Cliffs }, Rarity.Common),
    new Beast("Haast's Eagle", "A massive eagle capable of striking down prey many times its own weight.", new List<Biome> { Biome.Cliffs }, Rarity.Uncommon),
    new Beast("Argentavis", "One of the largest flying birds ever, with a wingspan near seven meters.", new List<Biome> { Biome.Cliffs }, Rarity.Uncommon),
    new Beast("Cave Lion", "A maneless prehistoric lion that dens in cliffside caverns.", new List<Biome> { Biome.Cliffs }, Rarity.Uncommon),
    new Mythic("Hippogriff", "Half eagle, half horse, nesting on unreachable peaks. Distant travelers may have seen a great eagle carrying off a foal and filled in the rest.", new List<Biome> { Biome.Cliffs }),
    new Mythic("Harpy", "A winged, shrieking creature that swoops from the cliffs to snatch away its prey. The screams of nesting raptors carry far in the mountains.", new List<Biome> { Biome.Cliffs }),
    new Legendary("Roc", "A bird so immense it carries off elephants and blots out the sun as it passes.", new List<Biome> { Biome.Cliffs }),

    // Rainforest Biome
    new Beast("Jaguar", "A powerful ambush cat with a bite strong enough to pierce turtle shells.", new List<Biome> { Biome.Rainforest }, Rarity.Common),
    new Beast("Poison Dart Frog", "A tiny, brightly colored frog whose skin carries deadly toxins. Look, don't touch.", new List<Biome> { Biome.Rainforest }, Rarity.Common),
    new Beast("Howler Monkey", "A canopy dweller whose roar carries for miles through the jungle.", new List<Biome> { Biome.Rainforest }, Rarity.Common),
    new Beast("Scarlet Macaw", "A loud, brilliantly colored parrot that flocks in the high canopy.", new List<Biome> { Biome.Rainforest }, Rarity.Common),
    new Beast("Green Anaconda", "A massive constrictor that lurks in jungle rivers and flooded forest.", new List<Biome> { Biome.Rainforest, Biome.Swamp }, Rarity.Common),
    new Beast("Titanoboa", "A prehistoric snake over twelve meters long that hunts in steaming jungle waterways.", new List<Biome> { Biome.Rainforest }, Rarity.Uncommon),
    new Beast("Gigantopithecus", "An enormous ancient ape standing three meters tall that forages in dense bamboo.", new List<Biome> { Biome.Rainforest }, Rarity.Uncommon),
    new Beast("Phorusrhacos", "A flightless terror bird with a hooked, axe-like beak, built to run down prey.", new List<Biome> { Biome.Rainforest }, Rarity.Uncommon),
    new Mythic("Curupira", "A forest guardian with backward-facing feet that leaves misleading tracks to confuse hunters. The jungle has a way of turning even skilled trackers around.", new List<Biome> { Biome.Rainforest }),
    new Mythic("Ahool", "A giant bat with a monkey-like face and a cry that echoes through the canopy. Possibly a large owl or flying fox seen in the dark.", new List<Biome> { Biome.Rainforest }),
    new Legendary("Mapinguari", "A towering, foul-smelling beast with a gaping mouth in its belly and a hide no weapon can pierce.", new List<Biome> { Biome.Rainforest }),

    // Swamp Biome
    new Beast("American Alligator", "A patient ambush predator that lies motionless beneath murky water.", new List<Biome> { Biome.Swamp, Biome.Freshwater }, Rarity.Common),
    new Beast("Alligator Snapping Turtle", "A prehistoric-looking turtle that lures fish with a worm-like tongue.", new List<Biome> { Biome.Swamp }, Rarity.Common),
    new Beast("Cottonmouth", "A venomous water snake that gapes its white mouth as a warning.", new List<Biome> { Biome.Swamp }, Rarity.Common),
    new Beast("Great Blue Heron", "A tall wading bird that spears fish with lightning-fast strikes.", new List<Biome> { Biome.Swamp, Biome.Freshwater }, Rarity.Common),
    new Beast("American Bullfrog", "A large, deep-voiced frog that will eat nearly anything that fits in its mouth.", new List<Biome> { Biome.Swamp }, Rarity.Common),
    new Beast("Deinosuchus", "A colossal ancient crocodilian capable of taking down large prey at the water's edge.", new List<Biome> { Biome.Swamp }, Rarity.Uncommon),
    new Beast("Castoroides", "A bear-sized giant beaver that reshapes entire wetlands with its dams.", new List<Biome> { Biome.Swamp }, Rarity.Uncommon),
    new Beast("Arthropleura", "A giant millipede over two meters long that crawls through the rotting undergrowth.", new List<Biome> { Biome.Swamp }, Rarity.Uncommon),
    new Mythic("Will-o'-the-Wisp", "A drifting ghost light that lures travelers off safe paths and into the bog. Marsh gas igniting over the water is the likelier culprit.", new List<Biome> { Biome.Swamp }),
    new Mythic("Bunyip", "A bellowing creature said to lurk in swamps and billabongs. Its call may belong to a booming bittern, or the memory of long-vanished giant animals.", new List<Biome> { Biome.Swamp }),
    new Legendary("Hydra", "A many-headed serpent of the marsh that grows two heads for every one severed.", new List<Biome> { Biome.Swamp }),

    // Freshwater Biome
    new Beast("Beaver", "A tireless engineer that builds dams and lodges along rivers and streams.", new List<Biome> { Biome.Freshwater }, Rarity.Common),
    new Beast("River Otter", "A playful, agile swimmer that hunts fish and crayfish.", new List<Biome> { Biome.Freshwater }, Rarity.Common),
    new Beast("Northern Pike", "An ambush fish with a mouth full of backward-angled teeth.", new List<Biome> { Biome.Freshwater }, Rarity.Common),
    new Beast("Alligator Gar", "An armored, ancient fish with a long, toothy snout.", new List<Biome> { Biome.Freshwater }, Rarity.Common),
    new Beast("Belted Kingfisher", "A sharp-eyed bird that dives headfirst from riverside perches to catch fish.", new List<Biome> { Biome.Freshwater }, Rarity.Common),
    new Beast("Arapaima", "One of the largest freshwater fish, armored in scales that piranhas can't bite through.", new List<Biome> { Biome.Freshwater }, Rarity.Uncommon),
    new Beast("Mekong Giant Catfish", "A gentle giant of the river that can grow as large as a grizzly bear.", new List<Biome> { Biome.Freshwater }, Rarity.Uncommon),
    new Beast("Megapiranha", "A prehistoric piranha the size of a dog, with zigzag teeth that crush bone.", new List<Biome> { Biome.Freshwater }, Rarity.Uncommon),
    new Mythic("Kappa", "A mischievous river creature with a water-filled dish on its head. Giant salamanders and warnings to keep children from drowning may lie behind the tale.", new List<Biome> { Biome.Freshwater }),
    new Mythic("Kelpie", "A water horse that tempts riders onto its back, then drags them into the depths. A story perhaps born from fast currents and drownings at river crossings.", new List<Biome> { Biome.Freshwater }),
    new Legendary("Loch Ness Monster", "A long-necked creature glimpsed in deep, cold lakes. Photographed many times, yet never caught.", new List<Biome> { Biome.Freshwater }),
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