using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class EquipGear
    {
        public void PlayerInventoryEquipGear(Player PlayerCar)
        {
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Weapon:" + PlayerCar.Weapon);
            Console.WriteLine("Armor:" + PlayerCar.Armor);
            Console.WriteLine("Ring:" + PlayerCar.Ring);
            Console.WriteLine("------------------------------------------------------------------------");
            int i = 0;
            while (i < 1)
            {
                Console.Write("choose an type of gear you want to change:");
                PlayerCar.Choice = Console.ReadLine();
                switch (PlayerCar.Choice)
                {
                    case "weapon":
                        Console.WriteLine("Equipped weapon:" + PlayerCar.Weapon);
                        foreach (string item in PlayerCar.Weapons)
                        {
                            Console.WriteLine("- " + item);
                        }
                        while (true)
                        {
                            Console.Write("Choose a weapon to equip:");
                            PlayerCar.Choice = Console.ReadLine();

                            if (PlayerCar.Weapons.Contains(PlayerCar.Choice))
                            {
                                GearStatsForPlayer GearStatsNew = new GearStatsForPlayer();
                                GearStatsNew.CalculatePlayerStats(PlayerCar);

                                PlayerCar.Weapons.Add(PlayerCar.Weapon);
                                PlayerCar.Weapon = PlayerCar.Choice;
                                PlayerCar.Weapons.Remove(PlayerCar.Choice);
                                Console.WriteLine("You have equipped " + PlayerCar.Weapon);
                                if (PlayerCar.Weapons.Contains("Nothing"))
                                {
                                    PlayerCar.Weapons.Remove("Nothing");
                                }
                                break;
                            }
                            else if (PlayerCar.Choice == "unequip")
                            {
                                PlayerCar.Weapons.Add(PlayerCar.Weapon);
                                PlayerCar.Weapon = "Nothing";
                                Console.WriteLine("You have unequipped your weapon");
                                break;
                            }
                            else if (PlayerCar.Choice == "exit" || PlayerCar.Choice == "quit" || PlayerCar.Choice == "back" || PlayerCar.Choice == "cancel")
                            {
                                Console.WriteLine("you chose not to change your weapon");
                                break;
                            }
                            else
                            {
                            Console.Write("unknown weapon. try again:");
                            }

                        }
                        break;
                    case "armor":
                        Console.WriteLine("Equipped armor:" + PlayerCar.Armor);
                        foreach (string item in PlayerCar.Armors)
                        {
                            Console.WriteLine("- " + item);
                        }
                        while (true)
                        {
                            Console.Write("Choose a armor to equip:");
                            PlayerCar.Choice = Console.ReadLine();

                            if (PlayerCar.Armors.Contains(PlayerCar.Choice))
                            {
                                GearStatsForPlayer GearStatsNew = new GearStatsForPlayer();
                                GearStatsNew.CalculatePlayerStats(PlayerCar);

                                PlayerCar.Armors.Add(PlayerCar.Armor);
                                PlayerCar.Armor = PlayerCar.Choice;
                                PlayerCar.Armors.Remove(PlayerCar.Choice);
                                Console.WriteLine("You have equipped " + PlayerCar.Armor);
                                if (PlayerCar.Armors.Contains("Nothing"))
                                {
                                    PlayerCar.Armors.Remove("Nothing");
                                }
                                break;
                            }
                            else if (PlayerCar.Choice == "unequip")
                            {
                                PlayerCar.Armors.Add(PlayerCar.Armor);
                                PlayerCar.Armor = "Nothing";
                                Console.WriteLine("You have unequipped your armor");
                                break;
                            }
                            else if (PlayerCar.Choice == "exit" || PlayerCar.Choice == "quit" || PlayerCar.Choice == "back" || PlayerCar.Choice == "cancel")
                            {
                                Console.WriteLine("you chose not to change your armor");
                                break;
                            }
                            else
                            {
                                Console.Write("unknown armor. try again:");
                            }

                        }
                        break;
                    case "ring":
                        Console.WriteLine("Equipped ring:" + PlayerCar.Ring);
                        foreach (string item in PlayerCar.Rings)
                        {
                            Console.WriteLine("- " + item);
                        }
                        while (true)
                        {
                            Console.Write("Choose a ring to equip:");
                            PlayerCar.Choice = Console.ReadLine();

                            if (PlayerCar.Rings.Contains(PlayerCar.Choice))
                            {
                                GearStatsForPlayer GearStatsNew = new GearStatsForPlayer();
                                GearStatsNew.CalculatePlayerStats(PlayerCar);

                                PlayerCar.Rings.Add(PlayerCar.Ring);
                                PlayerCar.Ring = PlayerCar.Choice;
                                PlayerCar.Rings.Remove(PlayerCar.Choice);
                                Console.WriteLine("You have equipped " + PlayerCar.Ring);
                                if (PlayerCar.Rings.Contains("Nothing"))
                                {
                                    PlayerCar.Rings.Remove("Nothing");
                                }
                                break;
                            }
                            else if (PlayerCar.Choice == "unequip")
                            {
                                PlayerCar.Rings.Add(PlayerCar.Ring);
                                PlayerCar.Ring = "Nothing";
                                Console.WriteLine("You have unequipped your ring");
                                break;
                            }
                            else if (PlayerCar.Choice == "exit" || PlayerCar.Choice == "quit" || PlayerCar.Choice == "back" || PlayerCar.Choice == "cancel")
                            {
                                Console.WriteLine("you chose not to change your ring");
                                break;
                            }
                            else
                            {
                                Console.Write("unknown ring. try again:");
                            }

                        }
                        break;
                    case "exit":
                        i = 1;
                        break;
                    case "quit":
                        i = 1;
                        break;
                    case "back":
                        i = 1;
                        break;
                    case "cancel":
                        i = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
