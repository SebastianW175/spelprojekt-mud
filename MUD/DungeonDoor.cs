using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class DungeonDoor
    {
        public void OpenDungeonDoor(Room RoomSet, Player PlayerCar)
        {
            Console.WriteLine("Open the dungeon door?");
            int i = 0;
            while (i < 1)
            {
                PlayerCar.Choice = Console.ReadLine();

                if (PlayerCar.Choice.ToLower() == "y" || PlayerCar.Choice.ToLower() == "yes")
                {
                    Console.WriteLine("you open the dungeon door and move forward");
                    PlayerCar.roomNumber = 2;
                    Console.ReadKey(true);
                    i = 1;
                }
                else if (PlayerCar.Choice.ToLower() == "n" || PlayerCar.Choice.ToLower() == "no")
                {
                    i = 1;
                }
                else
                {
                    Console.WriteLine("unknown command. Enter 'Yes' or 'No' next time.");
                }
            }
        }

    }
}
