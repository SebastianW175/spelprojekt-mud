using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Items
    {
        public void ItemDrop(Player PlayerCar)
        {
            Random ItemsGot = new Random();
            int randomNumberOfItems = ItemsGot.Next(1, 3);

            for (int i = 0; i < randomNumberOfItems; i++)
            {
                Random WhatItems = new Random();
                int randomNumberWhatItems = WhatItems.Next(1, 7);
                if (randomNumberWhatItems == 1 || randomNumberWhatItems == 2)
                {
                    PlayerCar.Inventory.Add("HP Potion");
                    Console.WriteLine("HP Potion obtained.");
                }
                else if (randomNumberWhatItems == 3 || randomNumberWhatItems == 4)
                {
                    PlayerCar.Inventory.Add("MP Potion");
                    Console.WriteLine("MP Potion obtained.");
                }
                else if (randomNumberWhatItems == 5)
                {
                    PlayerCar.Inventory.Add("AllMax Potion");
                    Console.WriteLine("AllMax Potion obtained.");
                }
                else if (randomNumberWhatItems == 6)
                {
                    PlayerCar.Inventory.Add("Steel Potion");
                    Console.WriteLine("Steel Potion obtained.");
                }
            }
        }
    }
}
