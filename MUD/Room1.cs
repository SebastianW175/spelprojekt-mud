using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Room1
    {
        public void PlayerInRoom1(Room RoomSet, Player PlayerCar)
        {
            RoomSet.Name = "Room 1";
            RoomSet.north = true;
            RoomSet.west = false;
            RoomSet.east = false;
            RoomSet.south = false;
            Console.WriteLine("you are now in the dungeon entrance");
            Console.ReadKey(true);

            int i = 0;
            while (i < 1)
            {
                PlayerAction yourAction = new PlayerAction();
                yourAction.PlayerChoiceAction(PlayerCar);
                switch (PlayerCar.Choice)
                {
                    case "north":
                        Console.WriteLine("you move north");
                        PlayerCar.roomNumber = 1;
                        i = 1;
                        break;
                    case "west":
                        Console.WriteLine("there is a wall to the west");
                        break;
                    case "east":
                        Console.WriteLine("there is a wall to the east");
                        break;
                    case "south":
                        Console.WriteLine("you move south");
                        Console.WriteLine("the door you came through is closed");
                        break;
                    default:
                        Console.WriteLine("an error occurred when trying to move");
                        break;
                }
            }
        }
    }
}