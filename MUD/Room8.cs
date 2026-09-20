using System;
using System.Collections.Generic;
using System.Text;

namespace MUD
{
    public class Room8
    {
        public void PlayerInRoom8(Room RoomSet, Player PlayerCar)
        {
            RoomSet.Name = "Room 8";
            RoomSet.north = true;
            RoomSet.west = true;
            RoomSet.east = true;
            RoomSet.south = true;
            Console.WriteLine("you are now in the abandoned storage");
            Console.ReadKey(true);

            while (PlayerCar.roomNumber == 7)
            {
                PlayerAction yourAction = new PlayerAction();
                yourAction.PlayerChoiceAction(PlayerCar);
                switch (PlayerCar.Choice)
                {
                    case "north":
                        Console.WriteLine("there is a wall to the north");
                        break;
                    case "west":
                        Console.WriteLine("there is a chest to the west");
                        break;
                    case "east":
                        Console.WriteLine("you move east");
                        PlayerCar.roomNumber = 5;
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
