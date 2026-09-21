using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class OpenChest
    {
        public void PlayerOpenChest(Player PlayerCar)
        {
            Console.Write("open it?:");
            while (true)
            {
                PlayerCar.Choice = Console.ReadLine();
                if (PlayerCar.Choice == "yes" || PlayerCar.Choice == "y")
                {
                    if (PlayerCar.roomNumber == 4)
                    {
                        PlayerCar.Weapons.Add("RustySword");
                        Console.WriteLine("you got rusty sword (2)");
                        PlayerCar.Armors.Add("BrokenArmor");
                        Console.WriteLine("you got broken armor (1)");
                        PlayerCar.Chest1 = true;
                    }
                    else if (PlayerCar.roomNumber == 7)
                    {
                        PlayerCar.Rings.Add("IronRing");
                        Console.WriteLine("you got iron ring (3)");
                        PlayerCar.Armors.Add("WarriorArmor");
                        Console.WriteLine("you got warrior armor (3)");
                        PlayerCar.Chest2 = true;
                    }
                    else if (PlayerCar.roomNumber == 6)
                    {
                        PlayerCar.Weapons.Add("SteelSword");
                        Console.WriteLine("you got steel sword (5)");
                        PlayerCar.Rings.Add("EmeraldRing");
                        Console.WriteLine("you got emerald ring (6)");
                        PlayerCar.HasKey = true;
                        Console.WriteLine("you got the dungeon key!");
                        PlayerCar.Inventory.Add("DungeonKey");
                        PlayerCar.Chest3 = true;
                    }
                    break;
                }
                else if (PlayerCar.Choice == "no" || PlayerCar.Choice == "n")
                {
                    Console.WriteLine("You left the chest behind.");
                    break;
                }
                else
                {
                    Console.WriteLine("unknown command. Enter 'Yes' or 'No' next time.");
                }
            }
        }
    }
}
