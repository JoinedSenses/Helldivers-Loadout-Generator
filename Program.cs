/*
 * A console application which generates random loadouts for Helldivers 2
 * Author: JoinedSenses
 */
namespace HelldiversLoadoutGenerator
{
    internal class Program
    {
        private static readonly Random Rand = new Random();

        static void Main(string[] args)
        {
            Init();
        }

        private static void Init()
        {
            PrintHelp();

            while (true)
            {
                Console.Write("Enter command: ");

                string? input = Console.ReadLine();
                if (input == null)
                {
                    continue;
                }

                input = input.Trim().ToLower();

                if (input == "gen 4")
                {
                    Generate(4);
                }
                else if(input == "gen 3")
                {
                    Generate(3);
                }
                else if (input == "help")
                {
                    PrintHelp();
                }
                else if (input == "quit")
                {
                    Environment.Exit(0);
                    break; // Not needed but VS complains
                }
                else
                {
                    Console.WriteLine(
                        $"Unknown input: {input}\n"
                    );
                    break;
                }
            }
        }

        private static void PrintHelp()
        {
            Console.Clear();

            Console.WriteLine(
                "Helldivers Loadout Generator\n" +
                "\n" +
                "Commands:\n" +
                "  gen 3 - Generate 3 stratagems\n" +
                "  gen 4 - Generate 4 stratagems\n" +
                "  help - List commands\n" +
                "  quit - Close application\n\n"
            );
        }

        private static void Generate(int stratagemCount)
        {
            Console.Clear();

            GenerateCharacter();
            GenerateStratagems(stratagemCount);
        }

        private static void GenerateCharacter()
        {
            int idx = Rand.Next(0, Constants.Armors.Length);
            string armor = Constants.Armors[idx];

            idx = Rand.Next(0, Constants.Primaries.Length);
            string primary = Constants.Primaries[idx];

            idx = Rand.Next(0, Constants.Secondaries.Length);
            string secondary = Constants.Secondaries[idx];

            idx = Rand.Next(0, Constants.Grenades.Length);
            string grenade = Constants.Grenades[idx];

            Console.WriteLine(
                $"Arm:  {armor}\n" +
                $"Pri:  {primary}\n" +
                $"Sec:  {secondary}\n" +
                $"Gre:  {grenade}\n"
            );
        }

        private static void GenerateStratagems(int max)
        {
            bool selectedWeapon = false;
            bool selectedBackpack = false;
            bool selectedDefensive = false;

            List<string> list = new();
            list.AddRange(Constants.Weapons);
            list.AddRange(Constants.WeaponsWithBackpack);
            list.AddRange(Constants.Backpacks);
            list.AddRange(Constants.Offensives);
            list.AddRange(Constants.Defensives);

            List<string> stratagems = new();

            int i = 0;
            while (i < max)
            {
                int idx = Rand.Next(0, list.Count);
                var item = list[idx];

                if (stratagems.Contains(item))
                {
                    continue;
                }

                if (IsWeapon(item, out bool hasPack))
                {
                    if (selectedWeapon)
                    {
                        continue;
                    }

                    selectedWeapon = true;

                    if (!selectedBackpack && hasPack)
                    {
                        selectedBackpack = true;
                    }

                    if (i + 1 != max)
                    {
                        list = new();

                        list.AddRange(Constants.Offensives);

                        if (!selectedBackpack)
                        {
                            list.AddRange(Constants.Backpacks);
                        }

                        if (!selectedDefensive)
                        {
                            list.AddRange(Constants.Defensives);
                        }
                    }
                }
                else if (IsBackpack(item, out bool isWeapon))
                {
                    if (selectedBackpack)
                    {
                        continue;
                    }

                    selectedBackpack = true;

                    if (!selectedWeapon && isWeapon)
                    {
                        selectedWeapon = true;
                    }

                    if (i + 1 != max)
                    {
                        list = new();

                        list.AddRange(Constants.Offensives);

                        if (!selectedWeapon)
                        {
                            list.AddRange(Constants.Weapons);
                        }

                        if (!selectedDefensive)
                        {
                            list.AddRange(Constants.Defensives);
                        }
                    }
                }
                else if (IsDefensive(item))
                {
                    if (selectedDefensive)
                    {
                        continue;
                    }

                    selectedDefensive = true;

                    if (i + 1 != max)
                    {
                        list = new();

                        list.AddRange(Constants.Offensives);

                        if (!(selectedWeapon && selectedBackpack))
                        {
                            list.AddRange(Constants.Weapons);
                            list.AddRange(Constants.WeaponsWithBackpack);
                            list.AddRange(Constants.Backpacks);
                        }
                        else if (!selectedWeapon)
                        {
                            list.AddRange(Constants.Weapons);
                        }
                        else if (!selectedBackpack)
                        {
                            list.AddRange(Constants.Backpacks);
                        }
                    }
                }

                stratagems.Add(item);

                ++i;
            }

            stratagems.Sort(StratSort);

            for (i = 0; i < stratagems.Count; ++i)
            {
                Console.WriteLine($"S {i + 1}:  {stratagems[i]}");
            }

            Console.WriteLine();
        }

        private static bool IsWeapon(string name, out bool hasPack)
        {
            hasPack = false;

            return
                Constants.Weapons.Contains(name)
                || (hasPack = Constants.WeaponsWithBackpack.Contains(name));
        }

        private static bool IsBackpack(string name, out bool isWeapon)
        {
            isWeapon = false;

            return
                Constants.Backpacks.Contains(name)
                || (isWeapon = Constants.WeaponsWithBackpack.Contains(name));
        }

        private static bool IsDefensive(string name)
        {
            return Constants.Defensives.Contains(name);
        }

        private static int StratSort(string s1, string s2)
        {
            if (s1.Contains("(Weapon")) return -1;
            if (s2.Contains("(Weapon")) return 1;
            if (s1.Contains("(Backpack)")) return -1;
            if (s2.Contains("(Backpack)")) return 1;
            if (s1.Contains("(Offense)")) return -1;
            if (s2.Contains("(Offense)")) return 1;

            return 0;
        }
    }
}
