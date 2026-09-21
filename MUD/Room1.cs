using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Room1
    {
        public void PlayerInRoom1(Room RoomSet, Player PlayerCar)
        {
            RoomSet.Name = "dungeon entrance";
            RoomSet.north = true;
            RoomSet.west = false;
            RoomSet.east = false;
            RoomSet.south = false;
            Console.WriteLine("you are now in the " + RoomSet.Name);
            Console.ReadKey(true);

            while (PlayerCar.roomNumber == 0)
            {
                PlayerAction yourAction = new PlayerAction();
                yourAction.PlayerChoiceAction(PlayerCar, RoomSet);
                switch (PlayerCar.Choice)
                {
                    case "north":
                        Console.WriteLine("you move north");
                        PlayerCar.roomNumber = 1;
                        break;
                    case "west":
                        Console.WriteLine("there is a stone wall to the west");
                        Console.ReadKey(true);
                        Console.WriteLine("you go back");
                        Console.ReadKey(true);
                        break;
                    case "east":
                        Console.WriteLine("there is a stone wall to the east");
                        Console.ReadKey(true);
                        Console.WriteLine("you go back");
                        Console.ReadKey(true);
                        break;
                    case "south":
                        Console.WriteLine("The door you came through is to the south");
                        Console.ReadKey(true);
                        Console.WriteLine("the door is closed");
                        Console.ReadKey(true);
                        Console.WriteLine("you go back");
                        Console.ReadKey(true);
                        break;
                    default:
                        Console.WriteLine("an error occurred when trying to move");
                        break;
                }
            }
        }
    }
}