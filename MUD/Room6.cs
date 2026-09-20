using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Room6
    {
        public void PlayerInRoom6(Room RoomSet, Player PlayerCar)
        {
            RoomSet.Name = "Room 6";
            RoomSet.north = true;
            RoomSet.west = true;
            RoomSet.east = true;
            RoomSet.south = true;
            Console.WriteLine("you are now in the hidden camp");
            Console.ReadKey(true);

            while (PlayerCar.roomNumber == 5)
            {
                PlayerAction yourAction = new PlayerAction();
                yourAction.PlayerChoiceAction(PlayerCar);
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
                        break;
                    default:
                        Console.WriteLine("an error occurred when trying to move");
                        break;
                }
            }
        }
    }
}
