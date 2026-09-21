using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    internal class Help
    {
        public void PlayerHelp(Player PlayerCar, Room RoomSet)
        {
            if (PlayerCar.IsInBattle == false)
            {
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine("available commands:");
                Console.WriteLine("- 'inventory' view and use your items and gear");
                Console.WriteLine("- 'status' check your character's stats");
                Console.WriteLine("- 'map' show the dungeon layout");
                Console.WriteLine("- 'rest' rest and recover HP and MP in the hidden camp");
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine("directions you can go:");
                if (RoomSet.north)
                {
                    Console.WriteLine("- 'north'");
                }
                if (RoomSet.west)
                {
                    Console.WriteLine("- 'west'");
                }
                if (RoomSet.east)
                {
                    Console.WriteLine("- 'east'");
                }
                if (RoomSet.south)
                {
                    Console.WriteLine("- 'south'");
                }
            }
            else
            {
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine("available commands:");
                Console.WriteLine("- 'attack' attack the enemy");
                Console.WriteLine("- 'fireball' cast a fireball spell (costs 20 MP)");
                Console.WriteLine("- 'heal' restore health (costs 10 MP)");
                Console.WriteLine("- 'kill' deal high damage if it crits (costs 15 MP)");
                Console.WriteLine("- 'defend' protect yourself and gain MP");
                Console.WriteLine("- 'item' use an item from your inventory");
                Console.WriteLine("------------------------------------------------------------------------");
            }
        }
    }
}
