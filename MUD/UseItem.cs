using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class UseItem
    {
        public void UsePlayerInventoryItem(Player PlayerCar)
        {
            int i = 0;
            Console.WriteLine("------------------------------------------------------------------------");
            foreach (string item in PlayerCar.Inventory)
            {
                if (i < 3)
                {
                    Console.Write(item + "     ");
                    i++;
                }
                else
                {
                    i = 0;
                    Console.WriteLine(item);
                }
            }
            if (i == 0)
            {
                Console.WriteLine("------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("------------------------------------------------------------------------");
            }
            Console.Write("what item do you want to use?:");
            int ie = 0;
            while (ie < 1)
            {
                PlayerCar.Choice = Console.ReadLine();
                switch (PlayerCar.Choice)
                {
                    case "HP":
                        if (PlayerCar.Inventory.Contains("HP Potion"))
                        {
                            ie++;
                            PlayerCar.HasUsedItem = true;
                            PlayerCar.Health += 80;
                            if (PlayerCar.Health > PlayerCar.MaxHealth)
                            {
                                PlayerCar.Health = PlayerCar.MaxHealth;
                                Console.WriteLine("You used an HP Potion. Your health is fully restored.");
                            }
                            else
                            {
                                PlayerCar.Inventory.Remove("HP Potion");
                                Console.WriteLine("You used an HP Potion. You have " + PlayerCar.Health + "/" + PlayerCar.MaxHealth + " HP");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You don't have any HP Potions.");
                        }
                        break;
                    case "MP":
                        if (PlayerCar.Inventory.Contains("MP Potion"))
                        {
                            ie++;
                            PlayerCar.HasUsedItem = true;
                            PlayerCar.MagicPoints += 50;
                            if (PlayerCar.MagicPoints > PlayerCar.MaxMagicPoints)
                            {
                                PlayerCar.MagicPoints = PlayerCar.MaxMagicPoints;
                                Console.WriteLine("You used an MP Potion. Your magic is maxed out.");
                            }
                            else
                            {
                                PlayerCar.Inventory.Remove("MP Potion");
                                Console.WriteLine("You used an MP Potion. You have " + PlayerCar.MagicPoints + "/" + PlayerCar.MaxMagicPoints + " MP");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You don't have any MP Potions.");
                        }
                        break;
                    case "AllMax":
                        if (PlayerCar.Inventory.Contains("AllMax Potion"))
                        {
                            ie++;
                            PlayerCar.HasUsedItem = true;
                            PlayerCar.Health = PlayerCar.MaxHealth;
                            PlayerCar.MagicPoints = PlayerCar.MaxMagicPoints;
                            PlayerCar.Inventory.Remove("AllMax Potion");
                            Console.WriteLine("You used an AllMax Potion. Your HP and MP are now maxed out.");
                        }
                        else
                        {
                            Console.WriteLine("You don't have any AllMax Potions.");
                        }
                        break;
                    case "Steel":
                        if (PlayerCar.Inventory.Contains("Steel Potion"))
                        {
                            ie++;
                            PlayerCar.HasUsedItem = true;
                            PlayerCar.Defend = true;
                            if (PlayerCar.MagicPoints > PlayerCar.MaxMagicPoints)
                            {
                                PlayerCar.MagicPoints = PlayerCar.MaxMagicPoints;
                                Console.WriteLine("You used a Steel Potion. Your defense has increased temporarily and your MP is maxed out.");
                            }
                            else
                            {
                                PlayerCar.Inventory.Remove("Steel Potion");
                                Console.WriteLine("You used a Steel Potion. Your defense has increased temporarily and you have " + PlayerCar.MagicPoints + "/" + PlayerCar.MaxMagicPoints + " MP.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You don't have any Steel Potions.");
                        }
                        break;
                    case "exit":
                        Console.WriteLine("you decided not to use an item");
                        ie++;
                        break;
                    default:
                        Console.WriteLine("unknown item or unknown command");
                        break;
                }
                Console.ReadKey(true);
            }
        }
    }
}
