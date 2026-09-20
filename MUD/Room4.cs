using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Room4
    {
        public void PlayerInRoom4(Room RoomSet, Player PlayerCar)
        {
            RoomSet.Name = "Room 4";
            RoomSet.north = true;
            RoomSet.west = true;
            RoomSet.east = true;
            RoomSet.south = true;
            Console.WriteLine("you are now in the resting grounds");
            Console.ReadKey(true);

            while (PlayerCar.roomNumber == 3)
            {
                PlayerAction yourAction = new PlayerAction();
                yourAction.PlayerChoiceAction(PlayerCar);
                switch (PlayerCar.Choice)
                {
                    case "north":
                        Console.WriteLine("there is a wall to the north");
                        break;
                    case "west":
                        Console.WriteLine("you move west");
                        PlayerCar.roomNumber = 5;
                        break;
                    case "east":
                        Console.WriteLine("you move east");
                        PlayerCar.roomNumber = 1;
                        break;
                    case "south":
                        Console.WriteLine("there is a wall to the south");
                        break;
                    default:
                        Console.WriteLine("an error occurred when trying to move");
                        break;
                }
            }
        }
    }
}
