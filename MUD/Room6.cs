using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Room6
    {
        public void PlayerInRoom6(Room RoomSet, Player PlayerCar)
        {
            RoomSet.Name = "hidden camp";
            RoomSet.north = true;
            RoomSet.west = true;
            RoomSet.east = true;
            RoomSet.south = false;
            Console.WriteLine("you are now in the " + RoomSet.Name);
            Console.WriteLine("it looks like you can rest here");
            Console.ReadKey(true);

            while (PlayerCar.roomNumber == 5)
            {
                PlayerAction yourAction = new PlayerAction();
                yourAction.PlayerChoiceAction(PlayerCar, RoomSet);
                switch (PlayerCar.Choice)
                {
                    case "north":
                        Console.WriteLine("you move north");
                        PlayerCar.roomNumber = 6;
                        break;
                    case "west":
                        Console.WriteLine("you move west");
                        PlayerCar.roomNumber = 7;
                        break;
                    case "east":
                        Console.WriteLine("you move east");
                        PlayerCar.roomNumber = 3;
                        break;
                    case "south":
                        Console.WriteLine("there is nothing to the south");
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
